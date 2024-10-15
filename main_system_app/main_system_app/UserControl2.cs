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

namespace main_system_app
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public class Coach_ls
        {

            public string first { get; set; }
            public int? id { get; set; }
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            var config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
            SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);

            test.coachLst(connection, Cid);

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            var config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
            SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);
            if (First.Text == "" || Last.Text == "")
            {
                MessageBox.Show("Add some information..");
            }
            else
            {
                Member mb = new Member()
                {
                    FirstName = First.Text,
                    LastName = Last.Text,
                    Email = Email.Text,
                    Gender = Gender.Text,
                    RegDate = (DateTime)Reg.Value,
                    SubscribtionType = Stype.Text,
                    Age = (int)Age.Value
                };
                string sql;
                SqlCommand command;
                if (Cid.SelectedValue is null)
                {
                    mb.CoachID = null;
                    sql = "INSERT INTO Members (First_name , Last_name , Email , Gender , Age, Reg_date , Subscribtion_type) VALUES (@F , @L , @E , @G ,@A , @R , @S)";
                    command = new SqlCommand(sql, connection);
                }
                else
                {
                    mb.CoachID = (int)Cid.SelectedValue;
                    sql = "INSERT INTO Members (First_name , Last_name , Email , Gender , Age ,CoachID , Reg_date , Subscribtion_type) VALUES (@F , @L , @E , @G ,@A, @C , @R , @S)";
                    SqlParameter prm5 = new SqlParameter
                    {
                        ParameterName = "@C",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = mb.CoachID
                    };
                    
                    command = new SqlCommand(sql, connection);
                    command.Parameters.Add(prm5);

                }



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

                SqlParameter prm6 = new SqlParameter
                {
                    ParameterName = "@R",
                    SqlDbType = System.Data.SqlDbType.Date,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.RegDate.Date.ToString("d")
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
                    ParameterName = "@A",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Input,
                    Value = mb.Age
                };

                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);
                command.Parameters.Add(prm3);
                command.Parameters.Add(prm4);

                command.Parameters.Add(prm6);
                command.Parameters.Add(prm7);
                command.Parameters.Add(prm8);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Done");
                    //ListMe.View_M(connection);
                    UserControl4.View(connection);
                  
                    string sql1 = "select dbo.GET_TOTAL_M() as result";
                    UserControl1.total_M.Text = UserControl1.Get_Total(connection, sql1).ToString();
                    UserControl1.Expired_yesterday(connection);
                    UserControl1.Expired_weak(connection);
                    test.Check(connection);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            First.Text = "";
            Last.Text = string.Empty;
            Gender.Text = string.Empty;
            Email.Text = string.Empty;
            Age.Text = string.Empty;
            Stype.Text = string.Empty;
            Reg.Text = string.Empty;
        }
    }
}
