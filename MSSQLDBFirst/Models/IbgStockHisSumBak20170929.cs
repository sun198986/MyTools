using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgStockHisSumBak20170929
    {
        public DateTime Ym { get; set; }
        public string StkAccCode { get; set; }
        public string PartCode { get; set; }
        public int? InStkQty { get; set; }
        public int? OutStkQty { get; set; }
        public int? StkQtyMend { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
