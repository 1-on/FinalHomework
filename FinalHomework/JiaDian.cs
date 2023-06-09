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
    public partial class JiaDian : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public JiaDian()
        {
            InitializeComponent();
        }

        private void JiaDian_Load(object sender, EventArgs e)
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
                            string bh = reader.GetString(0);
                            string Pp = reader.GetString(1);
                            string Mc = reader.GetString(2);
                            string Xldm = reader.GetString(3);
                            string Xhgg = reader.GetString(4);
                            string Dj = reader.GetString(5);
                            string Kcl = reader.GetString(6);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(bh, Pp,Mc,Xldm,Xhgg,Dj,Kcl, "修改", "删除");
                        }
                    }
                }
            }
        }

        private void 刷新_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
                            string bh = reader.GetString(0);
                            string Pp = reader.GetString(1);
                            string Mc = reader.GetString(2);
                            string Xldm = reader.GetString(3);
                            string Xhgg = reader.GetString(4);
                            string Dj = reader.GetString(5);
                            string Kcl = reader.GetString(6);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(bh, Pp, Mc, Xldm, Xhgg, Dj, Kcl, "修改", "删除");
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
                string Pp = selectedRow.Cells[1].Value.ToString();
                string Mc = selectedRow.Cells[2].Value.ToString();
                string Xldm = selectedRow.Cells[3].Value.ToString();
                string Xhgg = selectedRow.Cells[4].Value.ToString();
                string Dj = selectedRow.Cells[5].Value.ToString();
                string Kcl = selectedRow.Cells[6].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE jiadian SET Pp = @Pp, Mc = @Mc,Xldm=@Xldm,Xhgg=@Xhgg,Dj=@Dj,Kcl=@Kcl WHERE Bh = @Bh";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Pp", Pp);
                    cmd.Parameters.AddWithValue("@Mc", Mc);
                    cmd.Parameters.AddWithValue("@Xldm", Xldm);
                    cmd.Parameters.AddWithValue("@Xhgg", Xhgg);
                    cmd.Parameters.AddWithValue("@Dj", Dj);
                    cmd.Parameters.AddWithValue("@Kcl", Kcl);
                    cmd.Parameters.AddWithValue("@Bh", Bh);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("修改成功");
            }
            
            if (e.ColumnIndex == dataGridView1.Columns["删除"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string ID = selectedRow.Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM jiadian WHERE Bh = @Bh";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Bh", ID);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("删除成功，请刷新");
            }
        }

        private void 新增家电_Click(object sender, EventArgs e)
        {
            Addjiadian addjiadian = new Addjiadian();
            addjiadian.ShowDialog();
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Pp = PpTextBox.Text;
            string Mc = McTextBox.Text;
            string query = "SELECT * FROM  jiadian";
            //没有查询条件
            // 创建数据库连接对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (string.IsNullOrEmpty(Pp) && string.IsNullOrEmpty(Mc))
                {
                    dataGridView1.Rows.Clear();
                    query = "SELECT * FROM jiadian";

                }//只有品牌
                else if (string.IsNullOrEmpty(Mc))
                {
                    query = "SELECT * FROM jiadian where Pp=@Pp";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Pp", Pp);
                }//只有名称
                else if (string.IsNullOrEmpty(Pp))
                {
                    query = "SELECT * FROM jiadian where Mc like @Mc";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Mc", "%"+Mc+"%");
                }//全有
                else
                {
                    query = "SELECT * FROM jiadian where Mc like @Mc and Pp = @Pp";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Mc", "%" + Mc + "%");
                    cmd.Parameters.AddWithValue("@Pp", Pp);
                }
                // 执行查询，返回一个 SqlDataReader 对象
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // 遍历查询结果，将数据显示在窗体上
                    while (reader.Read())
                    {
                        string bh1 = reader.GetString(0);
                        string Pp1 = reader.GetString(1);
                        string Mc1 = reader.GetString(2);
                        string Xldm1 = reader.GetString(3);
                        string Xhgg1 = reader.GetString(4);
                        string Dj1 = reader.GetString(5);
                        string Kcl1 = reader.GetString(6);

                        // 将数据显示在窗体上，例如使用 DataGridView 控件
                        dataGridView1.Rows.Add(bh1, Pp1, Mc1, Xldm1, Xhgg1, Dj1, Kcl1, "修改", "删除");
                    }
                }
            }
        }
    }
}
