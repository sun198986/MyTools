using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgReceiptExcIn
    {
        public string RcptExcInGuid { get; set; }
        public string RcptExcGuid { get; set; }
        public string RcptExcInNo { get; set; }
        public string InStkSo { get; set; }
        public string InStkDo { get; set; }
        public string InStkSta { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
