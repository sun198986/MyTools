using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCalculate.Model
{
    public class UserRate
    {
        public UserRate(string name,decimal rate)
        {
            this.Name = name;
            this.Rate = rate;
        }

        public string Name { get; set; }

        public decimal Rate { get; set; }
    }
}
