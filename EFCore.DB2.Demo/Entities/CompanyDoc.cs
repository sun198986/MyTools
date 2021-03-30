using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.DB2.Demo.Entities
{
    [Table("DB2ADMIN.CompanyDoc")]
    public partial class CompanyDoc
    {
        [Key]
        public string Id { get; set; }

        public string CompanyId { get; set; }

        public string Content { get; set; }

        public string Document { get; set; }

        public Company Company { get; set; }
    }
}
