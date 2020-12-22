using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgStaff
    {
        public string StaffCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string BranCode { get; set; }
        public string UserName { get; set; }
        public string AvailableFlag { get; set; }
        public string StaffType { get; set; }
        public string OrgLevel { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public string WorkBranCode { get; set; }
    }
}
