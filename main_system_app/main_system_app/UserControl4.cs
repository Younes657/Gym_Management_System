using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace main_system_app
{
    public partial class UserControl4 : UserControl
    {
        public static readonly IConfiguration config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
        SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            View(connection);
            test.coachLst(connection, cid);
           
        }
        public static void View(SqlConnection connection)
        {
            string query = "select M.ID , M.First_name , M.Last_name , M.Email , M.Gender , ISNULL(C.First_name , 'UNKNOWN') as Coach, Subscribtion_type,Is_paid, Renewal_on , M.Age from Members M left join Coachs C on M.CoachID = C.ID_C";
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);

            var ds = new DataSet();
            sda.Fill(ds);
            connection.Close();
            table.DataSource = ds.Tables[0];

        }

        int key = 0;

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            
            if (key == 0)
            {
                MessageBox.Show("select the member you want to delete !!!");
            }
            else
            {
                try
                {
                    string sql = "DELETE FROM Members WHERE ID = @id";
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
                    MessageBox.Show("member deleted ");
                    View(connection);
                    //ListMe.View_M(connection);
                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message);
                };
            }
        }



        private void search_btn_TextChanged(object sender, EventArgs e)
        {

            connection.Open();
            string sql = "select M.ID , M.First_name , M.Last_name , M.Email , M.Gender , ISNULL(C.First_name , 'UNKNOWN') as Coach, Subscribtion_type,Is_paid, Renewal_on , M.Age from Members M left join Coachs C on M.CoachID = C.ID_C WHERE M.First_name LIKE '%'+@name+'%'  OR M.Last_name LIKE '%'+@name+'%'";
            SqlParameter prm = new SqlParameter()
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = search_btn.Text,
            };
            var tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            adapter.SelectCommand.Parameters.Add(prm);
            adapter.Fill(tbl);
            connection.Close();
            table.DataSource = tbl;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            if (key == 0 || namel.Text == "" || namef.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                Member mb = new Member
                {
                    FirstName = namef.Text,
                    LastName = namel.Text,
                    Email = email.Text,
                    Gender = gender.Text,
                    
                    RenewalON = DateTime.Parse(renew.Text),
                    SubscribtionType = stp.Text,
                    IsPaid = PAID.Checked
                };
                if (cid.SelectedValue == null) mb.CoachID = null; 
                else mb.CoachID = (int)cid.SelectedValue;
                string sql;
                SqlCommand command;
                if (cid.SelectedValue is null)
                {
                    mb.CoachID = null;

                }
                else
                {

                    mb.CoachID = (int)cid.SelectedValue;
                }
                sql = " UPDATE Members SET First_name = @F, Last_name = @L , Email = @E , Gender =@G , CoachID = @C , Renewal_on = @R, Subscribtion_type = @S , Is_paid = @P WHERE ID = @id";
                
                command = new SqlCommand(sql, connection);
                
                SqlParameter prm1 = new SqlParameter
                {
                    ParameterName = "@F",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.FirstName
                };
                SqlParameter prm2 = new SqlParameter
                {
                    ParameterName = "@L",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.LastName
                };
                SqlParameter prm3 = new SqlParameter
                {
                    ParameterName = "@E",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.Email
                };
                SqlParameter prm4 = new SqlParameter
                {
                    ParameterName = "@G",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.Gender
                };
                SqlParameter prm5 = new SqlParameter
                {
                    ParameterName = "@C",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Input,
                };
                if (mb.CoachID is null) prm5.Value = DBNull.Value;
                else prm5.Value = mb.CoachID;
                SqlParameter prm6 = new SqlParameter
                {
                    ParameterName = "@R",
                    SqlDbType = System.Data.SqlDbType.Date,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.RenewalON.Date.ToString("d")
                };
                SqlParameter prm7 = new SqlParameter
                {
                    ParameterName = "@S",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.SubscribtionType
                };
                SqlParameter prm8 = new SqlParameter
                {
                    ParameterName = "@P",
                    SqlDbType = System.Data.SqlDbType.Bit,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.IsPaid
                };
                SqlParameter prm9 = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = key
                };

                
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);
                command.Parameters.Add(prm3);
                command.Parameters.Add(prm4);
                command.Parameters.Add(prm5);
                command.Parameters.Add(prm6);
                command.Parameters.Add(prm7);
                command.Parameters.Add(prm8);
                command.Parameters.Add(prm9);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Member update with success");
                View(connection);
                UserControl1.Expired_yesterday(connection);
                UserControl1.Expired_weak(connection);
                test.Check(connection);
                View(connection);
                //ListMe.View_M(connection);
            }

        }

        private void table_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //M.ID , M.First_name , M.Last_name , M.Email , M.Gender , ISNULL(C.First_name , 'UNKNOWN') as Coach, Subscribtion_type,Is_paid, Renewal_on , M.Age
            key = Convert.ToInt32(table.SelectedRows[0].Cells[0].Value.ToString());
            namef.Text = table.SelectedRows[0].Cells[1].Value.ToString();
            namel.Text = table.SelectedRows[0].Cells[2].Value.ToString();
            email.Text = table.SelectedRows[0].Cells[3].Value.ToString();
            gender.Text = table.SelectedRows[0].Cells[4].Value.ToString();
            renew.Value = ((DateTime)table.SelectedRows[0].Cells[8].Value).Date;
            cid.Text = table.SelectedRows[0].Cells[5].Value.ToString();
            stp.Text = table.SelectedRows[0].Cells[6].Value.ToString();
            PAID.Checked = (bool)table.SelectedRows[0].Cells[7].Value;
            age.Text = table.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void delete_all_Click_1(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE Members";
            test.DELETE_ALL(connection, sql);
            MessageBox.Show("all deleted with success");
            //ListMe.View_M(connection);
            View(connection);
            string sql1 = "select dbo.GET_TOTAL_M() as result";
            UserControl1.total_M.Text = UserControl1.Get_Total(connection, sql1).ToString();
            UserControl1.Expired_yesterday(connection);
            UserControl1.Expired_weak(connection);
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ListMe vw = new ListMe();
            vw.Show();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            namef.Text = string.Empty;
            namel.Text = string.Empty;
            email.Text = string.Empty;
            gender.Text = string.Empty;
            renew.Value = DateTime.Now.Date;
            cid.Text = string.Empty;
            stp.Text = string.Empty;
            PAID.Checked = false;
            age.Text = string.Empty;
        }
    }
}
