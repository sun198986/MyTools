using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelOpenXml
{
    class StudentExcelDto
    {
        /// <summary>
        /// 班级名称
        /// </summary>
        [ExcelColumn("班级名称（必填）")]
        public string ClassName { get; set; }
        /// <summary>
        /// 学员姓名
        /// </summary>
        [ExcelColumn("学员姓名（必填）")]
        public string StudentName { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [ExcelColumn("手机号码")]
        public string Mobile { get; set; }
    }
}
