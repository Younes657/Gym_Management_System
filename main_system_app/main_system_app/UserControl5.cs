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
using System.Web.Caching;
using System.Windows.Input;

namespace main_system_app
{
    public partial class UserControl5 : UserControl
    {
        public static readonly IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
        SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);
        public UserControl5()
        {
            InitializeComponent();
        }

        UserControl4 us = new UserControl4();

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (fn.Text == string.Empty)
            {
                MessageBox.Show("add some information ...");
            }
            else {
                Coach mb = new Coach
                {
                    FirstName = fn.Text,
                    LastName = ln.Text,
                    Email = E.Text,
                    Gender = G.Text,
                    Phone = Ph.Text
                };
                string sql = "INSERT INTO Coachs (First_name , Last_name , Email , Gender ,Phone) VALUES (@F , @L , @E , @G , @P)";

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
                    ParameterName = "@P",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.Phone
                };

                SqlCommand command = new SqlCommand(sql, connection);
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);
                command.Parameters.Add(prm3);
                command.Parameters.Add(prm4);
                command.Parameters.Add(prm5);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Done");
                View_C(connection);
                test.coachLst(connection, UserControl4.cid);
                test.coachLst(connection, UserControl2.Cid);
                string sql1 = "select dbo.GET_TOTAL_C() as result";
                UserControl1.total_C.Text = UserControl1.Get_Total(connection, sql1).ToString();
            }
        }

        public void View_C(SqlConnection connection)
        {
            string query = "select * from Coachs ";
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            var ds = new DataSet();
            sda.Fill(ds);
            connection.Close();
            table_Coach.DataSource = ds.Tables[0];


        }
        private void UserControl5_Load(object sender, EventArgs e)
        {
            View_C(connection);
        }

        private void Ubdate_Coach_Click(object sender, EventArgs e)
        {

            if (key == 0 || ln.Text == "" || fn.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                Member mb = new Member
                {
                    FirstName = fn.Text,
                    LastName = ln.Text,
                    Email = E.Text,
                    Gender = G.Text,

                };
                string sql = "UPDATE Coachs SET First_name = @F, Last_name = @L , Email = @E , Gender = @G  WHERE ID_C = @id";

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

                SqlParameter prm9 = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = key
                };

                SqlCommand command = new SqlCommand(sql, connection);
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);
                command.Parameters.Add(prm3);
                command.Parameters.Add(prm4);
                command.Parameters.Add(prm9);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Coach update with success");
                View_C(connection);
                UserControl4.View(connection);
                test.coachLst(connection, UserControl4.cid);
                test.coachLst(connection, UserControl2.Cid);
            }
        }
        int key = 0;

        private void Delete_Coach_Click(object sender, EventArgs e)
        {


            if (key == 0)
            {
                MessageBox.Show("select the Coach you want to delete !!!");
            }
            else
            {
                try
                {

                    string sql = "DELETE FROM Coachs WHERE ID_C = @id";
                    SqlParameter prm = new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = key,
                    };
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(prm);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Coach deleted ");
                    View_C(connection);
                    string sql1 = "select dbo.GET_TOTAL_C() as result";
                    UserControl1.total_C.Text = UserControl1.Get_Total(connection, sql1).ToString();
                    test.coachLst(connection, UserControl4.cid);
                    test.coachLst(connection, UserControl2.Cid);
                    UserControl4.View(connection);

                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message);
                };
            }
        }

        private void table_Coach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(table_Coach.SelectedRows[0].Cells[0].Value.ToString());
            fn.Text = table_Coach.SelectedRows[0].Cells[1].Value.ToString();
            ln.Text = table_Coach.SelectedRows[0].Cells[2].Value.ToString();
            E.Text = table_Coach.SelectedRows[0].Cells[3].Value.ToString();
            G.Text = table_Coach.SelectedRows[0].Cells[4].Value.ToString();
            Ph.Text = table_Coach.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void delete_all_C_Click(object sender, EventArgs e)
        {

            string sql = "DELETE FROM Coachs";
            test.DELETE_ALL(connection, sql);
            MessageBox.Show("all deleted with success");
            View_C(connection);
            test.coachLst(connection, UserControl4.cid);
            test.coachLst(connection, UserControl2.Cid);
            string sql1 = "select dbo.GET_TOTAL_C() as result";
            UserControl1.total_C.Text = UserControl1.Get_Total(connection, sql1).ToString();
            UserControl4.View(connection);
        }

        private void Reset_Coach_Click(object sender, EventArgs e)
        {
            fn.Text = "";
            ln.Text = "";
            Ph.Text = "";
            E.Text = "";
        }
    }
}
