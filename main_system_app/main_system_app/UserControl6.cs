using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.IO;


namespace main_system_app
{
    public partial class UserControl6 : UserControl
    {
        public static readonly IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
        SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);
        public UserControl6()
        {
            InitializeComponent();
        }

        private void addE_Click(object sender, EventArgs e)
        {
            if (nameP.Text == string.Empty)
            {
                MessageBox.Show("missing information check again!!!");
            }
            else
            {
                byte[] imageData = new Byte[] {0x1};
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                }
                Product pr = new Product()
                {
                    NameP = nameP.Text,
                    Price = (decimal)price.Value,
                    Quantity = (int)quantity.Value,
                    Type = type.Text,
                    Weight = (decimal)weight.Value,
                    Country = country.Text,
                    image = imageData
                };
                string sql = "INSERT INTO Products VALUES (@n , @q, @t , @c,@w, @p,@im )";
                SqlParameter prm = new SqlParameter
                {
                    ParameterName = "@im",
                    SqlDbType = SqlDbType.VarBinary,
                    Direction = ParameterDirection.Input,
                    Value = pr.image
                };
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@n", pr.NameP);
                command.Parameters.AddWithValue("@q", pr.Quantity);
                command.Parameters.AddWithValue("@t", pr.Type);
                command.Parameters.AddWithValue("@c", pr.Country);
                command.Parameters.AddWithValue("@w", pr.Weight);
                command.Parameters.AddWithValue("@p", pr.Price);
                command.Parameters.Add(prm);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Product added");
                    View_P(connection);
                    string sql4 = "select dbo.GET_TOTAL_P() as result";
                    UserControl1.totalPr.Text = UserControl1.Get_Total(connection, sql4).ToString();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {
            View_P(connection);
        }
        public void View_P(SqlConnection connection)
        {
            string sql = "SELECT  * FROM GET_WITHOUT_IMG";
            DataTable tb = new DataTable();
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(tb);
                connection.Close();
                table_P.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void table_P_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(table_P.SelectedRows[0].Cells[0].Value);
            nameP.Text = table_P.SelectedRows[0].Cells[1].Value.ToString();
            quantity.Value = (int)table_P.SelectedRows[0].Cells[2].Value;
            type.Text = table_P.SelectedRows[0].Cells[3].Value.ToString();
            country.Text = table_P.SelectedRows[0].Cells[4].Value.ToString();
            weight.Value = (decimal)table_P.SelectedRows[0].Cells[5].Value;
            price.Value = (decimal)table_P.SelectedRows[0].Cells[6].Value;
            string sql = "SELECT Imagee FROM Products WHERE ID_P = @id";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("id", key);
            byte[] imageData = null;
            try
            {
                connection.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        imageData = (byte[])reader["Imagee"];
                        if ( imageData.Length > 3)
                        {
                            MemoryStream sm = new MemoryStream(imageData);
                            pictureBox1.Image = Image.FromStream(sm);
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                }
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (key == 0 || nameP.Text == string.Empty)
            {
                MessageBox.Show("missing information");
            }
            else
            {
                string sql = "DELETE FROM Products WHERE ID_P = @id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", key);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("product deleted ");
                    View_P(connection);
                    resetValue();
                    string sql4 = "select dbo.GET_TOTAL_P() as result";
                    UserControl1.totalPr.Text = UserControl1.Get_Total(connection, sql4).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetValue();
        }
        public void resetValue()
        {
            nameP.Text = "";
            quantity.Value = default(int);
            type.Text = "";
            country.Text = "";
            weight.Value = default(decimal);
            price.Value = default(decimal);
            pictureBox1.Image = null;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(key == 0 || nameP.Text == "")
            {
                MessageBox.Show("messing information to update check again..");
            }
            else
            {
                byte[] imageData = new Byte[] { 0x1 };
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                }
                Product pr = new Product()
                {
                    NameP = nameP.Text,
                    Price = (decimal)price.Value,
                    Quantity = (int)quantity.Value,
                    Type = type.Text,
                    Weight = (decimal)weight.Value,
                    Country = country.Text,
                    image = imageData
                };
                string sql = "UPDATE Products SET NAME_P = @N , Quantity = @Q , Type_P = @T ,"
                    + "Weight = @W , Price = @P , Country = @C , Imagee = @im WHERE ID_P = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@N", pr.NameP);
                command.Parameters.AddWithValue("@Q", pr.Quantity);
                command.Parameters.AddWithValue("@T", pr.Type);
                command.Parameters.AddWithValue("@C", pr.Country);
                command.Parameters.AddWithValue("@W", pr.Weight);
                command.Parameters.AddWithValue("@P", pr.Price);
                command.Parameters.AddWithValue("@im", pr.image);
                command.Parameters.AddWithValue("@id", key);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Product Updated");
                    View_P(connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteall_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE Products";
            test.DELETE_ALL(connection, sql);
            MessageBox.Show("all deleted with success");
            View_P(connection);
            resetValue();
            string sql4 = "select dbo.GET_TOTAL_P() as result";
            UserControl1.totalPr.Text = UserControl1.Get_Total(connection, sql4).ToString();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "select * From GET_WITHOUT_IMG WHERE NAME_P LIKE '%'+@name+'%'  OR Type_P Like '%'+@name+'%'";
            SqlParameter prm = new SqlParameter()
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = searchP.Text,
            };
            var tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            adapter.SelectCommand.Parameters.Add(prm);
            adapter.Fill(tbl);
            connection.Close();
            table_P.DataSource = tbl;
        }
    }
}
