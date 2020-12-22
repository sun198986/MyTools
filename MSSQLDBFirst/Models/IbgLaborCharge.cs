using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgLaborCharge
    {
        public string LaborChargeCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string RegionCode { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
