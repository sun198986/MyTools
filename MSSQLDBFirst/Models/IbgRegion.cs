using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgRegion
    {
        public string RegionCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string CurrencyType { get; set; }
        public string FullNameChn { get; set; }
        public string FullNameJpn { get; set; }
        public string ShortNameChn { get; set; }
        public string ShortNameJpn { get; set; }
        public int? AvailDigit { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public string OddHandlingType { get; set; }
    }
}
