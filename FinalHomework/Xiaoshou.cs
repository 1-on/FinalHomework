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
    public partial class Xiaoshou : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public Xiaoshou()
        {
            InitializeComponent();
        }

        private void xiaosou_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM xiaoshou";
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
                            string Bh = reader.GetString(0);
                            string Gsbh = reader.GetString(1);
                            string Xssl = reader.GetString(2);
                            string Xsrq = reader.GetString(3);
                            string Xsje = reader.GetString(4);

                            // 将数据显示在窗体上，例如使用 DataGridView 控件
                            dataGridView1.Rows.Add(Bh,Gsbh,Xssl,Xsrq,Xsje);
                        }
                    }
                }
            }
        }
    }
}
