using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHomework
{
    public partial class GoumaiXinxi : Form
    {
        string connectionString = "Data Source=127.0.0.1;Initial Catalog=jiadianxiaoshou;User Id=xiba;Password=123;";
        string Dj;
        int gsbh;
        string kucunliang;
        public GoumaiXinxi(string Mc,string Dj1, string kucunliang)
        {
            InitializeComponent();
            label2.Text = Mc;
            Dj = Dj1;
            this.kucunliang = kucunliang;
        }

        private void GoumaiXinxics_Load(object sender, EventArgs e)
        {
            if(NumberTextBox.Text!="")
            {
                Regex regex = new Regex(@"^[1-9]\d*$");
                if (regex.IsMatch(NumberTextBox.Text))
                {
                    double djValue = double.Parse(Dj);
                    double price = int.Parse(NumberTextBox.Text) * djValue;
                    label8.Text = price.ToString();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Mc = label2.Text;
            string Xl = NumberTextBox.Text;
            string price = label8.Text;
            string Gsmc = McTextBox.Text;
            string Lxr = LxrTextBox.Text;
            string Lxdh = LxdhTextBox.Text;

            // 定义正则表达式
            Regex regex = new Regex(@"^[1-9]\d*$");

            // 检查输入是否符合正则表达式
            if (regex.IsMatch(Xl))
            {
                // 输入为正整数
                Console.WriteLine("输入为正整数");
            }
            else
            {
                MessageBox.Show("输入正确的数量！");
                return;
            }

            if (int.Parse(Xl)> int.Parse(kucunliang))
            {
                MessageBox.Show("库存不足!");
                return;
            }

            if (string.IsNullOrEmpty(Lxr) || string.IsNullOrEmpty(Lxdh) || string.IsNullOrEmpty(Gsmc) || string.IsNullOrEmpty(Xl))
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }//更改买方公司表
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM maifanggongsi WHERE Mc = @Mc;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Mc", Gsmc);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    query = "SELECT Bh FROM maifanggongsi WHERE Mc = @Mc;";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Mc", Gsmc);
                    gsbh = int.Parse(command.ExecuteScalar().ToString()); 
                }
                else
                {
                    String sql = "SELECT TOP 1 Bh FROM maifanggongsi ORDER BY Bh DESC";
                    command = new SqlCommand(sql, connection);
                    int recordCount = Convert.ToInt32(command.ExecuteScalar()) + 1;


                    command = new SqlCommand("INSERT INTO maifanggongsi (Bh,Mc,Lxr,Lxdh)VALUES(@Bh,@Mc,@Lxr,@Lxdh)", connection);
                    command.Parameters.AddWithValue("@Bh", recordCount);
                    command.Parameters.AddWithValue("@Mc", Gsmc);
                    command.Parameters.AddWithValue("@Lxr", Lxr);
                    command.Parameters.AddWithValue("@Lxdh", Lxdh);

                    command.ExecuteNonQuery();
                    gsbh = recordCount;
                    this.Close();
                }
            }//更改销售表
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //查询有无该公司记录
                string query = "SELECT COUNT(*) FROM xiaoshou WHERE Gsbh = @Gsbh;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Gsbh", gsbh);
                int count = (int)command.ExecuteScalar();
                if (count > 0) //有公司记录直接修改值
                {
                    string old_Bh = "";
                    string old_Gsbh = "";
                    string old_Xssl = "";
                    string old_Sxrq = "";
                    string old_Xsje = "";
                    query = "SELECT * FROM xiaoshou";
                    using (command = new SqlCommand(query, connection))
                    {
                        // 执行查询，返回一个 SqlDataReader 对象
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                old_Bh = reader.GetString(0);
                                old_Gsbh = reader.GetString(1);
                                old_Xssl = reader.GetString(2);
                                old_Sxrq = reader.GetString(3);
                                old_Xsje = reader.GetString(4);
                            }
                        }
                    }
                    string new_Xssl = (int.Parse(old_Xssl)+int.Parse(Xl)).ToString();
                    DateTime currentDate = DateTime.Now;
                    string new_Sxrq = currentDate.ToString();
                    string new_Xsje = (int.Parse(old_Xssl)+int.Parse(price)).ToString();
                    query = "UPDATE xiaoshou SET Xssl = @Xssl,Xsrq = @Xsrq,Xsje = @Xsje WHERE Gsbh=@Gsbh";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Xssl", new_Xssl);
                    command.Parameters.AddWithValue("@Xsrq", new_Sxrq);
                    command.Parameters.AddWithValue("@Xsje", new_Xsje);
                    command.Parameters.AddWithValue("@Gsbh", old_Gsbh);
                    command.ExecuteNonQuery();
                }
                else //没有公司记录添加记录
                {
                    //获取编号
                    String sql = "SELECT TOP 1 Bh FROM maifanggongsi ORDER BY Bh DESC";
                    command = new SqlCommand(sql, connection);
                    int Bh = Convert.ToInt32(command.ExecuteScalar()) + 1;


                    command = new SqlCommand("INSERT INTO xiaoshou (Bh,Gsbh,Xssl,Xsrq,Xsje)VALUES(@Bh,@Gsbh,@Xssl,@Xsrq,@Xsje)", connection);
                    command.Parameters.AddWithValue("@Bh", Bh);
                    command.Parameters.AddWithValue("@Gsbh", gsbh);
                    command.Parameters.AddWithValue("@Xssl", Xl);
                    DateTime currentDate = DateTime.Now;
                    command.Parameters.AddWithValue("@Xsrq", currentDate.ToString());
                    command.Parameters.AddWithValue("@Xsje", price);

                    command.ExecuteNonQuery();
                    this.Close();
                }
            }//更改销售明细表
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //编号
                String sql = "SELECT TOP 1 Bh FROM xiaoshoumingxi ORDER BY Bh DESC";
                SqlCommand command = new SqlCommand(sql, connection);
                int recordCount = Convert.ToInt32(command.ExecuteScalar()) + 1;
                //查询销售编号
                sql = "SELECT Bh FROM xiaoshou WHERE Gsbh = @Gsbh;";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Gsbh", gsbh);
                string Xsbh = command.ExecuteScalar().ToString();
                //查询物品编号
                sql = "SELECT Bh FROM jiadian WHERE Mc = @Mc;";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Mc", Mc);
                string Wpbh = command.ExecuteScalar().ToString();


                command = new SqlCommand("INSERT INTO xiaoshoumingxi (Bh,Xsbh,Wpbh,Xl,Dj,Xj)VALUES(@Bh,@Xsbh,@Wpbh,@Xl,@Dj,@Xj)", connection);
                command.Parameters.AddWithValue("@Bh", recordCount);
                command.Parameters.AddWithValue("@Xsbh", Xsbh);
                command.Parameters.AddWithValue("@Wpbh", Wpbh);
                command.Parameters.AddWithValue("@Xl", Xl);
                command.Parameters.AddWithValue("@Dj", Dj);
                command.Parameters.AddWithValue("@Xj", price);


                command.ExecuteNonQuery();
                gsbh = recordCount;
                this.Close();
            }
            MessageBox.Show("购买成功");

        }
    }
}
