using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgConsignIv
    {
        public string RcptGuid { get; set; }
        public string RcptBran { get; set; }
        public string ServiceBran { get; set; }
        public DateTime? RepairDate { get; set; }
        public string WarrantyPeriod { get; set; }
        public string Chargeable { get; set; }
        public decimal? PartCharge { get; set; }
        public decimal? LaborCharge { get; set; }
        public decimal? TestCharge { get; set; }
        public decimal? OtherCharge { get; set; }
        public string OtherChargeReason { get; set; }
        public decimal? DiscountAmt { get; set; }
        public string DiscountReason { get; set; }
        public string DiscountComment { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
