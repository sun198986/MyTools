using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgSmstask
    {
        public string TaskId { get; set; }
        public string Smsno { get; set; }
        public string RcptGuid { get; set; }
        public string RcptNo { get; set; }
        public string TextId { get; set; }
        public string TextContent { get; set; }
        public string SequenceId { get; set; }
        public string MessageId { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
