using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgParaPart
    {
        public string ParaGuid { get; set; }
        public string LevelGuid { get; set; }
        public string PartCode { get; set; }
        public string Val { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
