using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgProduct
    {
        public string ProdCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string CateCode { get; set; }
        public string SalesStartDate { get; set; }
        public string KeepPeriodToYm { get; set; }
        public string AvailableFlag { get; set; }
        public string SortKey { get; set; }
        public string ProdCode4Sales { get; set; }
        public string FullName4ProdSales { get; set; }
        public string ShortName4ProdSales { get; set; }
        public string EndOfSalesDate { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
