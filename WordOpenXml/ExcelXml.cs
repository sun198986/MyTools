using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace WordOpenXml
{
    public static class ExcelXml
    {
        /// <summary>
        /// 导入数据
        /// </summary>
        public static void ImportExcelData()
        {
            using var spreadsheetDocument = SpreadsheetDocument.Create(@"D:\Document\OpenXml.xlsx", SpreadsheetDocumentType.Workbook);
            var workbookPart = spreadsheetDocument.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();
            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
            Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
            sheets.Append(sheet);
            var sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
            MergeCells mergeCells = new MergeCells();

            for (int i = 0; i < 10; i++)
            {
                Row row = new Row();
                for (int j = 0; j < 10; j++)
                {
                    Cell dataCell = new Cell();
                    dataCell.CellValue = new CellValue($"{i + 1}行{j + 1}列");
                    dataCell.DataType = new EnumValue<CellValues>(CellValues.String);
                    row.AppendChild(dataCell);
                }
                sheetData.Append(row);
            }


            workbookPart.Workbook.Save();
            spreadsheetDocument.Close();
        }

        /// <summary>
        /// 导出数据
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

        
    }

    
}