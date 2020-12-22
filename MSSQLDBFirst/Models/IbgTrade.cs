using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgTrade
    {
        public string ComCodeSale { get; set; }
        public string ComCodeBuy { get; set; }
        public string AvailFmDate { get; set; }
        public string TradeGuid { get; set; }
        public string PriceType { get; set; }
        public decimal? PriceRate { get; set; }
        public string OddHandlingType { get; set; }
        public int? AvailDigit { get; set; }
        public string ExistFlag { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
