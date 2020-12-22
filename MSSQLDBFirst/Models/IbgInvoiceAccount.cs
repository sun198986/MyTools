using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgInvoiceAccount
    {
        public string SalesRegionCode { get; set; }
        public string InvoiceAccount { get; set; }
        public string Name { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
