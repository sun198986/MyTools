using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgCustomer
    {
        public string CustomerGuid { get; set; }
        public string OrgLevel { get; set; }
        public string OrgCode { get; set; }
        public string CustomerType { get; set; }
        public string CustomerSearchCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Sex { get; set; }
        public string AvailableFlag { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public string DeptDiv { get; set; }
        public string Bizdiv { get; set; }
        public string Npsno { get; set; }
        public DateTime? DateFm { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
