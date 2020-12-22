using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4Npcsreceive
    {
        public string TaskId { get; set; }
        public string SonoNpcs { get; set; }
        public string ProdCode { get; set; }
        public string PartNo { get; set; }
        public string ShelfCode { get; set; }
        public string Soqty { get; set; }
        public string Price { get; set; }
        public string Amt { get; set; }
        public string Reverse { get; set; }
        public string WoactGuid { get; set; }
    }
}
