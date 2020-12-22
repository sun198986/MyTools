using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgProdWod
    {
        public string RcptGuid { get; set; }
        public string ProdWoguid { get; set; }
        public string AvailableFlag { get; set; }
        public DateTime? DisableDate { get; set; }
        public string DisableUpdator { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
