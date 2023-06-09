using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace FinalHomework
{
    public partial class ManageMent : Form
    {
        string yonghuming;
        string mima;
        public ManageMent(string _yonghuming,string _mima)
        {
            InitializeComponent();
            yonghuming = _yonghuming;
            mima = _mima;

            timer1.Interval = 1000; // 设置定时器的时间间隔为1秒
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        

        private void ManageMent_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserManage userManage = new UserManage();
            userManage.MdiParent = this;
            userManage.WindowState = FormWindowState.Maximized;
            userManage.Show();
        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 品牌表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinPaiManage pinPaiManage = new PinPaiManage();
            pinPaiManage.MdiParent = this;
            pinPaiManage.WindowState = FormWindowState.Maximized;
            pinPaiManage.Show();
        }

        private void 家电表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JiaDian jiaDian = new JiaDian();
            jiaDian.MdiParent = this;
            jiaDian.WindowState = FormWindowState.Maximized;
            jiaDian.Show();
        }

        private void 大类表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dalei dalei = new dalei();
            dalei.MdiParent = this;
            dalei.WindowState = FormWindowState.Maximized;
            dalei.Show();
        }

        private void 小类表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiaolei xiaolei = new xiaolei();
            xiaolei.MdiParent = this;
            xiaolei.WindowState= FormWindowState.Maximized;
            xiaolei.Show();
        }

        private void 买方表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaiFangGongSi maiFangGongSi = new MaiFangGongSi();
            maiFangGongSi.MdiParent = this;
            maiFangGongSi.WindowState = FormWindowState.Maximized;
            maiFangGongSi.Show();
        }

        private void 销售表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xiaoshou xiaosou = new Xiaoshou();
            xiaosou.MdiParent = this;
            xiaosou.WindowState = FormWindowState.Maximized; 
            xiaosou.Show();
        }

        private void 销售明细表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xiaoshoumingxi xiaoshoumingxi  = new Xiaoshoumingxi();
            xiaoshoumingxi.MdiParent= this;
            xiaoshoumingxi.WindowState = FormWindowState.Maximized;
            xiaoshoumingxi.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tongji tongji = new Tongji();
            tongji.MdiParent = this;
            tongji.WindowState = FormWindowState.Maximized;
            tongji.Show();
        }

        private void KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                this.Enabled = false;
                string password = mima;
                string input = Microsoft.VisualBasic.Interaction.InputBox("请输入登录密码：", "密码验证", "", -1, -1);
                if (input != "")
                {
                    if (input == password)
                    {
                        this.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("密码错误!");
                    }
                }

            }
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            string password = mima;
            string input = Microsoft.VisualBasic.Interaction.InputBox("请输入登录密码：", "密码验证", "", -1, -1);
            if (input != "")
            {
                if (input == password)
                {
                    this.Enabled = true;
                }
                else
                {
                    MessageBox.Show("密码错误!");
                }
            }
        }
    }
}
