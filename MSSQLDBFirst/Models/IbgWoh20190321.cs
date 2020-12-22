using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWoh20190321
    {
        public string Woguid { get; set; }
        public string StkAccCodeSource { get; set; }
        public string StkAccCodeTarget { get; set; }
        public string Wotype { get; set; }
        public string WorelaNo { get; set; }
        public string ReasonGuid { get; set; }
        public string Rpcno { get; set; }
        public string PartInfoConfirm { get; set; }
        public string PfmConfirm { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssuePerson { get; set; }
        public string AvailableFlag { get; set; }
        public DateTime? DisableDate { get; set; }
        public string DisableUpdator { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public string Comment { get; set; }
    }
}
