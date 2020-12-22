using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgNtmgtH20190321
    {
        public string StkAccCodeNd { get; set; }
        public string StkAccCodeSupl { get; set; }
        public string NtrelaNo { get; set; }
        public string NtmgtGuid { get; set; }
        public string OrderType { get; set; }
        public string MainProdCode { get; set; }
        public string SonoNpcs { get; set; }
        public string AvailableFlag { get; set; }
        public string OrderSta { get; set; }
        public DateTime? DisableDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExeDate { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
