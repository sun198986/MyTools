using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgEstimationParts
    {
        public string RcptGuid { get; set; }
        public string PartCode { get; set; }
        public int? InMgt { get; set; }
        public int? OutOfMgt { get; set; }
        public int? Charge { get; set; }
        public int? Free { get; set; }
        public string DisplayOutPut { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public short? SortKey { get; set; }
    }
}
