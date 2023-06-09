using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHomework
{
    public partial class JuTixiaoshoumingxi : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        string SpMc;
        string GoSiMc;
        public JuTixiaoshoumingxi(string Mc,string _GosiMc)
        {
            InitializeComponent();
            SpMc = Mc;
            GoSiMc = _GosiMc;
        }

        private void JuTixiaoshoumingxi_Load(object sender, EventArgs e)
        {
            string query = "select jiadian.Pp,jiadian.Mc,jiadian.Bh,xiaoshoumingxi.Xl," +
                "xiaoshoumingxi.Dj,xiaoshoumingxi.Xj from jiadian join xiaoshoumingxi " +
                "on jiadian.Bh = xiaoshoumingxi.Wpbh join xiaoshou on xiaoshou.Bh = " +
                "xiaoshoumingxi.Xsbh join maifanggongsi on maifanggongsi.Bh = " +
                "xiaoshou.Gsbh where jiadian.Mc=@SpMc and " +
                "maifanggongsi.Mc = @GoSiMc";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SpMc", SpMc);
                cmd.Parameters.AddWithValue("@GoSiMc", GoSiMc);
                // 执行查询，返回一个 SqlDataReader 对象
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // 遍历查询结果，将数据显示在窗体上
                    while (reader.Read())
                    {
                        string Pp = reader.GetString(0);
                        string Mc = reader.GetString(1);
                        string WpBh = reader.GetString(2);
                        string Xl = reader.GetString(3);
                        string Dj = reader.GetString(4);
                        string Xj = reader.GetString(5);
                        label7.Text = Pp;
                        label8.Text = Mc;
                        label9.Text = WpBh;
                        label10.Text = Xl;
                        label11.Text = Dj;
                        label12.Text = Xj;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
