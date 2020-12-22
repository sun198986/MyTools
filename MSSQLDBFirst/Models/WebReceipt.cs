using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class WebReceipt
    {
        public string WebRcptGuid { get; set; }
        public string WebRcptNo { get; set; }
        public string WebComCode { get; set; }
        public DateTime? WebSubmitDate { get; set; }
        public string WebProdCode { get; set; }
        public string WebProdSn { get; set; }
        public DateTime? WebSaleDate { get; set; }
        public string WebContactPerson { get; set; }
        public string WebContactMethod { get; set; }
        public string WebContactAddress { get; set; }
        public string WebTroublePhenomenonEx { get; set; }
        public string WebAttachment { get; set; }
        public string WebMyNikonName { get; set; }
        public string WebMyNikonMobile { get; set; }
        public string WebMyNikonEmail { get; set; }
        public string WebNikkorId { get; set; }
        public string WebNikkorName { get; set; }
        public string TranId { get; set; }
        public string RequestId { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
