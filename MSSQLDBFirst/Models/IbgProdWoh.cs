using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgProdWoh
    {
        public string ProdWoguid { get; set; }
        public string BranCodeSource { get; set; }
        public string BranCodeTarget { get; set; }
        public string WorelaNo { get; set; }
        public string OutStkType { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssuePerson { get; set; }
        public string AvailableFlag { get; set; }
        public DateTime? DisableDate { get; set; }
        public string DisableUpdator { get; set; }
        public DateTime? OutStkExeDate { get; set; }
        public string OutStkExecutor { get; set; }
        public DateTime? InStkExeDate { get; set; }
        public string InStkExecutor { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
