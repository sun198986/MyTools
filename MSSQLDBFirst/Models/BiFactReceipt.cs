using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class BiFactReceipt
    {
        public string RcptNo { get; set; }
        public string ServiceType { get; set; }
        public string RepairDate { get; set; }
        public string CloseDate { get; set; }
        public string ServiceBranCode { get; set; }
        public string ServiceBranName { get; set; }
        public string CateCode { get; set; }
        public string ProdCode { get; set; }
        public string ProdName { get; set; }
        public string PartNameList { get; set; }
        public string PartList { get; set; }
    }
}
