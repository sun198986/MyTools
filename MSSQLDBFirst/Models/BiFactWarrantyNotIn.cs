using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class BiFactWarrantyNotIn
    {
        public string RcptNo { get; set; }
        public int WarrantyPeriod4NotIn { get; set; }
        public decimal? PartAmountNotIn { get; set; }
        public string CloseDate { get; set; }
    }
}
