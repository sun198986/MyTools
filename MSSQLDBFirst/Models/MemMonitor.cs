using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class MemMonitor
    {
        public string Usecounts { get; set; }
        public string Objtype { get; set; }
        public string SizeInBytes { get; set; }
        public string Text { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
