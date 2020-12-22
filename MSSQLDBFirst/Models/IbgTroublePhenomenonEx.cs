using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgTroublePhenomenonEx
    {
        public string OrgLevel { get; set; }
        public string OrgCode { get; set; }
        public string PheExGuid { get; set; }
        public string TroublePhenomenonEx { get; set; }
        public string SortKey { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
