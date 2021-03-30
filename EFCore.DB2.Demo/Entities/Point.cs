using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.DB2.Demo.Entities
{
    [Table("DB2ADMIN.Point")]
    public class Point
    {
        [Key]
        public string Id { get; set; }

        public string EmployeeId { get; set; }

        public decimal HeightPoint { get; set; }

        public decimal LowPoint { get; set; }

        public Employee Employee { get; set; }
    }
}
