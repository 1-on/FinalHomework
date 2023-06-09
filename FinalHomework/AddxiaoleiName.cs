using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalHomework
{
    public partial class AddxiaoleiName : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        public AddxiaoleiName()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {    
            //获取大类名称
            string Dalei = null;
            if (DaleiComboBox.SelectedItem != null)
            {
                Dalei = DaleiComboBox.SelectedItem.ToString();
            }
            //获取大类代码
            string dldm=null;
            string sql = "SELECT Dm FROM dalei WHERE Mc = @Mc";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Mc", Dalei);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    dldm = reader.GetString(0);
                }
            }
            // 设置小类编号
            sql = "SELECT COUNT(*) FROM xiaolei WHERE Dm like @Dm";
            int count;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Dm", dldm[0]+"%");
                connection.Open();
                count = (int)command.ExecuteScalar();
            }
            count++;
            string xldm;
            while(true)
            {
                xldm = dldm[0] + (count).ToString();
                sql = "SELECT COUNT(*) FROM xiaolei WHERE Dm = @Dm";
                int count2;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Dm", xldm);
                    connection.Open();
                    count2 = (int)command.ExecuteScalar();
                }
                if (count2 == 0)
                {
                    break;
                }
                count++;
            }

            string Dm = xldm;
            string Mc = McTextBox.Text;
            if (string.IsNullOrEmpty(Dm) || string.IsNullOrEmpty(Mc))
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM xiaolei WHERE  Mc=@Mc;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Mc", Mc);
                int count2 = (int)command.ExecuteScalar();
                if (count2 > 0)
                {
                    MessageBox.Show("名称已存在！");
                }
                else
                {

                    command = new SqlCommand("INSERT INTO xiaolei (Dm,Mc)VALUES(@Dm,@Mc)", connection);
                    command.Parameters.AddWithValue("@Dm", Dm);
                    command.Parameters.AddWithValue("@Mc", Mc);
                    command.ExecuteNonQuery();
                    MessageBox.Show("新增成功！请刷新");
                    this.Close();


                }
            }
        }

        private void AddxiaoleiName_Load(object sender, EventArgs e)
        {
            string query = "SELECT Mc FROM dalei";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DaleiComboBox.Items.Add(reader["Mc"].ToString());
                }

                reader.Close();
            }
        }
    }
}
