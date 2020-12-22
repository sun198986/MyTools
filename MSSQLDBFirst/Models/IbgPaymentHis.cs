using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgPaymentHis
    {
        public string PaymentGuid { get; set; }
        public string BranCodeFm { get; set; }
        public string BranCodeTo { get; set; }
        public string RcptGuid { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? Amt { get; set; }
        public string Comment { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
