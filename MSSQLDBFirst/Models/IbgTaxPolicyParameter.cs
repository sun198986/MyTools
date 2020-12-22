using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgTaxPolicyParameter
    {
        public string ISoulOperationProcessingId { get; set; }
        public string ParameterId { get; set; }
        public string Description { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
