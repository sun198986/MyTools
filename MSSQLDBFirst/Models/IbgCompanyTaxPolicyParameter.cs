using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgCompanyTaxPolicyParameter
    {
        public string CompanyCode { get; set; }
        public string ISoulOperationProcessingId { get; set; }
        public string ParameterId { get; set; }
        public string ParameterValue { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
