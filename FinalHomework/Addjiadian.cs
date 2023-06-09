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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalHomework
{
    public partial class Addjiadian : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public Addjiadian()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string Pp=null;
            if (PpComboBox.SelectedItem != null)
            {
                Pp = PpComboBox.SelectedItem.ToString();
            }
            string Mc = McTextBox.Text;
            string Xldm = XldmTextBox.Text;
            string Xhgg = XhggTextBox.Text;
            string Dj = DjTextBox.Text;
            string Kcl = KclTextBox.Text;
            if (string.IsNullOrEmpty(Pp) || string.IsNullOrEmpty(Mc) || string.IsNullOrEmpty(Xldm) || string.IsNullOrEmpty(Xhgg) || string.IsNullOrEmpty(Dj) || string.IsNullOrEmpty(Kcl))
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String sql = "SELECT TOP 1 Bh FROM jiadian ORDER BY Bh DESC";
                SqlCommand command = new SqlCommand(sql, connection);
                int recordCount = Convert.ToInt32(command.ExecuteScalar()) + 1;


                command = new SqlCommand("INSERT INTO jiadian (Bh,Pp,Mc,Xldm,Xhgg,Dj,Kcl)VALUES(@Bh,@Pp,@Mc,@Xldm,@Xhgg,@Dj,@Kcl)", connection);
                command.Parameters.AddWithValue("@Bh", recordCount);
                command.Parameters.AddWithValue("@Pp", Pp);
                command.Parameters.AddWithValue("@Mc", Mc);
                command.Parameters.AddWithValue("@Xldm", Xldm);
                command.Parameters.AddWithValue("@Xhgg", Xhgg);
                command.Parameters.AddWithValue("@Dj", Dj);
                command.Parameters.AddWithValue("@Kcl", Kcl);

                command.ExecuteNonQuery();
                MessageBox.Show("新增成功！请刷新");
                this.Close();
                


            }
        }

        private void DjTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addjiadian_Load(object sender, EventArgs e)
        {
            string query = "SELECT Mc FROM pinpai";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PpComboBox.Items.Add(reader["Mc"].ToString());
                }

                reader.Close();
            }
        }

        private void PpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
