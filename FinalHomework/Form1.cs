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
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string userID = UserIDTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入账号和密码！");
                return;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("密码不能小于六位！");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM yonghu WHERE Yhm=@Yhm AND Mm=@Password", connection);

                command.Parameters.AddWithValue("@Yhm", userID);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    SqlCommand command2 = new SqlCommand("SELECT Qxjb FROM yonghu where Yhm = @yhm", connection);
                    command2.Parameters.AddWithValue("@Yhm", userID);
                    string type = (string)command2.ExecuteScalar();
                    if(type == "管理员")
                    {
                        ManageMent management = new ManageMent(userID,password);
                        management.Show();
                        this.Hide();

                    }
                    else if(type == "普通用户")
                    {
                        CommonUser commonUser = new CommonUser(userID,password);
                        commonUser.Show();
                        this.Hide();
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("账号或密码错误！!");
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistratiomForm form = new RegistratiomForm();
            form.Show();
        }
    }
}
