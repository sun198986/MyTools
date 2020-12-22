using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgStockHisBak20161026
    {
        public string StkAccCodeSource { get; set; }
        public string StkAccCodeTarget { get; set; }
        public string PartCode { get; set; }
        public string StkHisGuid { get; set; }
        public DateTime? MoveDate { get; set; }
        public int? Qty { get; set; }
        public string OperationId { get; set; }
        public string ReasonGuid { get; set; }
        public string RelaType { get; set; }
        public string RelaGuid { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
