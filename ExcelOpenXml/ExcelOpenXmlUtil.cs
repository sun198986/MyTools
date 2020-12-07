using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExcelOpenXml
{
    public class ExcelOpenXmlUtil : IDisposable
    {

        private string _filePath;

        private string _filelName;

        private string _fileFullName;

        private string _sheetName;

        private SpreadsheetDocument _spreadsheetDocument;


        /// <summary>
        ///  文档类
        /// </summary>
        private SpreadsheetDocument _document;
        public ExcelOpenXmlUtil(string fileFullName)
        {
            this._fileFullName = fileFullName;
        }

        public ExcelOpenXmlUtil(string fileFullName, string sheetName)
        {
            this._fileFullName = fileFullName;
            this._sheetName = sheetName;
        }


        //导入数据
        public void ImportExcelDataForTemplate<T>(IEnumerable<T> list,uint rowIndex)
        {
            //打开可编辑的excel
            OpenExcel(true);

            Worksheet worksheet = GetWorksheet(_spreadsheetDocument, _sheetName);

            var sheetData = worksheet.GetFirstChild<SheetData>();
            //遍历行
            for (var i = 0; i < list.Count(); i++)
            {
                var item = list.ToList()[i];
                uint cellRowIndex = rowIndex + (uint)i;
                Row row;
                //行不存在
                if (sheetData.Elements<Row>().Where(r => r.RowIndex == cellRowIndex).Count() == 0)
                {
                    row = new Row() { RowIndex = cellRowIndex };
                    sheetData.Append(row);
                }
                //行已存在
                else
                {
                    row = sheetData.Elements<Row>().Where(r => r.RowIndex == cellRowIndex).FirstOrDefault();
                }

                //遍历插入数据 列上插入
                var property = item.GetType().GetProperties();
                for (int j = 0; j < property.Length; j++)
                {
                    var prop = property[j];
                    var cellColumnIndex = j + 1;

                    string reference = GetCellName(cellRowIndex, cellColumnIndex);

                    Cell dataCell = new Cell { CellReference = reference };
                    //如果行上的单元格已存在,修改单元格内容
                    if (row.Elements<Cell>().Where(c => c.CellReference!=null && c.CellReference.Value == reference).Count() > 0)
                    {
                        dataCell = row.Elements<Cell>().Where(s => s.CellReference == reference).FirstOrDefault();
                    }
                    //不存在就将单元格插入
                    else
                    {
                        //判断单元格的插入顺序
                        Cell refCell = null;
                        foreach (Cell cellItem in row.Elements<Cell>())
                        {
                            if (cellItem.CellReference.Value.Length == reference.Length)
                            {
                                if (string.Compare(cellItem.CellReference.Value, reference, true) > 0)
                                {
                                    refCell = cellItem;
                                    break;
                                }
                            }
                        }
                        //如果没有内容就在最后追加
                        if (refCell == null)
                            row.AppendChild(dataCell);
                        //如果需要插入内容的单元格后有内容,就在前边插入
                        else
                            row.InsertBefore(dataCell, refCell);
                    }
                    dataCell.CellValue = new CellValue(prop.GetValue(item).ToString());
                    dataCell.DataType = new EnumValue<CellValues>(CellValues.String);
                }
            }

            //遍历完之后合并单元格

            _spreadsheetDocument.Save();
        }


        //打开一个excel文档
        private void OpenExcel(bool isEditor)
        {
            _spreadsheetDocument = SpreadsheetDocument.Open(_fileFullName, isEditor);
        }


        /// <summary>
        /// 新的空白Excel文档
        /// </summary>
        /// <returns></returns>
        public void NewCreate()
        {
            //创建 xlsx
            _spreadsheetDocument = SpreadsheetDocument.Create(_fileFullName, SpreadsheetDocumentType.Workbook);

            //将工作簿部件添加到文档中
            WorkbookPart workbookpart = _spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            //将工作表部分添加到工作簿部分
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            //将工作表添加到工作簿
            Sheets sheets = _spreadsheetDocument.WorkbookPart.Workbook.
                AppendChild<Sheets>(new Sheets());

            //附加新工作表并将其与工作簿关联
            Sheet sheet = new Sheet()
            {
                Id = _spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Sheet1"
            };
            sheets.Append(sheet);

            workbookpart.Workbook.Save();
            //_spreadsheetDocument.Close();
        }

        #region 内部调用
        private static Worksheet GetWorksheet(SpreadsheetDocument document, string worksheetName)
        {
            IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook
                .Descendants<Sheet>().Where(s => s.Name == worksheetName);
            WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart
                .GetPartById(sheets.First().Id);
            return worksheetPart.Worksheet;
        }


        public void MergeCells(string fileName, string sheetName, string startCell, string endCell)
        {
            OpenExcel(true);
            Worksheet worksheet = GetWorksheet(_spreadsheetDocument, sheetName);
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

        private string GetCellName(uint rowIndex, int columnIndex)
        {
            return ExcelAlphabet.ColumnToABC(columnIndex) + rowIndex;
        }

        // Create a spreadsheet cell.   
        private void CreateSpreadsheetCell(Worksheet worksheet, string cellName)
        {
            string columnName = GetColumnName(cellName);
            uint rowIndex = 2;
            IEnumerable<Row> rows = worksheet.Descendants<Row>().Where(r => r
                .RowIndex.Value == rowIndex);
            Row row = rows.First();
            IEnumerable<Cell> cells = row.Elements<Cell>().Where(c => c.CellReference
                .Value == cellName);
        }

        private static string GetColumnName(string cellName)
        {
            // Create a regular expression to match the column name portion of the cell name.  
            Regex regex = new Regex("[A-Za-z]+");
            Match match = regex.Match(cellName);
            return match.Value;
        }

        #endregion

        public void Dispose()
        {
            _spreadsheetDocument.Close();
            GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }
    }
}
