using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgTmpRptServiceStatusAll201506
    {
        public string DateFm { get; set; }
        public string DateTo { get; set; }
        public string ExportDate { get; set; }
        public string BranCode { get; set; }
        public string BranName { get; set; }
        public string ExportUnit { get; set; }
        public int LastServicingTtl { get; set; }
        public int ThisReceiptSelf { get; set; }
        public int ThisReceiptOther { get; set; }
        public int ThisReceiptTtl { get; set; }
        public int WarrantyPeriodNotIn { get; set; }
        public int WarrantyPeriodIn { get; set; }
        public int WarrantyPeriodExtended { get; set; }
        public int WarrantyPeriodBeforeSale { get; set; }
        public int DisRepair { get; set; }
        public int ThisRepairFinishedTtl { get; set; }
        public int ThisSr { get; set; }
        public int ThisTesting { get; set; }
        public int ThisWaitForEstimation { get; set; }
        public int ThisWaitForAnswer { get; set; }
        public int ThisPartsWaiting { get; set; }
        public int ThisRepairing { get; set; }
        public int ThisServicingTtl { get; set; }
        public int LastRemain { get; set; }
        public int ThisReceiptFront { get; set; }
        public int ThisReceiptMail { get; set; }
        public int ThisReceiptCollection { get; set; }
        public int ThisReceiptSelfTtl { get; set; }
        public int ThisReceiptSelfAgent { get; set; }
        public int ThisReceiptSelfOther { get; set; }
        public int ThisReturnTtl { get; set; }
        public int ThisServicingSelf { get; set; }
        public int ThisServicingOther { get; set; }
        public int ThisWaitForPicking { get; set; }
        public int ThisHandlingTtl { get; set; }
    }
}
