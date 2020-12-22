using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgRefundLaborCharge
    {
        public string OrgLevel { get; set; }
        public string OrgCode { get; set; }
        public string ProdCode { get; set; }
        public decimal? RefundLaborCharge { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
