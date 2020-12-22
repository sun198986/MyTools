using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgStockTakingList
    {
        public string StkAccCode { get; set; }
        public string PartCode { get; set; }
        public int? StkQtySys { get; set; }
        public string ReasonGuid { get; set; }
        public int? StkQty { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
