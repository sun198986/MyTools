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
    public partial class LevelControl : UserControl
    {

        private bool m_IsLoading = false;
        public ExperienceLevel ExperienceLevel { get;set;}
        public LevelControl(ExperienceLevel experienceLevel)
        {
            this.ExperienceLevel = experienceLevel;
            InitializeComponent();
        }

        private void LevelControl_Load(object sender, EventArgs e)
        {
            m_IsLoading = true;
            this.labelA.Text = ExperienceLevel.Name;
            this.numericUpDownA.Value = ExperienceLevel.Level;
            m_IsLoading = false;
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            if (!m_IsLoading)
            {
                NumericUpDown com = (NumericUpDown)sender;
                this.ExperienceLevel.Level = decimal.Parse(com.Value.ToString());
            }
        }
    }
}
