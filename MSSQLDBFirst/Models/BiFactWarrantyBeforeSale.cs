using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class BiFactWarrantyBeforeSale
    {
        public string RcptNo { get; set; }
        public int WarrantyPeriod4BeforeSale { get; set; }
        public decimal? PartAmountBeforeSale { get; set; }
        public string CloseDate { get; set; }
    }
}
