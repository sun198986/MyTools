using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgNthis
    {
        public string NthisGuid { get; set; }
        public string StkAccCodeNd { get; set; }
        public string StkAccCodeSupl { get; set; }
        public string PartCode { get; set; }
        public int? Qty { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string OperationId { get; set; }
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
