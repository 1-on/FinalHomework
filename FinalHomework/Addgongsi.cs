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
    public partial class Addgongsi : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public Addgongsi()
        {
            InitializeComponent();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string Mc = CompanyNameTextBox.Text;
            string Lxr = PeopleNameTextBox.Text;
            string Lxdh = PhoneTextBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM maifanggongsi WHERE Mc = @Mc;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Mc", Mc);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("公司已存在！");
                }
                else
                {
                    String sql = "SELECT TOP 1 Bh FROM maifanggongsi ORDER BY Bh DESC";
                    command = new SqlCommand(sql, connection);
                    int recordCount = Convert.ToInt32(command.ExecuteScalar()) + 1;


                    command = new SqlCommand("INSERT INTO maifanggongsi (Bh,Mc,Lxr,Lxdh)VALUES(@Bh,@Mc,@Lxr,@Lxdh)", connection);
                    command.Parameters.AddWithValue("@Bh", recordCount);
                    command.Parameters.AddWithValue("@Mc", Mc);
                    command.Parameters.AddWithValue("@Lxr", Lxr);
                    command.Parameters.AddWithValue("@Lxdh", Lxdh);

                    command.ExecuteNonQuery();
                    MessageBox.Show("注册成功！请刷新");
                    this.Close();
                }

            }
        }
    }
}
