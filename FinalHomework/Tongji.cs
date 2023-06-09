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
    public partial class Tongji : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public Tongji()
        {
            InitializeComponent();
        }

        private void Tongji_Load(object sender, EventArgs e)
        {
            string query = "select jiadian.Pp,jiadian.Mc,sum(cast(xiaoshoumingxi.Xl as int )) from jiadian join xiaoshoumingxi on  jiadian.Bh  = xiaoshoumingxi.Wpbh group by Wpbh,Pp,Mc";
            // 创建数据库连接对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                // 创建 SQL 命令对象
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 执行查询，返回一个 SqlDataReader 对象
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // 遍历查询结果，将数据显示在窗体上
                        while (reader.Read())
                        {
                            string Pp = reader.GetString(0);
                            string Mc = reader.GetString(1);
                            string Sl = reader.GetInt32(2).ToString();

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(Pp, Mc,Sl,"查看");
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["查看"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string Mc = selectedRow.Cells[1].Value.ToString();

                JuTixiaoshou guTixiaoshou = new JuTixiaoshou(Mc);
                guTixiaoshou.Show();



            }
        }
    }
}
