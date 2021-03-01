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
    public partial class Form1 : Form
    {
        private IList<ProjectContent> _contentList = null;

        private IList<ExperienceLevel> _levelList = null;

        decimal result = 10;

        public Form1()
        {
            this.InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //等级配置
            _levelList = new List<ExperienceLevel> {
                new ExperienceLevel("等级A",result*6,1),
                new ExperienceLevel("等级B",result*5,2),
                new ExperienceLevel("等级C",result*4,3),
                new ExperienceLevel("等级D",result*3,4),
                new ExperienceLevel("等级E",result*2,5),
                new ExperienceLevel("等级F",result,6),
                new ExperienceLevel("非常规",(decimal)200,7)
            };

            for (int i = 0; i < _levelList.Count; i++)
            {
                LevelControl exPerienceItem1 = new LevelControl(_levelList[i]);
                exPerienceItem1.Location = new Point(10, 20 + i * 50);
                exPerienceItem1.Parent = this.groupBox2;
                this.groupBox1.Controls.Add(exPerienceItem1);
            }
            //项配置
            _contentList = new List<ProjectContent>
            {
                new ProjectContent("尼康赋予特定用户经验值（照片竞赛获胜等）",7,365),
                new ProjectContent("完善自我简介（昵称、照片、生日等）",7,365),
                new ProjectContent("好友关注(最初第一人）",7,365),
                new ProjectContent("查阅学习干货（最初登陆限定）",7,365),
                new ProjectContent("加入圈子（最初一回限定）",7,365),
                new ProjectContent("被关注数增加（被关注到达100人，奖励XX经验值）",7,365),
                new ProjectContent("介绍好友 ",1,1),
                new ProjectContent("参加照片竞赛 ",2,15),
                new ProjectContent("分享到朋友圈 ",3,15),
                new ProjectContent("每日登陆 ",4,1),
                new ProjectContent("发帖（发图）",4,1),
                new ProjectContent("评论",4,1),
                new ProjectContent("10个点赞＝１経験値",5,1),
                new ProjectContent("额外奖励",6,1)
            };


            for (int i = 0; i < _contentList.Count; i++)
            {
                ExPerienceItem exPerienceItem1 = new ExPerienceItem(i + 1, _contentList[i], _levelList);
                exPerienceItem1.Location = new Point(30, 20+i* 65);
                exPerienceItem1.Parent = this.groupBox2;
                this.groupBox2.Controls.Add(exPerienceItem1);
                
            }
            this.groupBox2.Size = new Size(520, _contentList.Count * 75);
        }
    
      
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.needDays.Text)) {
                MessageBox.Show("请填写时间");
                return;
            }

            IList<ExperienceLevel> newLevelList = new List<ExperienceLevel>();
            foreach (var item in this.groupBox1.Controls)
            {
                LevelControl leveli = item as LevelControl;
                newLevelList.Add(leveli.ExperienceLevel);
            }

            //result

            decimal result = 0;

            foreach (var item in this.groupBox2.Controls)
            {
                ExPerienceItem exPerienceItem = item as ExPerienceItem;
                var pro = exPerienceItem.ProjectContent;
                //总天数
                int needDays = int.Parse(this.needDays.Text);
                //一年发生几次
                int freq = needDays / exPerienceItem.ProjectContent.Interval;

                //一年总积分
                var l= newLevelList.Where(p => p.LevelId == pro.LevelId).Select(j => j.Level).FirstOrDefault()*freq;
                result += l;
            }

            double pointEveryDay = double.Parse(result.ToString()) / int.Parse(needDays.Text);
            this.textBox5.Text = pointEveryDay.ToString();

            double n;
            //白银
            int coe1 = int.Parse(this.textBox1.Text);
            //黄金
            int coe2 = int.Parse(this.textBox2.Text);
            //钻石
            int coe3 = int.Parse(this.textBox3.Text);
            //大师
            int coe4 = int.Parse(this.textBox4.Text);
            n = (double)result / (1 + 1 * Math.Pow(2, coe1) + 1 * Math.Pow(2, coe2) + 1 * Math.Pow(2, coe3) + 1 * Math.Pow(2, coe4));

            //青铜
            var list = new List<Result>();
            int needDays1 = int.Parse(Math.Round(n / pointEveryDay, 0).ToString());
            double start1 = 0;
            double end1 = n;
            var result1 = new Result("青铜", start1, end1,needDays1);
            list.Add(result1);

            //白银
            int needDays2 = int.Parse((Math.Round((n * 1 * Math.Pow(2, coe1)-(n+1)) / pointEveryDay, 0).ToString()));
            //系数
            double by = double.Parse(this.textBoxby.Text);
            double start2 = end1+1;
            double end2 = end1+ n * 1 * Math.Pow(2, coe1)*by;
            var result2 = new Result("白银", start2, end2,needDays2);
            list.Add(result2);
            //
            double hj = double.Parse(this.textBoxhj.Text);
            int needDays3 = int.Parse(Math.Round(n * 1 * Math.Pow(2, coe2) / pointEveryDay, 0).ToString());
            double start3 = end2 + 1;
            double end3 = end2 + n * 1 * Math.Pow(2, coe2)*hj;
            var result3 = new Result("黄金", start3,end3, needDays3);
            list.Add(result3);
            //
            double zs = double.Parse(this.textBoxzs.Text);
            double start4 = end3 + 1;
            double end4 = end3 + n * 1 * Math.Pow(2, coe3)*zs;
            int needDays4 = int.Parse(Math.Round(n * 1 * Math.Pow(2, coe3) / pointEveryDay, 0).ToString());
            var result4 = new Result("钻石", start4,end4,needDays4);
            list.Add(result4);
            //
            double ds = double.Parse(this.textBoxds.Text);
            double start5 = end4 + 1;
            double end5 = end4 + n * 1 * Math.Pow(2, coe4)*ds;
            int needDays5 = int.Parse(Math.Round(n * 1 * Math.Pow(2, coe4) / pointEveryDay, 0).ToString());
            var result5 = new Result("大师", start5,end5,needDays5);
            list.Add(result5);



            this.panel1.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ResultControl1 exPerienceItem1 = new ResultControl1(list[i]);
                exPerienceItem1.Location = new Point(10, 20 + i * 65);
                this.panel1.Controls.Add(exPerienceItem1);
            }

            this.textBox8.Text = end5.ToString();
        }


        #region 私有方法
       
        /// <summary>
        /// 计算方法
        /// </summary>
        private void Calculate()
        {
            int needDays = int.Parse(this.needDays.Text.ToString());
            //总经验
            decimal result = 0;
            foreach (var item in _contentList)
            {
                decimal level = _levelList.Where(p => p.LevelId == item.LevelId).FirstOrDefault().Level;
                //尼康赋予特定用户经验值（照片竞赛获胜等）
                if (item.Content.Contains("尼康赋予特定用户经验值（照片竞赛获胜等）")) 
                {
                    result+= level;
                }
                else if (item.Content.Contains("完善自我简介（昵称、照片、生日等）")) {
                    result += level;
                }
                else if (item.Content.Contains("好友关注(最初第一人）")) {
                    result += level;
                }
                else if (item.Content.Contains("查阅学习干货（最初登陆限定）")) {
                    result += level;
                }
                else if (item.Content.Contains("加入圈子（最初一回限定）")) {
                    result += level;
                }
                else if (item.Content.Contains("被关注数增加（被关注到达100人，奖励XX经验值）")) {
                    result += level;
                }
                else if (item.Content.Contains("介绍好友")) {
                    result += level;
                }
                //初定30天一次
                else if (item.Content.Contains("参加照片竞赛")) {
                    int plv = needDays / 30;
                    result += level * plv;
                }
                else if (item.Content.Contains("分享到朋友圈）")) { 
                    
                }
                else if (item.Content.Contains("每日登陆")) { }
                else if (item.Content.Contains("发帖（发图）")) { }
                else if (item.Content.Contains("评论")) { }
                else
                {
                }
            }
        }

        #endregion

    }
}
