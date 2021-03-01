using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCalculate.Model
{
    public class ProjectContent
    {
        public ProjectContent(string content, int levelId,int interval)
        {
            this.Content = content;
            this.LevelId = levelId;
            this.Interval = interval;
        }

        public string Content { get; set; }

        public int LevelId { get; set; }

        public int Interval {get;set;}
    }
}
