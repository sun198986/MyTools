using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgPart
    {
        public string PartCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string MainProdCode { get; set; }
        public string DistributeAttitude { get; set; }
        public string RpinfoCode { get; set; }
        public string CirculationFlag { get; set; }
        public string AvailableFlag { get; set; }
        public int? PackingUnit { get; set; }
        public string ComnFlag { get; set; }
        public string FullNameChn { get; set; }
        public string FullNameJpn { get; set; }
        public string ShortNameChn { get; set; }
        public string ShortNameJpn { get; set; }
        public string ToolFlag { get; set; }
        public string DangerousFlag { get; set; }
        public string LicenceType { get; set; }
        public string BeppyoNo { get; set; }
        public string Eccncode { get; set; }
        public string Earflag { get; set; }
        public string ContryOfOrigin { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
