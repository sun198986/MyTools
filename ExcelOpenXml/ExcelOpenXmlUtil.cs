using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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


        /// <summary>
        /// 导入excel(需要模板,文件在外边复制)
        /// </summary>
        /// <typeparam name="T">导入对象</typeparam>
        /// <param name="list">集合:需按照groupColumnProperty排序</param>
        /// <param name="rowIndex">开始行写入</param>
        /// <param name="columnInex">开始列写入</param>
        /// <param name="groupColumnProperty">按照此属性合并单元格</param>
        /// <param name="needMergeColumnProperty">需合并单元格属性名</param>
        public void ImportExcelDataForTemplate<T>(IEnumerable<T> list, int rowIndex, int columnInex, string groupColumnProperty="", string needMergeColumnProperty="")
        {
            if (list==null||list.Count()==0) {
                Console.WriteLine($"集合不能为null");
                throw new Exception($"集合不能为null");
            }
            //打开可编辑的excel
            OpenExcel(true);

            Worksheet worksheet = GetWorksheet(_spreadsheetDocument, _sheetName);

            var sheetData = worksheet.GetFirstChild<SheetData>();

            //上一个需要合并的列值
            string foreValue = string.Empty;
            //开始合并的行
            int startMergeRow = rowIndex ;
            //结束合并的行
            int endMergeRow = rowIndex;
            //需要合并的列
            int needMergeColumn = 0;
            //当前列的值
            string currentValue = string.Empty;
            //需要合并行的集合
            List<MergeCellInfo> mergeCellInfos = new List<MergeCellInfo>();

            //遍历行
            for (var i = 0; i < list.Count(); i++)
            {
                var item = list.ToList()[i];
                uint cellRowIndex = (uint)rowIndex + (uint)i;
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
                    currentValue = prop.GetValue(item).ToString();
                    var cellColumnIndex = columnInex + j + 1;
                    //第一行查看需要合并列(默认第一行不需要合并)
                    if (i == 0&&prop.Name== needMergeColumnProperty) {
                        needMergeColumn = j+columnInex;
                    }
                    if (prop.Name == groupColumnProperty) {
                        if (string.IsNullOrEmpty(foreValue))
                            foreValue = currentValue;
                        else if (currentValue != foreValue)
                        {
                            endMergeRow = int.Parse((cellRowIndex - 1).ToString());
                            //需要合并的行startMergeRow到i
                            if (startMergeRow != cellRowIndex - 1) {
                                MergeCellInfo mergeCellInfo = new MergeCellInfo
                                {
                                    StartCell = GetCellName((uint)startMergeRow, needMergeColumn),
                                    EndCell = GetCellName(cellRowIndex - 1, needMergeColumn)
                                };
                                mergeCellInfos.Add(mergeCellInfo);
                            }
                            startMergeRow = int.Parse(cellRowIndex.ToString());
                            foreValue = currentValue;
                        }
                        //最后一行往前合并
                        else if (i == list.Count() - 1) {
                            if (currentValue == foreValue && cellRowIndex - 1 != endMergeRow) {
                                MergeCellInfo mergeCellInfo = new MergeCellInfo
                                {
                                    StartCell = GetCellName((uint)startMergeRow, needMergeColumn),
                                    EndCell = GetCellName(cellRowIndex, needMergeColumn)
                                };
                                mergeCellInfos.Add(mergeCellInfo);
                            }
                        }
                    }

                    string reference = GetCellName(cellRowIndex, cellColumnIndex);

                    Cell dataCell = new Cell { CellReference = reference };
                    //如果行上的单元格已存在,修改单元格内容
                    if (row.Elements<Cell>().Where(c => c.CellReference != null && c.CellReference.Value == reference).Count() > 0)
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
                    dataCell.CellValue = new CellValue(currentValue);
                    dataCell.DataType = new EnumValue<CellValues>(CellValues.String);
                }
            }

            //遍历完之后合并单元格
            Console.WriteLine(mergeCellInfos.Count);
            if (mergeCellInfos.Count > 0) {
                foreach (var item in mergeCellInfos)
                {
                    this.MergeCells(item.StartCell, item.EndCell);
                }
            }
           
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


        private void MergeCells(string startCell, string endCell)
        {
            Worksheet worksheet = GetWorksheet(_spreadsheetDocument, _sheetName);
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
        }

        private string GetCellName(uint rowIndex, int columnIndex)
        {
            return ExcelAlphabet.ColumnToABC(columnIndex) + rowIndex;
        }

        // Create a spreadsheet cell.   
        private void CreateSpreadsheetCell(Worksheet worksheet, string cellName)
        {
            string columnName = GetColumnName(cellName);
            string strSplit1 = Regex.Replace(cellName, "[0-9]", "", RegexOptions.IgnoreCase);
            int rowIndex = ExcelAlphabet.ABCToColumn(strSplit1);
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

    class MergeCellInfo
    {

        public string StartCell { get; set; }

        public string EndCell { get; set; }
    }
}
