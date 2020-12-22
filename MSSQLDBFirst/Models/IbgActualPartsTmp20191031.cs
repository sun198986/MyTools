using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgActualPartsTmp20191031
    {
        public string RcptGuid { get; set; }
        public string PartCode { get; set; }
        public int? OutOfMgtQty { get; set; }
        public int? FreeQty { get; set; }
        public int? NdQty4Rp { get; set; }
        public int? Ntqty4Rp2wh { get; set; }
        public int? Wo4wh2rp { get; set; }
        public int? StkQty4Rp { get; set; }
        public int? StkQty4Fn { get; set; }
        public int? Wo4rp2wh { get; set; }
        public int? Wo4rp2damage { get; set; }
        public int? DamageQty { get; set; }
        public int? Wo4rp2lost { get; set; }
        public int? LostQty { get; set; }
        public int? SaleQty { get; set; }
        public string DisplayOutPut { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public short? SortKey { get; set; }
        public string Reason4OutOfMgt { get; set; }
        public string Reason4Free { get; set; }
    }
}
