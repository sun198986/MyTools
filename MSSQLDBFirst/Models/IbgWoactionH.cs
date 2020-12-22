using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWoactionH
    {
        public string WoactGuid { get; set; }
        public string Woguid { get; set; }
        public string WoactGuidnext { get; set; }
        public string StkAccCodeSource { get; set; }
        public string StkAccCodeTarget { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssuePerson { get; set; }
        public DateTime? ExeDate { get; set; }
        public string Executor { get; set; }
        public string WoactSta { get; set; }
        public string StaUpdator { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
