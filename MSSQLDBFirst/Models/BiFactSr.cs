using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class BiFactSr
    {
        public string RcptNo { get; set; }
        public int Srqty { get; set; }
        public decimal? PartAmountSr { get; set; }
        public string CloseDate { get; set; }
    }
}
