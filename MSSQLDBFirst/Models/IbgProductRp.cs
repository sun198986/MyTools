using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgProductRp
    {
        public string ProdSn { get; set; }
        public string ProdCode { get; set; }
        public DateTime? SaleDate { get; set; }
        public string GuaranteeCertificateInfo { get; set; }
        public string ProdSnnew { get; set; }
        public string ProdSnold { get; set; }
        public string GrayProdFlag { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
