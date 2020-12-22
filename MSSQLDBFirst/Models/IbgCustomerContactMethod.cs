﻿using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgCustomerContactMethod
    {
        public string ContactMethodGuid { get; set; }
        public string CustomerGuid { get; set; }
        public string ContactMethodType { get; set; }
        public string ContactMethod { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
