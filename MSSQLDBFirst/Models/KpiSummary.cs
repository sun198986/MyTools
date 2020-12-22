using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class KpiSummary
    {
        public string DataUpdateTime { get; set; }
        public string BranCode { get; set; }
        public int Year4 { get; set; }
        public short Month2 { get; set; }
        public string ExportUnit { get; set; }
        public int? Charge { get; set; }
        public int? WarrantyPeriodIn { get; set; }
        public int? WarrantyPeriodExtended { get; set; }
        public int? WarrantyPeriodNotIn { get; set; }
        public int? WarrantyPeriodBeforeSale { get; set; }
        public int? ThisSr { get; set; }
        public int? DisRepair { get; set; }
        public int? FinishedTtl { get; set; }
        public int? QuickServiceRequest { get; set; }
        public int? QuickServiceFinishedYes { get; set; }
        public int? DeliveryTime2 { get; set; }
        public int? DeliveryTime5 { get; set; }
        public int? DeliveryTime10 { get; set; }
        public int? DeliveryTime20 { get; set; }
        public int? DeliveryTimeOver20 { get; set; }
        public int? DeliveryTimeTtl { get; set; }
        public int? ReRepair1 { get; set; }
        public int? ReRepair2 { get; set; }
        public int? ThisEstimation { get; set; }
        public int? ThisPartsWaiting { get; set; }
        public int? ThisRepairing { get; set; }
        public int? ThisServicingTtl { get; set; }
        public int? ThisReturnTtl { get; set; }
        public int? ThisHandlingTtl { get; set; }
    }
}
