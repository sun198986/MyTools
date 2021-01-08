using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExcelOpenXml
{
    public static class ExcelRead
    {
        /// <summary>
        /// 读取、解析
        /// </summary>
        /// <param name="fileName">文件</param>
        /// <param name="sheetName">工作表（默认第一个）</param>
        /// <param name="type">1 不去空格 2 前后空格 3 所有空格  </param>
        /// <returns></returns>
        public static List<ExcelCellInfo> Read(string fileName, string sheetName = "", int type = 2)
        {
            List<ExcelCellInfo> excelCellInfos = new List<ExcelCellInfo>();

            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                //查找工作薄
                Sheet sheet = ExcelSeek.SeekSheet(workbookPart, sheetName);

                //工作表
                WorksheetPart worksheetPart = (WorksheetPart)spreadsheetDocument.WorkbookPart.GetPartById(sheet.Id);
                //数据行
                var rows = worksheetPart.Worksheet.Descendants<Row>();//获得Excel中得数据行
                foreach (Row r in rows)
                {
                    foreach (Cell c in r.Elements<Cell>())
                    {
                        ExcelCellInfo excelCellInfo = new ExcelCellInfo();
                        excelCellInfo.RowIndex = (int)r.RowIndex.Value;
                        excelCellInfo.CellReference = c.CellReference;
                        excelCellInfo.ColumnIndex = ExcelAlphabet.ABCToColumn(excelCellInfo.CellReference.Replace(excelCellInfo.RowIndex.ToString(), ""));
                        excelCellInfo.Value = GetCellValue(c, workbookPart, type);

                        excelCellInfos.Add(excelCellInfo);
                    }
                }
            }

            return excelCellInfos;
        }

        /// <summary>
        /// 读取、解析
        /// </summary>
        /// <param name="fileName">文件</param>
        /// <param name="sheetName">工作表（默认第一个）</param>
        /// <param name="type">1 不去空格 2 前后空格 3 所有空格  </param>
        /// <returns></returns>
        public static List<T> Read<T>(string fileName, string sheetName = "", int type = 2) where T : new()
        {
            List<ExcelCellInfo> excelCellInfos = Read(fileName, sheetName, type);

            List<T> t = new List<T>();
            //所有属性
            var properties = new T().GetType().GetProperties();
            //exc中第一行单元格
            var oneRow = excelCellInfos.Where(o => o.RowIndex == 1 && !string.IsNullOrEmpty(o.Value));
            //属性和单元格关系（key:属性，val：单元格）
            var p_OneROw = new Dictionary<System.Reflection.PropertyInfo, ExcelCellInfo>();

            //给【p_OneROw】赋值
            foreach (var property in properties)
            {
                //取属性上的自定义特性
                ExcelColumnAttribute att = null;
                var atts = (IEnumerable<ExcelColumnAttribute>)property.GetCustomAttributes(typeof(ExcelColumnAttribute), false);
                if (atts.Any())
                    att = atts.First();

                if (att != null && att.IsShow)
                {
                    string eName = att.ColumnName;
                    var lie = oneRow.FirstOrDefault(o => o.Value == eName);
                    if (lie != null)
                    {
                        p_OneROw.Add(property, lie);
                    }
                }
                else
                {
                    string eName = property.Name;
                    var lie = oneRow.FirstOrDefault(o => o.Value == eName);
                    if (lie != null)
                    {
                        p_OneROw.Add(property, lie);
                    }
                }
            }

            for (int i = 2; i <= excelCellInfos.Max(o => o.RowIndex); i++)
            {
                var model = new T();
                foreach (var por in p_OneROw)
                {
                    var clee = excelCellInfos.FirstOrDefault(o => o.RowIndex == i && o.ColumnIndex == por.Value.ColumnIndex);
                    if (clee != null)
                    {
                        por.Key.SetValue(model, clee.Value);
                    }
                }
                t.Add(model);
            }

            return t;
        }

        /// <summary>
        /// 读取、解析
        /// </summary>
        /// <param name="stream">文件</param>
        /// <param name="sheetName">工作表（默认第一个）</param>
        /// <param name="type">1 不去空格 2 前后空格 3 所有空格  </param>
        /// <returns></returns>
        public static List<ExcelCellInfo> Read(Stream stream, string sheetName = "", int type = 2)
        {
            List<ExcelCellInfo> excelCellInfos = new List<ExcelCellInfo>();

            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(stream, false))
            {
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                //查找工作薄
                Sheet sheet = ExcelSeek.SeekSheet(workbookPart, sheetName);

                //工作表
                WorksheetPart worksheetPart = (WorksheetPart)spreadsheetDocument.WorkbookPart.GetPartById(sheet.Id);
                //数据行
                var rows = worksheetPart.Worksheet.Descendants<Row>();//获得Excel中得数据行
                foreach (Row r in rows)
                {
                    foreach (Cell c in r.Elements<Cell>())
                    {
                        ExcelCellInfo excelCellInfo = new ExcelCellInfo();
                        excelCellInfo.RowIndex = (int)r.RowIndex.Value;
                        excelCellInfo.CellReference = c.CellReference;
                        excelCellInfo.ColumnIndex = ExcelAlphabet.ABCToColumn(excelCellInfo.CellReference.Replace(excelCellInfo.RowIndex.ToString(), ""));
                        excelCellInfo.Value = GetCellValue(c, workbookPart, type);

                        excelCellInfos.Add(excelCellInfo);
                    }
                }
            }

            return excelCellInfos;
        }

        /// <summary>
        /// 读取、解析
        /// </summary>
        /// <param name="stream">文件</param>
        /// <param name="sheetName">工作表（默认第一个）</param>
        /// <param name="type">1 不去空格 2 前后空格 3 所有空格  </param>
        /// <returns></returns>
        public static List<T> Read<T>(Stream stream, string sheetName = "", int type = 2) where T : new()
        {
            List<ExcelCellInfo> excelCellInfos = Read(stream, sheetName, type);

            List<T> t = new List<T>();
            //所有属性
            var properties = new T().GetType().GetProperties();
            //exc中第一行单元格
            var oneRow = excelCellInfos.Where(o => o.RowIndex == 1 && !string.IsNullOrEmpty(o.Value));
            //属性和单元格关系（key:属性，val：单元格）
            var p_OneROw = new Dictionary<System.Reflection.PropertyInfo, ExcelCellInfo>();

            //给【p_OneROw】赋值
            foreach (var property in properties)
            {
                //取属性上的自定义特性
                ExcelColumnAttribute att = null;
                var atts = (IEnumerable<ExcelColumnAttribute>)property.GetCustomAttributes(typeof(ExcelColumnAttribute), false);
                if (atts.Any())
                    att = atts.First();

                if (att != null && att.IsShow)
                {
                    string eName = att.ColumnName;
                    var lie = oneRow.FirstOrDefault(o => o.Value == eName);
                    if (lie != null)
                    {
                        p_OneROw.Add(property, lie);
                    }
                }
                else
                {
                    string eName = property.Name;
                    var lie = oneRow.FirstOrDefault(o => o.Value == eName);
                    if (lie != null)
                    {
                        p_OneROw.Add(property, lie);
                    }
                }
            }

            for (int i = 2; i <= excelCellInfos.Max(o => o.RowIndex); i++)
            {
                var model = new T();
                foreach (var por in p_OneROw)
                {
                    var clee = excelCellInfos.FirstOrDefault(o => o.RowIndex == i && o.ColumnIndex == por.Value.ColumnIndex);
                    if (clee != null)
                    {
                        por.Key.SetValue(model, clee.Value);
                    }
                }
                t.Add(model);
            }

            return t;
        }

        /// <summary>
        /// 获取单位格的值
        /// </summary>
        /// <param name="cell">单元格</param>
        /// <param name="workbookPart"></param>
        /// <param name="type">1 不去空格 2 前后空格 3 所有空格  </param>
        /// <returns></returns>
        public static string GetCellValue(Cell cell, WorkbookPart workbookPart, int type = 2)
        {
            //合并单元格不做处理
            if (cell.CellValue == null)
                return string.Empty;

            string cellInnerText = cell.CellValue.InnerXml;

            //纯字符串
            if (cell.DataType != null && (cell.DataType.Value == CellValues.SharedString || cell.DataType.Value == CellValues.String || cell.DataType.Value == CellValues.Number))
            {
                //获取spreadsheetDocument中共享的数据
                SharedStringTable stringTable = workbookPart.SharedStringTablePart.SharedStringTable;

                //如果共享字符串表丢失，则说明出了问题。
                if (!stringTable.Any())
                    return string.Empty;

                string text = stringTable.ElementAt(int.Parse(cellInnerText)).InnerText;
                if (type == 2)
                    return text.Trim();
                else if (type == 3)
                    return text.Replace(" ", "");
                else
                    return text;
            }
            //bool类型
            else if (cell.DataType != null && cell.DataType.Value == CellValues.Boolean)
            {
                return (cellInnerText != "0").ToString().ToUpper();
            }
            //数字格式代码（numFmtId）小于164是内置的：https://www.it1352.com/736329.html
            else
            {
                //为空为数值
                if (cell.StyleIndex == null)
                    return cellInnerText;

                Stylesheet styleSheet = workbookPart.WorkbookStylesPart.Stylesheet;
                CellFormat cellFormat = (CellFormat)styleSheet.CellFormats.ChildElements[(int)cell.StyleIndex.Value];

                uint formatId = cellFormat.NumberFormatId.Value;
                double doubleTime;//OLE 自动化日期值
                DateTime dateTime;//yyyy/MM/dd HH:mm:ss
                switch (formatId)
                {
                    case 0://常规
                        return cellInnerText;
                    case 9://百分比【0%】
                    case 10://百分比【0.00%】
                    case 11://科学计数【1.00E+02】
                    case 12://分数【1/2】
                        return cellInnerText;
                    case 14:
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("yyyy/MM/dd");
                    //case 15:
                    //case 16:
                    case 17:
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("yyyy/MM");
                    //case 18:
                    //case 19:
                    case 20:
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("H:mm");
                    case 21:
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("HH:mm:ss");
                    case 22:
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("yyyy/MM/dd HH:mm");
                    //case 45:
                    //case 46:
                    case 47:
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("yyyy/MM/dd");
                    case 58://【中国】11月11日
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("MM/dd");
                    case 176://【中国】2020年11月11日
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("yyyy/MM/dd");
                    case 177://【中国】11:22:00
                        doubleTime = double.Parse(cellInnerText);
                        dateTime = DateTime.FromOADate(doubleTime);
                        return dateTime.ToString("HH:mm:ss");
                    default:
                        return cellInnerText;
                }
            }
        }

    }
}
