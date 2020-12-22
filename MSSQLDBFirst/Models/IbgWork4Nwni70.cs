using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4Nwni70
    {
        public string OrderReceivedCompanyCode { get; set; }
        public string OrderReceivedCompany { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string SalesOrderNumber { get; set; }
        public string CumtomerOrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string ProductCode { get; set; }
        public string PartsNumber { get; set; }
        public string PartsCode { get; set; }
        public int? OrderQty { get; set; }
        public int? BackOrderQty { get; set; }
        public string CorrectionCode { get; set; }
        public string ExtensionColumn1 { get; set; }
        public string ExtensionColumn2 { get; set; }
        public string ExtensionColumn3 { get; set; }
        public string DataReferenceDate { get; set; }
        public string DataSendingKyotenCode { get; set; }
    }
}
