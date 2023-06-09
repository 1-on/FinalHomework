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
    public partial class JuTixiaoshou : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        string Mc;
        public JuTixiaoshou(string _Mc)
        {
            InitializeComponent();
            Mc = _Mc;
        }

        private void GuTixiaoshou_Load(object sender, EventArgs e)
        {
            string query = "select maifanggongsi.Mc,xiaoshou.Xssl,xiaoshou.Xsrq,xiaoshou.Xsje " +
                            "from xiaoshoumingxi join jiadian on jiadian.Bh = xiaoshoumingxi.Wpbh " +
                            "join xiaoshou on xiaoshou.Bh = xiaoshoumingxi.Xsbh join maifanggongsi " +
                            " on maifanggongsi.Bh = xiaoshou.Gsbh " +
                            "where jiadian.Mc = @Mc";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Mc", Mc);
                // 执行查询，返回一个 SqlDataReader 对象
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // 遍历查询结果，将数据显示在窗体上
                    while (reader.Read())
                    {
                        string Mc = reader.GetString(0);
                        string Xssl = reader.GetString(1);
                        string Xsrq = reader.GetString(2);
                        string Xsje = reader.GetString(3);

                        // 将数据显示在窗体上，例如使用 DataGridView 控件
                        dataGridView1.Rows.Add(Mc, Xssl, Xsrq,Xsje, "查看明细");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["查看明细"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string GoSiMc = selectedRow.Cells[0].Value.ToString();

                JuTixiaoshoumingxi juTixiaoshoumingxi = new JuTixiaoshoumingxi(Mc,GoSiMc);
                juTixiaoshoumingxi.Show();



            }
        }
    }
}
