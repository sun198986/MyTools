using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgBranch
    {
        public string BranCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string ComCode { get; set; }
        public string Address { get; set; }
        public string ZipNo { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string ServiceTime { get; set; }
        public string BranType { get; set; }
        public string SysType { get; set; }
        public string BranCodeSvap { get; set; }
        public string BranCodeNpcs { get; set; }
        public string Pic4payment { get; set; }
        public string Pic4rcpt { get; set; }
        public string AvailableFlag { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
