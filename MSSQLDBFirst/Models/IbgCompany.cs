using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgCompany
    {
        public string ComCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string ZipNo { get; set; }
        public string TelNo { get; set; }
        public string RegionCode { get; set; }
        public string ComType { get; set; }
        public int? AccTerm { get; set; }
        public DateTime? AccTermStartDate { get; set; }
        public string ComCodeParent { get; set; }
        public decimal? VatinpTax { get; set; }
        public string AvailableFlag { get; set; }
        public string Pic4payment { get; set; }
        public string Pic4rcpt { get; set; }
        public string FaxNo { get; set; }
        public string BankAddress { get; set; }
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
