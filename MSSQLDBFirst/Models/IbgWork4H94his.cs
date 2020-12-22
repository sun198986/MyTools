using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4H94his
    {
        public decimal Id { get; set; }
        public string CreateDate { get; set; }
        public string Ediserver { get; set; }
        public string BranchCode { get; set; }
        public string BranchType { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Dmbtr { get; set; }
        public decimal? TaxAmount { get; set; }
        public DateTime? Ivdate { get; set; }
        public string ExtractDate { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
