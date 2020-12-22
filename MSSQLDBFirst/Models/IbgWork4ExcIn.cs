using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4ExcIn
    {
        public DateTime? Date { get; set; }
        public string Stid { get; set; }
        public string Whfm { get; set; }
        public string Whto { get; set; }
        public string Pc { get; set; }
        public int? Qty { get; set; }
        public string Addr { get; set; }
        public string Outno { get; set; }
        public string Stf { get; set; }
        public string RequestId { get; set; }
    }
}
