using ExperienceCalculate.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperienceCalculate
{
    public partial class ResultControl1 : UserControl
    {
        public ResultControl1(Result result)
        {
            this.Result = result;
            InitializeComponent();
        }

        public Result Result { get; set; }

        private void ResultControl1_Load(object sender, EventArgs e)
        {
            this.label1.Text = Result.Name;
            this.label2.Text = Math.Round(Result.StartPoint,0).ToString();
            this.label3.Text = Math.Round(Result.EndPoint,0).ToString();
            this.needDays.Text=string.Format("需要大概{0}天完成", (Result.NeedDays+1).ToString()); 
        }
    }
}
