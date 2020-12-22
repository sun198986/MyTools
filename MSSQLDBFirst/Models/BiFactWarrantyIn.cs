using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class BiFactWarrantyIn
    {
        public string RcptNo { get; set; }
        public int WarrantyPeriod4In { get; set; }
        public decimal? PartAmountIn { get; set; }
        public string CloseDate { get; set; }
    }
}
