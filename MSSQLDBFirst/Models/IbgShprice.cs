using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgShprice
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
        public string BranTarget { get; set; }
        public string BranTargetName { get; set; }
        public decimal? Price { get; set; }
        public string AccTypeS { get; set; }
        public string AccTypeT { get; set; }
        public string CurrencyType { get; set; }
    }
}
