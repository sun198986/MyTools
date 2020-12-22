using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgConsignHis
    {
        public string RcptGuid { get; set; }
        public string RcptBran { get; set; }
        public string ServiceBran { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
