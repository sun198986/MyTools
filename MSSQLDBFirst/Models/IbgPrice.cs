using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgPrice
    {
        public string PriceType { get; set; }
        public string PartCode { get; set; }
        public DateTime AvailFmDate { get; set; }
        public decimal? Price { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
