using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgNtmgtDBackup20201112
    {
        public string NtmgtGuid { get; set; }
        public string PartCode { get; set; }
        public int? Qty { get; set; }
        public string ProdCode { get; set; }
        public string PartNo { get; set; }
        public string ShelfCodeStkAccNd { get; set; }
        public string OnetimeFlag { get; set; }
        public DateTime? ExpecteArrivalDate { get; set; }
        public int? OutStkQtyPlan { get; set; }
        public DateTime? NcmanualOrderDate { get; set; }
        public string Comment { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
