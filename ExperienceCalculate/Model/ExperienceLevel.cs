using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCalculate.Model
{
    public class ExperienceLevel
    {
        public ExperienceLevel(string name,decimal level,int levelId)
        {
            this.LevelId = levelId;
            this.Level = level;
            this.Name = name;
        }

        public int LevelId { get; set; }
        public decimal Level { get; set; }

        public string Name { get; set; }

        
    }
}
