using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgCompanyTaxPolicy
    {
        public string CompanyCode { get; set; }
        public string ISoulOperationProcessingId { get; set; }
        public int? OrderOfApplication { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
