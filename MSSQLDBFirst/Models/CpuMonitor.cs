using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class CpuMonitor
    {
        public string Spid { get; set; }
        public string Cmd { get; set; }
        public string Cpu { get; set; }
        public string PhysicalIo { get; set; }
        public string Memusage { get; set; }
        public string SqlText { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
