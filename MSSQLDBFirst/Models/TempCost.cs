using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class TempCost
    {
        public string PartCode { get; set; }
        public decimal? Cost { get; set; }
    }
}
