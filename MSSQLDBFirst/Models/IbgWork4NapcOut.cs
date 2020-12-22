using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4NapcOut
    {
        public string TaskId { get; set; }
        public string CustomerCode { get; set; }
        public string Whcode { get; set; }
        public string DeliveryOrderNumber { get; set; }
        public string ConsigneeCode { get; set; }
        public string ConsigneeName { get; set; }
        public string Carrier { get; set; }
        public string TransportationType { get; set; }
        public string ShipOutDate { get; set; }
        public string PartsCode { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Danger { get; set; }
        public string ProductsCode { get; set; }
        public string PartsNumber { get; set; }
        public string Quantity { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
