using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4NapcStockhis
    {
        public string PartCode { get; set; }
        public string Qty { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public DateTime? CreateDate { get; set; }
        public string RecordId { get; set; }
    }
}
