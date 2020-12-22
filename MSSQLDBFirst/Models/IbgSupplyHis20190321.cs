using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgSupplyHis20190321
    {
        public string SuplHisGuid { get; set; }
        public string StkAccCode { get; set; }
        public string PartCode { get; set; }
        public DateTime? ChangeDate { get; set; }
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
