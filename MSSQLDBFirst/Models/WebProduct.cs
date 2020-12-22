using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class WebProduct
    {
        public string UserId { get; set; }
        public string ProdCode { get; set; }
        public string FullName { get; set; }
        public string CateCode { get; set; }
        public int? SalesStartDate { get; set; }
        public string KeepPeriodToYm { get; set; }
        public int? ProdAvailableFlag { get; set; }
        public int? ProdCode4Sales { get; set; }
        public int? EndOfSalesDate { get; set; }
        public int? RegionCode { get; set; }
        public int? LaborChargeCode { get; set; }
        public int? ProdSalesExAvailableFlag { get; set; }
        public string AvailableFlag { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
