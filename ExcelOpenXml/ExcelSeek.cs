using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelOpenXml
{
    public class ExcelSeek
    {
        /// <summary>
        /// 在工作薄中查找工作表
        /// </summary>
        public static Sheet SeekSheet(WorkbookPart workbookPart, string sheetName = "")
        {
            //获取所有工作薄
            IEnumerable<Sheet> sheets = workbookPart.Workbook.Descendants<Sheet>();
            Sheet sheet = null;

            if (!sheets.Any())
                throw new ArgumentException("空的Excel文档");

            if (string.IsNullOrEmpty(sheetName))
                sheet = sheets.First();
            else
            {
                if (sheets.Count(o => o.Name == sheetName) <= 0)
                    throw new ArgumentException($"没有找到工作薄“{sheetName}”");
                sheet = sheets.First(o => o.Name == sheetName);
            }
            return sheet;
        }

        /// <summary>
        /// 根据工作表获取工作页
        /// </summary>
        /// <param name="sheet">工作表</param>
        /// <returns>工作页</returns>
        public static WorksheetPart GetWorksheetPart(WorkbookPart workbookPart, Sheet sheet)
        {
            return (WorksheetPart)workbookPart.GetPartById(sheet.Id);
        }
    }
}
