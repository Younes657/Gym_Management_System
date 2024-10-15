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
using System.Web.UI.WebControls;
using Microsoft.Data.SqlClient;

namespace main_system_app
{
    public partial class UserControl3 : UserControl
    {
        public static readonly IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
        SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);
        public UserControl3()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (nameE.Text == string.Empty)
            {
                MessageBox.Show("insert some needed information !!!");
            }
            else
            {
                Equipment eq = new Equipment()
                {
                    Name = nameE.Text,
                    Category = type.Text,
                    Quantity = (int)quantity.Value,
                    IsDisabeld = disabled.Checked,
                };
                string sql = "INSERT INTO Equipment VALUES (@N , @C , @Q , @I)";
                SqlParameter prm1 = new SqlParameter
                {
                    ParameterName = "@N",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = eq.Name,
                };
                SqlParameter prm2 = new SqlParameter
                {
                    ParameterName = "@C",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = eq.Category,
                };
                SqlParameter prm3 = new SqlParameter
                {
                    ParameterName = "@Q",
                    SqlDbType = SqlDbType.Int,
                    Value = eq.Quantity,
                };
                SqlParameter prm4 = new SqlParameter
                {
                    ParameterName = "@I",
                    SqlDbType = SqlDbType.Bit,
                    Value = eq.IsDisabeld,
                };
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);
                command.Parameters.Add(prm3);
                command.Parameters.Add(prm4);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Done");
                    View_E(connection);
                    string sql1 = "select dbo.GET_TOTAL_E() as result";
                    UserControl1.total_E.Text = UserControl1.Get_Total(connection, sql1).ToString();
                    string sql3 = "select dbo.GET_TOTAL_E_D() as result";
                    UserControl1.total_P.Text = UserControl1.Get_Total(connection, sql3).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            View_E(connection);
        }
        public void View_E(SqlConnection connection)
        {
            string sql = "SELECT * FROM Equipment";
            DataTable table = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            adapter.Fill(table);
            connection.Close();
            table_E.DataSource = table;
        }
        public int key = 0;
        private void table_E_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            key = Convert.ToInt32(table_E.SelectedRows[0].Cells[0].Value.ToString());
            nameE.Text = table_E.SelectedRows[0].Cells[1].Value.ToString();
            quantity.Value = (int)table_E.SelectedRows[0].Cells[3].Value;
            type.Text = table_E.SelectedRows[0].Cells[2].Value.ToString();
            disabled.Checked = (bool)table_E.SelectedRows[0].Cells[4].Value;

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (nameE.Text == string.Empty || key == 0)
            {
                MessageBox.Show("missing information check again !!");
            }
            else
            {
                Equipment eq = new Equipment()
                {
                    Name = nameE.Text,
                    Category = type.Text,
                    Quantity = (int)quantity.Value,
                    IsDisabeld = disabled.Checked,
                };

                string sql = "UPDATE  Equipment SET Name_E = @n , Category = @t , How_many = @q" +
                    ",Is_disabeld = @i WHERE ID_E = @id";
                SqlParameter prm1 = new SqlParameter
                {
                    ParameterName = "@n",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = eq.Name,
                };
                SqlParameter prm2 = new SqlParameter
                {
                    ParameterName = "@t",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = eq.Category,
                };
                SqlParameter prm3 = new SqlParameter
                {
                    ParameterName = "@q",
                    SqlDbType = SqlDbType.Int,
                    Value = eq.Quantity,
                };
                SqlParameter prm4 = new SqlParameter
                {
                    ParameterName = "@i",
                    SqlDbType = SqlDbType.Bit,
                    Value = eq.IsDisabeld,
                };
                SqlParameter prm5 = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.Int,
                    Value = key
                };
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);
                command.Parameters.Add(prm3);
                command.Parameters.Add(prm4);
                command.Parameters.Add(prm5);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Done");
                    View_E(connection);
                    string sql3 = "select dbo.GET_TOTAL_E_D() as result";
                    UserControl1.total_P.Text = UserControl1.Get_Total(connection, sql3).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("select the member you want to delete !!!");
            }
            else
            {
                try
                {
                    string sql = "DELETE FROM Equipment WHERE ID_E = @id";
                    SqlParameter prm = new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = key,
                    };
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(prm);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("deleted");
                    View_E(connection);
                    string sql1 = "select dbo.GET_TOTAL_E() as result";
                    UserControl1.total_E.Text = UserControl1.Get_Total(connection, sql1).ToString();
                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message);
                };
            }
        }

        private void delete_all_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE Equipment";
            test.DELETE_ALL(connection, sql);
            MessageBox.Show("all deleted with success");
            View_E(connection);
            string sql1 = "select dbo.GET_TOTAL_E() as result";
            UserControl1.total_E.Text = UserControl1.Get_Total(connection, sql1).ToString();
            //you  should change m to e
        }

        private void reset_Click(object sender, EventArgs e)
        {
            nameE.Text = string.Empty;
            quantity.Value = 0;
           
            disabled.Checked = false;
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "select * FROM Equipment WHERE Category LIKE '%'+@name+'%' ";
            SqlParameter prm = new SqlParameter()
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = searchE.Text,
            };
            var tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            adapter.SelectCommand.Parameters.Add(prm);
            adapter.Fill(tbl);
            connection.Close();
            table_E.DataSource = tbl;
        }
    }
}
