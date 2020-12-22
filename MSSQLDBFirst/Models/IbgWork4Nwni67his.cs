using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4Nwni67his
    {
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string ProductCode { get; set; }
        public string PartsNumber { get; set; }
        public string PartsCode { get; set; }
        public int? TotalQty { get; set; }
        public int? AvailableQty { get; set; }
        public int? AlocatedQty { get; set; }
        public int? UnavailableQty { get; set; }
        public int? IntransitQtyFromNc { get; set; }
        public int? OrderRemainingQtyToNc { get; set; }
        public int? WaitingBackOrderedQty { get; set; }
        public string ExtensionColumn1 { get; set; }
        public string ExtensionColumn2 { get; set; }
        public string ExtensionColumn3 { get; set; }
        public string DataReferenceDate { get; set; }
        public string DataSendingKyotenCode { get; set; }
        public string CreateDate { get; set; }
        public string RecordId { get; set; }
    }
}
