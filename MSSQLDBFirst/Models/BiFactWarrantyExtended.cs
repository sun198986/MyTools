using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class BiFactWarrantyExtended
    {
        public string RcptNo { get; set; }
        public int WarrantyPeriod4Extended { get; set; }
        public decimal? PartAmountExtended { get; set; }
        public string CloseDate { get; set; }
    }
}
