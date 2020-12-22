using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4NapcIn
    {
        public string CustomerCode { get; set; }
        public string Whcode { get; set; }
        public string ArrivalDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string TransportationType { get; set; }
        public string LoadingPlace { get; set; }
        public string BondFree { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string PartsCode { get; set; }
        public string Quantity { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Danger { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
