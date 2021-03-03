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
    public partial class ExPerienceItem : UserControl
    {

        private bool m_IsLoading = false;
        public ExPerienceItem(int index, ProjectContent projectContent, IList<ExperienceLevel> levelList)
        {
            InitializeComponent();

            this.ProjectContent = projectContent;
            this.LevelList = levelList;
            this.Index = index;


        }

        public ProjectContent ProjectContent { get; set; }

        public IList<ExperienceLevel> LevelList { get; set; }

        public int Index { get; set; }

        private void ExPerienceItem_Load(object sender, EventArgs e)
        {
            m_IsLoading = true;
            this.content.Text = Index.ToString()+"."+ProjectContent.Content;
            this.textBox1.Text = ProjectContent.Interval.ToString();
            this.comboBox1.DataSource = new BindingSource(LevelList, null);
            this.comboBox1.SelectedItem = comboBox1.Items.Cast<ExperienceLevel>().FirstOrDefault(p => p.LevelId == ProjectContent.LevelId);
            m_IsLoading = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!m_IsLoading)
                this.ProjectContent.Interval = int.Parse(textBox1.Text.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_IsLoading)
            {
                ComboBox com = (ComboBox)sender;
                this.ProjectContent.LevelId = int.Parse(com.SelectedValue.ToString());
            }
        }
    }
}
