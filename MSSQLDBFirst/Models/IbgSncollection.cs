using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgSncollection
    {
        public string Sntype { get; set; }
        public string RelaGuid { get; set; }
        public string Prefix { get; set; }
        public string Postfix { get; set; }
        public int? DigitNum { get; set; }
        public int? MinVal { get; set; }
        public int? MaxVal { get; set; }
        public int? Cyclic { get; set; }
        public int? NowVal { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
