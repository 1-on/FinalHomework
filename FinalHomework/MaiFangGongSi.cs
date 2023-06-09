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
    public partial class MaiFangGongSi : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public MaiFangGongSi()
        {
            InitializeComponent();
        }

        private void MaiFangGongSi_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM maifanggongsi";
            // 创建数据库连接对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                dataGridView1.Columns[0].Width = 60;
                // 创建 SQL 命令对象
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 执行查询，返回一个 SqlDataReader 对象
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // 遍历查询结果，将数据显示在窗体上
                        while (reader.Read())
                        {
                            string bh = reader.GetString(0);
                            string Mc = reader.GetString(1);
                            string Lxr = reader.GetString(2);
                            string Lxdh = reader.GetString(3);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(bh, Mc, Lxr, Lxdh, "修改", "删除");
                        }
                    }
                }
            }
        }

        private void 刷新_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT * FROM maifanggongsi";
            // 创建数据库连接对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                dataGridView1.Columns[0].Width = 60;
                // 创建 SQL 命令对象
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 执行查询，返回一个 SqlDataReader 对象
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // 遍历查询结果，将数据显示在窗体上
                        while (reader.Read())
                        {
                            string bh = reader.GetString(0);
                            string Mc = reader.GetString(1);
                            string Lxr = reader.GetString(2);
                            string Lxdh = reader.GetString(3);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(bh, Mc, Lxr, Lxdh, "修改", "删除");
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["修改"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string Bh = selectedRow.Cells[0].Value.ToString();
                string Mc = selectedRow.Cells[1].Value.ToString();
                string Lxr = selectedRow.Cells[2].Value.ToString();
                string Lxdh = selectedRow.Cells[3].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE maifanggongsi SET Mc = @Mc, Lxr = @Lxr, Lxdh=@Lxdh WHERE Bh = @Bh";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Mc", Mc);
                    cmd.Parameters.AddWithValue("@Lxr", Lxr);
                    cmd.Parameters.AddWithValue("@Lxdh", Lxdh);
                    cmd.Parameters.AddWithValue("@Bh", Bh);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("修改成功");
                }
            
            if (e.ColumnIndex == dataGridView1.Columns["删除"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string Bh = selectedRow.Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM maifanggongsi WHERE Bh = @Bh";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Bh", Bh);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("删除成功，请刷新");
            }
        }

        private void 新增公司_Click(object sender, EventArgs e)
        {
            Addgongsi addgongsi = new Addgongsi();
            addgongsi.ShowDialog();
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Mc = CompanyNameTextBox.Text;
            string Lxr = PeopleNameTextBox.Text;
            string query = "SELECT * FROM  maifanggongsi";
            //没有查询条件
            // 创建数据库连接对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (string.IsNullOrEmpty(Mc) && string.IsNullOrEmpty(Lxr))
                {
                    dataGridView1.Rows.Clear();
                    query = "SELECT * FROM maifanggongsi";

                }//只有联系人
                else if (string.IsNullOrEmpty(Mc))
                {
                    query = "SELECT * FROM maifanggongsi where Lxr=@Lxr";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Lxr", Lxr);
                }//只有公司名称
                else if (string.IsNullOrEmpty(Lxr))
                {
                    query = "SELECT * FROM maifanggongsi where Mc=@Mc";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Mc", Mc);
                }//全有
                else
                {
                    query = "SELECT * FROM maifanggongsi where Mc=@Mc and Lxr = @Lxr";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Mc", Mc);
                    cmd.Parameters.AddWithValue("@Lxr", Lxr);
                }
                // 执行查询，返回一个 SqlDataReader 对象
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // 遍历查询结果，将数据显示在窗体上
                    while (reader.Read())
                    {
                        string Bh1 = reader.GetString(0);
                        string Mc1 = reader.GetString(1);
                        string Lxr1 = reader.GetString(2);
                        string Lxdh1 = reader.GetString(3);

                        // 将数据显示在窗体上，例如使用 DataGridView 控件
                        dataGridView1.Rows.Add(Bh1,Mc1,Lxr1,Lxdh1, "修改", "删除");
                    }
                }
            }
        }
    }
}
