using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.DB2.Demo.Entities
{
    [Table("DB2ADMIN.COMPANY")]
    public class Company
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string Industry { get; set; }

        public string Product { get; set; }

        public string Introduction { get; set; }

        public DateTime CreateDate { get; set; }

        public string Creator { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string Updater { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}