using System;
using System.Collections.Generic;
using System.Linq;
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
            using var spreadsheetDocument = SpreadsheetDocument.Create(@"E:\Common_Soft\OpenXml.xlsx", SpreadsheetDocumentType.Workbook);
            var workbookPart = spreadsheetDocument.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();
            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
            Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
            sheets.Append(sheet);
            var sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
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
            using SpreadsheetDocument doc = SpreadsheetDocument.Open(@"E:\Common_Soft\OpenXml.xlsx", false);
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
    }
}