using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using YCBX.Office.ExcelXml;

namespace WordOpenXml
{
    public static class ExcelXml
    {
        /// <summary>
        /// 导入excel数据
        /// </summary>
        public static void ImportExcelData<T>(string fileName,IEnumerable<T> list)
        {
            using var spreadsheetDocument = SpreadsheetDocument.Create(fileName, SpreadsheetDocumentType.Workbook);
            var workbookPart = spreadsheetDocument.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();
            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            Worksheet worksheet = new Worksheet(new SheetData());
            worksheetPart.Worksheet = worksheet;
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
            Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
            
            sheets.Append(sheet);
            var sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
            MergeCells mergeCells = new MergeCells();

            foreach (T item in list)
            {
                Row row = new Row();
                var property = item.GetType().GetProperties();
                foreach (var prop in property)
                {
                    Cell dataCell = new Cell();
                    dataCell.CellValue = new CellValue(prop.GetValue(item).ToString());
                    dataCell.DataType = new EnumValue<CellValues>(CellValues.String);
                    row.AppendChild(dataCell);
                }
                sheetData.Append(row);
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    Row row = new Row();
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Cell dataCell = new Cell();
            //        dataCell.CellValue = new CellValue($"{i + 1}行{j + 1}列");
            //        dataCell.DataType = new EnumValue<CellValues>(CellValues.String);
            //        row.AppendChild(dataCell);
            //    }
            //    sheetData.Append(row);
            //}

            worksheet.Save();
            spreadsheetDocument.Close();
        }

        public static void ImportExcelDataForTemplate<T>(string fileName, string sheetName,IEnumerable<T> list)
        {
            using var spreadsheetDocument = SpreadsheetDocument.Open(fileName,true);
            
            Worksheet worksheet = GetWorksheet(spreadsheetDocument, sheetName);

            uint rowIndex = 30;
            
            var sheetData = worksheet.GetFirstChild<SheetData>();
            foreach (T item in list)
            {
                Row row;
                if (sheetData.Elements<Row>().Where(r => r.RowIndex == rowIndex).Count()==0)
                {
                     row = new Row() { RowIndex = rowIndex };
                }
                else {
                    row = sheetData.Elements<Row>().Where(r => r.RowIndex == rowIndex).FirstOrDefault();
                   
                }
                
                var property = item.GetType().GetProperties();
                foreach (var prop in property)
                {
                    Cell dataCell = new Cell();
                    dataCell.CellValue = new CellValue(prop.GetValue(item).ToString());
                    dataCell.DataType = new EnumValue<CellValues>(CellValues.String);
                    row.AppendChild(dataCell);
                }
                sheetData.Append(row);
                rowIndex++;
            }

            worksheet.Save();
            spreadsheetDocument.Close();
        }

        /// <summary>
        /// 导出excel数据
        /// </summary>
        public static void ExportExcelData<T>() where T:class, new()
        {
            using SpreadsheetDocument doc = SpreadsheetDocument.Open(@"D:\Document\OpenXml.xlsx", false);
            WorkbookPart wbPart = doc.WorkbookPart;
            Sheet mysheet = (Sheet)doc.WorkbookPart.Workbook.Sheets.ChildElements.FirstOrDefault();
            Worksheet worksheet = ((WorksheetPart)wbPart.GetPartById(mysheet.Id)).Worksheet;
            SheetData sheetData = worksheet.GetFirstChild<SheetData>();

            Dictionary<int, string> propertyNameDic = new Dictionary<int, string>();
            IList<T> resultList = new List<T>();

            for (int i = 0; i < sheetData.ChildElements.Count; i++)
            {
                var row = sheetData.ChildElements[i];
                var rowChildern = (row as Row).ChildElements;
                //属性名
                if (i == 0)
                {
                    for (int j = 0; j < rowChildern.Count; j++)
                    {
                        var cellValue = (rowChildern[j] as Cell)?.CellValue;
                        if (cellValue != null)
                        {
                            propertyNameDic.Add(j,cellValue.Text);
                        }
                    }
                }
                //属性值
                else
                {
                    T value = new T();
                    for (int j = 0; j < rowChildern.Count; j++)
                    {
                        var cellValue = (rowChildern[j] as Cell)?.CellValue;
                        if (cellValue == null) continue;
                        var propertyName = propertyNameDic[j];
                        typeof(T).GetProperty(propertyName)?.SetValue(typeof(T), cellValue.Text);
                    }
                    resultList.Add(value);
                }
            }

            //foreach (var row in sheetData.ChildElements)
            //{
            //    foreach (var cell in (row as Row).ChildElements)
            //    {
            //        var cellValue = (cell as Cell).CellValue;
            //        if (cellValue != null)
            //        {
            //            Console.WriteLine(cellValue.Text);
            //        }
            //    }
            //}
        }

        /// <summary>
        /// 合并单元格
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="sheetName">sheet名称</param>
        /// <param name="startCell">开始单元格A1</param>
        /// <param name="endCell"></param>
        public static void MergeCells(string fileName,string sheetName,string startCell,string endCell) 
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, true))
            {
                Worksheet worksheet = GetWorksheet(document, sheetName);
                // Create Spreadsheet cells.  
                CreateSpreadsheetCell(worksheet, startCell);
                CreateSpreadsheetCell(worksheet, endCell);
                MergeCells mergeCells;

                if (worksheet.Elements<MergeCells>().Count() > 0)
                    mergeCells = worksheet.Elements<MergeCells>().First();
                else
                {
                    mergeCells = new MergeCells();

                    // Insert a MergeCells object into the specified position.  
                    if (worksheet.Elements<CustomSheetView>().Count() > 0)
                        worksheet.InsertAfter(mergeCells, worksheet.Elements<CustomSheetView>().First());
                    else
                        worksheet.InsertAfter(mergeCells, worksheet.Elements<SheetData>().First());
                }

                // Create the merged cell and append it to the MergeCells collection.  
                MergeCell mergeCell = new MergeCell()
                {
                    Reference =
                    new StringValue(startCell + ":" + endCell)
                };
                mergeCells.Append(mergeCell);
                worksheet.Save();
            }
            Console.WriteLine("The two cells are now merged.\nPress a key.");
            Console.ReadKey();
        }

        private static Worksheet GetWorksheet(SpreadsheetDocument document, string worksheetName)
        {
            IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook
                .Descendants<Sheet>().Where(s => s.Name == worksheetName);
            WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart
                .GetPartById(sheets.First().Id);
            return worksheetPart.Worksheet;


            //Worksheet;
            //Sheet
            //WorksheetPart
        }

        // Create a spreadsheet cell.   
        private static void CreateSpreadsheetCell(Worksheet worksheet, string cellName)
        {
            string columnName = GetColumnName(cellName);
            uint rowIndex = 2;
            IEnumerable<Row> rows = worksheet.Descendants<Row>().Where(r => r
                .RowIndex.Value == rowIndex);
            Row row = rows.First();
            IEnumerable<Cell> cells = row.Elements<Cell>().Where(c => c.CellReference
                .Value == cellName);
        }

        // Parse the cell name to get the column name.  
        private static string GetColumnName(string cellName)
        {
            // Create a regular expression to match the column name portion of the cell name.  
            Regex regex = new Regex("[A-Za-z]+");
            Match match = regex.Match(cellName);
            return match.Value;
        }

        private static void NewMethod(uint row, int column, string text, SharedStringTablePart shareStringPart, WorksheetPart worksheetPart)
        {
            #region 将文本插入到SharedStringTablePart中

            int index = 0;

            //遍历SharedStringTable中的所有项。如果文本已经存在，则返回其索引。
            foreach (SharedStringItem item in shareStringPart.SharedStringTable.Elements<SharedStringItem>())
            {
                if (item.InnerText == text)
                    break;
                index++;
            }

            //这部分没有正文。创建SharedStringItem并返回它的索引。
            shareStringPart.SharedStringTable.AppendChild(new SharedStringItem(new DocumentFormat.OpenXml.Spreadsheet.Text(text)));

            #endregion

            #region 将单元格A1插入工作表

            Worksheet worksheet = worksheetPart.Worksheet;
            SheetData sheetData = worksheet.GetFirstChild<SheetData>();

            string columnName = ExcelAlphabet.ColumnToABC(column);
            uint rowIndex = row;

            string cellReference = columnName + rowIndex;

            //如果工作表不包含具有指定行索引的行，则插入一行
            Row rowobj;
            if (sheetData.Elements<Row>().Where(r => r.RowIndex == rowIndex).Count() != 0)
            {
                rowobj = sheetData.Elements<Row>().Where(r => r.RowIndex == rowIndex).First();
            }
            else
            {
                rowobj = new Row() { RowIndex = rowIndex };
                sheetData.Append(rowobj);
            }

            Cell newCell2;
            //如果没有具有指定列名的单元格，则插入一个。
            if (rowobj.Elements<Cell>().Where(c => c.CellReference.Value == columnName + rowIndex).Count() > 0)
            {
                newCell2 = rowobj.Elements<Cell>().Where(c => c.CellReference.Value == cellReference).First();
            }
            else
            {
                //细胞必须按照细胞参考的顺序排列。确定在何处插入新单元格。
                Cell refCell = null;
                foreach (Cell item in rowobj.Elements<Cell>())
                {
                    if (item.CellReference.Value.Length == cellReference.Length)
                    {
                        if (string.Compare(item.CellReference.Value, cellReference, true) > 0)
                        {
                            refCell = item;
                            break;
                        }
                    }
                }

                Cell newCell = new Cell() { CellReference = cellReference };
                rowobj.InsertBefore(newCell, refCell);

                newCell2 = newCell;
            }
            #endregion

            //设置单元格A1的值
            newCell2.CellValue = new CellValue(index.ToString());
            newCell2.DataType = new EnumValue<CellValues>(CellValues.SharedString);
        }
    }

    
}