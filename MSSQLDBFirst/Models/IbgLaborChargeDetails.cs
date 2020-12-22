using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgLaborChargeDetails
    {
        public string LaborChargeCode { get; set; }
        public string RepairRank { get; set; }
        public DateTime AvailFmDate { get; set; }
        public decimal? LaborChargeLimit { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
