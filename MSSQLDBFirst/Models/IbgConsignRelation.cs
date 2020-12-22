using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgConsignRelation
    {
        public string ConsignerBran { get; set; }
        public string ConsigneeBran { get; set; }
        public string AvailableFlag { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
        public string RelationType { get; set; }
    }
}
