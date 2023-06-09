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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalHomework
{

    public partial class AddPinpaiName : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public AddPinpaiName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Mc = McTextBox.Text;
            if (string.IsNullOrEmpty(Mc))
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM pinpai WHERE  Mc=@Mc;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Mc", Mc);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("名称已存在！");
                }
                else
                {
                    String sql = "SELECT TOP 1 Bh FROM maifanggongsi ORDER BY Bh DESC";
                    command = new SqlCommand(sql, connection);
                    int recordCount = Convert.ToInt32(command.ExecuteScalar()) + 1;

                    command = new SqlCommand("INSERT INTO pinpai (Dm,Mc)VALUES(@Dm,@Mc)", connection);
                    command.Parameters.AddWithValue("@Dm", recordCount);
                    command.Parameters.AddWithValue("@Mc", Mc);
                    command.ExecuteNonQuery();
                    MessageBox.Show("新增成功！请刷新");
                    this.Close();
                    

                }
            }
        }

        private void DmTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void McTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
