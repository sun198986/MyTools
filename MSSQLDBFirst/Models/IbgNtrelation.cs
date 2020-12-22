using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgNtrelation
    {
        public string StkAccCodeNd { get; set; }
        public string StkAccCodeSupl { get; set; }
        public string NtrelaGuid { get; set; }
        public string Nttype { get; set; }
        public string BranCodeMaintain { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
