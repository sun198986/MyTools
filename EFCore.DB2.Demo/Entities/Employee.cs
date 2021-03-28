using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.DB2.Demo.Entities
{
    [Table("DB2ADMIN.EMPLOYEE")]
    public class Employee
    {
        [Key]
        public string Id { get; set; }

        public string CompanyId { get; set; }

        public string EmployeeNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreateDate { get; set; }

        public string Creator { get; set; }

        public DateTime UpdateDate { get; set; }

        public string Updater { get; set; }

        public Company Company { get; set; }
    }
}