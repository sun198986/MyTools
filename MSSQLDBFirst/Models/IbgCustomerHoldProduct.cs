using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgCustomerHoldProduct
    {
        public string CustomerGuid { get; set; }
        public string ProdCode { get; set; }
        public string ProdSn { get; set; }
        public DateTime? DateFm { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? DiscountRate { get; set; }
        public string OddHandlingType { get; set; }
        public int? AvailDigit { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public decimal? WarrantyMonths { get; set; }
        public string AvailableFlag { get; set; }
    }
}
