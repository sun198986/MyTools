using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgStockAccount
    {
        public string StkAccCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string AccType { get; set; }
        public string BranCodeOwner { get; set; }
        public string BranCodeMgtLast { get; set; }
        public string BranCodeMgt { get; set; }
        public string BranCodeMgtNext { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
