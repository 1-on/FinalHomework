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
    public partial class dalei : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public dalei()
        {
            InitializeComponent();
        }

        private void dalei_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dalei";
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
                            string Dm = reader.GetString(0);
                            string Mc = reader.GetString(1);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(Dm, Mc, "修改", "删除");
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
                string Dm = selectedRow.Cells[0].Value.ToString();
                string Mc = selectedRow.Cells[1].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE dalei SET Mc = @Mc where Dm=@Dm";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Dm", Dm);
                    cmd.Parameters.AddWithValue("@Mc", Mc);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("修改成功");

            }
            if (e.ColumnIndex == dataGridView1.Columns["删除"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string Dm = selectedRow.Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM dalei WHERE Dm = @Dm";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Dm", Dm);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("删除成功，请刷新");
            }
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            AddDaleiName addDaleiName  = new AddDaleiName();
            addDaleiName.ShowDialog();
        }

        private void 刷新_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT * FROM dalei";
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
                            string Dm = reader.GetString(0);
                            string Mc = reader.GetString(1);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(Dm, Mc, "修改", "删除");
                        }
                    }
                }
            }
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Dm = UserIDTextBox.Text;
            string Mc = UserNameTextBox.Text;
            string query = "SELECT * FROM  dalei";
            //没有查询条件
            // 创建数据库连接对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (string.IsNullOrEmpty(Dm) && string.IsNullOrEmpty(Mc))
                {
                    dataGridView1.Rows.Clear();
                    query = "SELECT * FROM dalei";

                }//只有代码
                else if (string.IsNullOrEmpty(Mc))
                {
                    query = "SELECT * FROM dalei where Dm=@Dm";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Dm", Dm);
                }//只有名称条件
                else if (string.IsNullOrEmpty(Dm))
                {
                    query = "SELECT * FROM dalei where Mc=@Mc";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Mc", Mc);
                }//全有
                else
                {
                    query = "SELECT * FROM dalei where Mc=@Mc and Dm = @Dm";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Mc", Mc);
                    cmd.Parameters.AddWithValue("@Dm", Dm);
                }
                // 执行查询，返回一个 SqlDataReader 对象
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // 遍历查询结果，将数据显示在窗体上
                    while (reader.Read())
                    {
                        string Dm1 = reader.GetString(0);
                        string Mc1 = reader.GetString(1);

                        // 将数据显示在窗体上，例如使用 DataGridView 控件
                        dataGridView1.Rows.Add(Dm1, Mc1, "修改", "删除");
                    }
                }
            }
        }
    }
}
