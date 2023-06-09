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
    public partial class Goumai : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public Goumai()
        {
            InitializeComponent();
        }

        private void Goumai_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM jiadian";
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
                            //string bh = reader.GetString(0);
                            string Pp = reader.GetString(1);
                            string Mc = reader.GetString(2);
                            //string Xldm = reader.GetString(3);
                            string Xhgg = reader.GetString(4);
                            string Dj = reader.GetString(5);
                            string Kcl = reader.GetString(6);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(Pp, Mc, Xhgg, Dj, Kcl, "购买");
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["购买"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string Pp = selectedRow.Cells[0].Value.ToString();
                string Mc = selectedRow.Cells[1].Value.ToString();
                string Xhgg = selectedRow.Cells[2].Value.ToString();
                string Dj = selectedRow.Cells[3].Value.ToString();
                string Kcl = selectedRow.Cells[4].Value.ToString();

                if (Convert.ToInt32(Kcl) == 0)
                {
                    MessageBox.Show("库存不足");
                    return;
                }
                
                GoumaiXinxi goumaiXinxi = new GoumaiXinxi(Mc,Dj,Kcl);
                goumaiXinxi.Show();


                //MessageBox.Show("购买成功");
            }
        }
    }
}
