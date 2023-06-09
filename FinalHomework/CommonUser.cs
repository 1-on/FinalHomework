using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHomework
{
    public partial class CommonUser : Form
    {
        string yonghuming;
        string mima;
        public CommonUser(string _yonghuming, string _mima)
        {
            InitializeComponent();

            yonghuming = _yonghuming;
            mima = _mima;
            timer1.Interval = 1000; // 设置定时器的时间间隔为1秒
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void CommonUser_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void 购买ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goumai goumai = new Goumai();
            goumai.MdiParent = this;
            goumai.WindowState = FormWindowState.Maximized;
            goumai.Show();
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                this.Enabled = false;
                string password = mima;
                string input = Microsoft.VisualBasic.Interaction.InputBox("请输入登录密码：", "密码验证", "", -1,-1);
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
