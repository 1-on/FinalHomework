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
    public partial class AddDaleiName : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public AddDaleiName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Dm = DmTextBox.Text;
            string Mc = McTextBox.Text;
            if (string.IsNullOrEmpty(Dm) || string.IsNullOrEmpty(Mc))
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM dalei WHERE Dm = @Dm or Mc=@Mc;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Dm", Dm);
                command.Parameters.AddWithValue("@Mc", Mc);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("代码或名称已存在！");
                }
                else
                {

                    command = new SqlCommand("INSERT INTO dalei (Dm,Mc)VALUES(@Dm,@Mc)", connection);
                    command.Parameters.AddWithValue("@Dm", Dm);
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
