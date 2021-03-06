﻿using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgWork4ExcOutInSuccessResponse
    {
        public string Stid { get; set; }
        public string Date { get; set; }
        public string Stf { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public string Sapso { get; set; }
        public string Sapdo { get; set; }
    }
}
