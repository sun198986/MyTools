using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgReceiptExcOut
    {
        public string RcptExcOutGuid { get; set; }
        public string RcptExcGuid { get; set; }
        public string RcptExcOutNo { get; set; }
        public string OutStkSo { get; set; }
        public string OutStkDo { get; set; }
        public string OutStkSta { get; set; }
        public DateTime? OutStkDate { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
