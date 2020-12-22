using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgCategory
    {
        public string CateCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string CateType { get; set; }
        public string SortKey { get; set; }
        public string Ifval { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
