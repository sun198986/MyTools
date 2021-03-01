using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCalculate.Model
{
    public class Result
    {
        public Result(string name,double startPoint,double endPoint,int needDays)
        {
            this.Name = name;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.NeedDays = needDays;
        }

        public string Name{ get; set; }

        public double StartPoint { get; set; }

        public double EndPoint { get; set; }

        public int NeedDays { get; set; }
    }
}
