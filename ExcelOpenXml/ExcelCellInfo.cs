using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelOpenXml
{
    public class ExcelCellInfo
    {
        public int RowIndex { get; set; }


        public string CellReference { get; set; }

        public int ColumnIndex { get; set; }


        public string Value { get; set; }

    }
}
