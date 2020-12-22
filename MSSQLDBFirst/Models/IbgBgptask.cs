using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgBgptask
    {
        public string BgptaskGuid { get; set; }
        public string BgptaskName { get; set; }
        public string BgptaskSta { get; set; }
        public string Command { get; set; }
        public string Para { get; set; }
        public string Comment { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
