using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWotempD
    {
        public string WotempGuid { get; set; }
        public string PartCode { get; set; }
        public string StkAccCodeNd { get; set; }
        public int? NtqtyOrg { get; set; }
        public int? OutStkQtyPlan { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
