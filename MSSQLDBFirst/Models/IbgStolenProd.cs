using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgStolenProd
    {
        public string ProdCode { get; set; }
        public string ProdSn { get; set; }
        public string Comment { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public string BranCode { get; set; }
        public string StaffCode { get; set; }
        public string ApplicantType { get; set; }
        public string ApplicantName { get; set; }
        public string ContactTel { get; set; }
        public string DeleteFlag { get; set; }
        public string DeleteComment { get; set; }
        public string OptNo { get; set; }
    }
}
