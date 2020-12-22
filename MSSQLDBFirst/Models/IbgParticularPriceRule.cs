using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgParticularPriceRule
    {
        public string TradeGuid { get; set; }
        public string PartCode { get; set; }
        public DateTime AvailFmDate { get; set; }
        public string SpecialPriceType { get; set; }
        public decimal? PriceRate { get; set; }
        public string OddHandlingType { get; set; }
        public int? AvailDigit { get; set; }
        public decimal? PriceFixed { get; set; }
        public string ExistFlag { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
