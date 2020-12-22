using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgPriceType
    {
        public string PriceType { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string CurrencyType { get; set; }
        public string PriceTypeParent { get; set; }
        public string ExchangeType { get; set; }
        public string BranCodeMaintain { get; set; }
        public string ComnPriceRateCode { get; set; }
        public string Owflag { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
