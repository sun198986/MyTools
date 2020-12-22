using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgInvoice
    {
        public string InvoiceGuid { get; set; }
        public string RelationType { get; set; }
        public string RelationGuid { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string SellBranchCode { get; set; }
        public string BuyBranchCode { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public string Paid { get; set; }
        public string PaymentConfirmed { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
