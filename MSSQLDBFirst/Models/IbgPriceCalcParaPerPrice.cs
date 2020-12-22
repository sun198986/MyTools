using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgPriceCalcParaPerPrice
    {
        public string PriceType { get; set; }
        public decimal PriceFm { get; set; }
        public decimal? PriceRate4Part { get; set; }
        public decimal? PriceRate4Tool { get; set; }
        public string OddHandlingType { get; set; }
        public int? AvailDigit { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
