using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class WebDataControl
    {
        public string UserId { get; set; }
        public string ServiceMethod { get; set; }
        public int RunStatus { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
