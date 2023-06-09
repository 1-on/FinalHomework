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
    public partial class RegistratiomForm : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public RegistratiomForm()
        {
            InitializeComponent();
        }

        private void RegistratiomForm_Load(object sender, EventArgs e)
        {

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string userID = UserIDTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            string userName = UserNameTextBox.Text;
            string type = TypeComboBox.Text;
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("密码不能小于六位！");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM yonghu WHERE Yhm = @Yhm;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Yhm", userID);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("用户名存在！");
                }
                else
                {
                    String sql = "SELECT TOP 1 Bh FROM yonghu ORDER BY Bh DESC";
                    command = new SqlCommand(sql, connection);
                    int recordCount = Convert.ToInt32(command.ExecuteScalar()) + 1;


                    command = new SqlCommand("INSERT INTO yonghu (Bh,Yhm,Nc,Mm,Qxjb,Zcrq)VALUES(@Bh,@Yhm,@Nc,@Mm,@Qxjb,@Zcrq)", connection);
                    command.Parameters.AddWithValue("@Bh", recordCount);
                    command.Parameters.AddWithValue("@Yhm", userID);
                    command.Parameters.AddWithValue("@Nc", userName);
                    command.Parameters.AddWithValue("@Mm", password);
                    command.Parameters.AddWithValue("@Qxjb", type);

                    DateTime currentDate = DateTime.Now;
                    command.Parameters.AddWithValue("@Zcrq", currentDate.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("注册成功！");
                    this.Close();
                }

                
            }
        }

        private void UserIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
