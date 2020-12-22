using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgStockAccountType
    {
        public string AccType { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string AccSuplType { get; set; }
        public string AccNdType { get; set; }
        public string AccStkType { get; set; }
        public string SortKey { get; set; }
        public string FullNameChn { get; set; }
        public string FullNameJpn { get; set; }
        public string ShortNameChn { get; set; }
        public string ShortNameJpn { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
