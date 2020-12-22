using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgReceiptExcGespic
    {
        public string Picguid { get; set; }
        public string DlvrCd { get; set; }
        public string DlvrNm { get; set; }
        public string DlvrAddr { get; set; }
        public string DlvrTel { get; set; }
        public string DlvrZip { get; set; }
        public string DlvrPic { get; set; }
        public string DlvrCity { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
