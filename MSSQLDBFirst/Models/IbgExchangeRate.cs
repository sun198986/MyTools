using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgExchangeRate
    {
        public string ExchangeType { get; set; }
        public string CurrencyTypeFm { get; set; }
        public string CurrencyTypeTo { get; set; }
        public DateTime AvailFmDate { get; set; }
        public decimal? ExchangeRate { get; set; }
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
