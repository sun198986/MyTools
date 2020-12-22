using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgInStockComment
    {
        public string WoactGuid { get; set; }
        public string InStkComment { get; set; }
        public string Censor { get; set; }
        public string InStkCommentSta { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
