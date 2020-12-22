using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgErrorList
    {
        public string ProgramNm { get; set; }
        public string RequestId { get; set; }
        public string ProcedureNm { get; set; }
        public string Error { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
