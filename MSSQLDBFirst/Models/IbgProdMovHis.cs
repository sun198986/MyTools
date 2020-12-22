using System;
using System.Collections.Generic;

namespace MSSQLDBFirst.Models
{
    public partial class IbgProdMovHis
    {
        public string ProdMovHisGuid { get; set; }
        public string BranCodeSource { get; set; }
        public string BranCodeTarget { get; set; }
        public string ProdWoguid { get; set; }
        public string RcptGuid { get; set; }
        public DateTime? MovDate { get; set; }
        public string OperationId { get; set; }
        public string BranCodeAfterExe { get; set; }
        public string StaAfterExe { get; set; }
        public string OutStkType { get; set; }
        public string RecordId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Updator { get; set; }
        public string RecordVersion { get; set; }
    }
}
