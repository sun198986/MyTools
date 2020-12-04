using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WordOpenXml
{
    public class  CellInfo
    {
        public CellInfo(string cellName)
        {
            CellName = cellName;

        }

        /// <summary>
        /// 单元格名称 A1
        /// </summary>
        public string CellName { get; set; }

        /// <summary>
        /// 列名称 A~Z
        /// </summary>
        public string CellColumnNanme { get; set; }

        /// <summary>
        /// 单元格列
        /// </summary>
        public int CellColumnIndex { get; set; }

        /// <summary>
        /// 单元格行
        /// </summary>
        public int CellRowIndex { get; set; }

        /// <summary>
        /// 根据单元格名称获取列名
        /// </summary>
        private string GetColumnName(string cellName)
        {
            // Create a regular expression to match the column name portion of the cell name.  
            Regex regex = new Regex("[A-Za-z]+");
            Match match = regex.Match(cellName);
            return match.Value;
        }

        /// <summary>
        /// 根据单元格名称获取行
        /// </summary>
        /// <param name="cellName"></param>
        /// <returns></returns>
        private string GetCellRowIndex(string cellName) {
            return null;
        }

        /// <summary>
        /// 根据单元格名称获取行
        /// </summary>
        /// <param name="cellName"></param>
        /// <returns></returns>
        private string GetCellColumnIndex(string cellName) {
            return null;
        }
    }
}
