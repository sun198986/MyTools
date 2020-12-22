using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWorelationAction
    {
        public string WorelaGuid { get; set; }
        public string StkAccCodeSource { get; set; }
        public string StkAccCodeTarget { get; set; }
        public string WorelaActGuid { get; set; }
        public string WoactOrder { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
