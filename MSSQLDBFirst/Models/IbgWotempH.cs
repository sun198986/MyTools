using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWotempH
    {
        public string WotempGuid { get; set; }
        public string PartCode { get; set; }
        public string StkAccCodeSupl { get; set; }
        public string OutStkFlag { get; set; }
        public string DistributeSta { get; set; }
        public string OperateSta { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
