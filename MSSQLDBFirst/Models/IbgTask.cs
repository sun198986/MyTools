using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgTask
    {
        public string TaskCode { get; set; }
        public string TaskCodeParent { get; set; }
        public string SortKey { get; set; }
        public string ProgramId { get; set; }
        public string Title { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
