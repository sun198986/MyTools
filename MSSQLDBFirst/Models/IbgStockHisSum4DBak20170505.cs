using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgStockHisSum4DBak20170505
    {
        public DateTime Ym { get; set; }
        public string StkAccCodeSource { get; set; }
        public string StkAccCodeTarget { get; set; }
        public string PartCode { get; set; }
        public int? Qty { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
