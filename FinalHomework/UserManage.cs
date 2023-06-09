using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalHomework
{
    public partial class UserManage : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public UserManage()
        {
            InitializeComponent();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


        private void Management_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM yonghu";
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
                            string yhm = reader.GetString(1);
                            string nc = reader.GetString(2);
                            string mm = reader.GetString(3);
                            string qxjb = reader.GetString(4);
                            string zcrq = reader.GetString(5);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(bh, yhm, nc, mm, qxjb, zcrq,"修改","删除");
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Application.Exit();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["修改"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string ID = selectedRow.Cells[0].Value.ToString();
                string name = selectedRow.Cells[2].Value.ToString();
                string password = selectedRow.Cells[3].Value.ToString();

                if (password.Length < 6)
                {
                    MessageBox.Show("密码不能小于六位！");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "UPDATE yonghu SET Nc = @Nc, Mm = @Mm WHERE Bh = @Bh";
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.AddWithValue("@Nc", name);
                        cmd.Parameters.AddWithValue("@Mm", password);
                        cmd.Parameters.AddWithValue("@Bh", ID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("修改成功");
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["删除"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string ID = selectedRow.Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM yonghu WHERE Bh = @Bh";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Bh", ID);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("删除成功，请刷新");
            }
        }

        private void 新增用户_Click(object sender, EventArgs e)
        {
            RegistratiomForm form = new RegistratiomForm();
            form.ShowDialog();  
        }

        private void 刷新_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT * FROM yonghu";
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
                            string yhm = reader.GetString(1);
                            string nc = reader.GetString(2);
                            string mm = reader.GetString(3);
                            string qxjb = reader.GetString(4);
                            string zcrq = reader.GetString(5);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(bh, yhm, nc, mm, qxjb, zcrq, "修改", "删除");
                        }
                    }
                }
            }
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string userID = UserIDTextBox.Text;
            string userName = UserNameTextBox.Text;
            string type = TypeTextBox.Text;
            string query = "SELECT * FROM yonghu";
            //没有查询条件
            // 创建数据库连接对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                dataGridView1.Columns[0].Width = 60;
                SqlCommand cmd = new SqlCommand(query, connection);
                if (string.IsNullOrEmpty(userID) && string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(type))
                {
                    dataGridView1.Rows.Clear();
                    query = "SELECT * FROM yonghu";

                }//只有用户名条件
                else if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(type))
                {
                    query = "SELECT * FROM yonghu where Yhm=@yhm";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Yhm", userID);
                }//只有昵称条件
                else if (string.IsNullOrEmpty(userID) && string.IsNullOrEmpty(type))
                {
                    query = "SELECT * FROM yonghu where Nc=@Nc";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nc", userName);
                }//只有权限条件
                else if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(userID))
                {
                    query = "SELECT * FROM yonghu where Qxjb=@Qxjb";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Qxjb", type);
                }//有用户名和昵称
                else if (string.IsNullOrEmpty(type))
                {
                    query = "SELECT * FROM yonghu where Yhm=@yhm and Nc=@Nc";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Yhm", userID);
                    cmd.Parameters.AddWithValue("@Nc", userName);
                }//有用户名和权限
                else if (string.IsNullOrEmpty(userName))
                {
                    query = "SELECT * FROM yonghu where Yhm=@yhm and Qxjb=@Qxjb";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Yhm", userID);
                    cmd.Parameters.AddWithValue("@Qxjb", type);
                }//有昵称和权限
                else if (string.IsNullOrEmpty(userID))
                {
                    query = "SELECT * FROM yonghu where Nc@Nc and Qxjb=@Qxjb";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nc", userName);
                    cmd.Parameters.AddWithValue("@Qxjb", type);
                }//全有
                else
                {
                    query = "SELECT * FROM yonghu where Yhm=@yhm and Nc=@Nc and Qxjb=@Qxjb";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Yhm", userID);
                    cmd.Parameters.AddWithValue("@Nc", userName);
                    cmd.Parameters.AddWithValue("@Qxjb", type);
                }
                // 执行查询，返回一个 SqlDataReader 对象
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // 遍历查询结果，将数据显示在窗体上
                    while (reader.Read())
                    {
                        string bh = reader.GetString(0);
                        string yhm = reader.GetString(1);
                        string nc = reader.GetString(2);
                        string mm = reader.GetString(3);
                        string qxjb = reader.GetString(4);
                        string zcrq = reader.GetString(5);

                        // 将数据显示在窗体上，例如使用 DataGridView 控件
                        dataGridView1.Rows.Add(bh, yhm, nc, mm, qxjb, zcrq, "修改", "删除");
                    }
                }
            }
            
        }
    }
}
