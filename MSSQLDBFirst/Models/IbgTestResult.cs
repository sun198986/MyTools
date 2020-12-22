using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgTestResult
    {
        public string TestResultGuid { get; set; }
        public string RcptGuid { get; set; }
        public string TroublePhenomenonCode { get; set; }
        public string TroubleSpotCode { get; set; }
        public string TroubleReasonCode { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
