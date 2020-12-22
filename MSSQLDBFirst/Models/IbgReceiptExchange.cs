using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgReceiptExchange
    {
        public string RcptExcGuid { get; set; }
        public string RcptGuid { get; set; }
        public string ProductCd { get; set; }
        public string ProductNm { get; set; }
        public string KitFlag { get; set; }
        public string KitPrimaryFlag { get; set; }
        public string ComponentSn1 { get; set; }
        public string ComponentSn2 { get; set; }
        public string ExcProductCd { get; set; }
        public string ExcProductNm { get; set; }
        public string SischkSn { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public string KitRepairFlagMajorRcptNo { get; set; }
        public string CustomerSearchCode { get; set; }
        public string ContactPerson { get; set; }
        public string ContactAddress { get; set; }
        public string ContactZip { get; set; }
    }
}
