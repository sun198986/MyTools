using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgTroubleRelation
    {
        public string RelationType { get; set; }
        public string CodeLeft { get; set; }
        public string CodeRight { get; set; }
        public string Comment { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
