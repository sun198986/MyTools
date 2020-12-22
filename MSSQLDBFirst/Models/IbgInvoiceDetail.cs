using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgInvoiceDetail
    {
        public string InvoiceDetailGuid { get; set; }
        public string InvoiceGuid { get; set; }
        public string InvoiceAccount { get; set; }
        public string InvoiceSubAccount { get; set; }
        public string InvoiceSubAccountName { get; set; }
        public string InvoiceCurrency { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public string DevisionOfTax { get; set; }
        public string Comment { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
