using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWorelation
    {
        public string StkAccCodeSource { get; set; }
        public string StkAccCodeTarget { get; set; }
        public string WorelaGuid { get; set; }
        public string Wotype { get; set; }
        public string BranCodeMaintain { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
