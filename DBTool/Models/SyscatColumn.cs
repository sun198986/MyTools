using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTool.Models
{
    public class SyscatColumn
    {
        public string TabSchema { get; set; }

        public string TabName { get; set; }

        public string ColName { get; set; }

        public string TypeName { get; set; }

        public int Length { get; set; }

    }
}
