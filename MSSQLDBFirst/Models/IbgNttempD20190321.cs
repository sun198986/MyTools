﻿using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgNttempD20190321
    {
        public string NttempGuid { get; set; }
        public string PartCode { get; set; }
        public int? Qty { get; set; }
        public int? SuplQtyOrg { get; set; }
        public string Comment { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public short? SortKey { get; set; }
    }
}
