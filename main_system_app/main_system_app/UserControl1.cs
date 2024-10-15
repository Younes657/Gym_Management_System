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
using System.Net.Mail;
using System.Net;

namespace main_system_app
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public static readonly IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
        SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string sql = "select dbo.GET_TOTAL_M() as result";
            total_M.Text = Get_Total(connection, sql).ToString();
            string sql1 = "select dbo.GET_TOTAL_C() as result";
            total_C.Text = Get_Total(connection, sql1).ToString();
            string sql2 = "select dbo.GET_TOTAL_E() as result";
            total_E.Text = Get_Total(connection, sql2).ToString();
            string sql3 = "select dbo.GET_TOTAL_E_D() as result";
            total_P.Text = Get_Total(connection, sql3).ToString();
            
            string sql4 = "select dbo.GET_TOTAL_P() as result";
            totalPr.Text = Get_Total(connection, sql4).ToString();
            Expired_weak(connection);
            Expired_yesterday(connection);
            Ajoute();
        }
        public static int Get_Total(SqlConnection connection, string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = System.Data.CommandType.Text;
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();
            command.Dispose();
            //connection.Dispose();  It should be called as soon as the connection is no longer needed
            return count;
        }
        public  int Get_T_M(SqlConnection connection)
        {
            string sql = "SELECT dbo.TOTAL_EARNING_MB(@sd , @ed) as result";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@sd", sd.Value.Date);
            cmd.Parameters.AddWithValue("@ed", ed.Value.Date);
            connection.Open();
            int res = (int)cmd.ExecuteScalar();
            connection.Close();
            cmd.Dispose();
            return res;
        }
        public static void Expired_weak(SqlConnection connection)
        {
            string sql = "SELECT ID , First_name , Last_name  FROM Members " + "WHERE (Reg_date BETWEEN DATEADD(day , -30 , @dnow) AND DATEADD(day , -23 , @dnow))" + "OR Renewal_on  BETWEEN DATEADD(day , -30 , @dnow) AND DATEADD(day , -23 , @dnow)";
            SqlParameter prm1 = new SqlParameter
            {
                ParameterName = "@dnow",
                DbType = System.Data.DbType.Date,
                Direction = System.Data.ParameterDirection.Input,
                Value = DateTime.Now.Date//.AddDays(1)
            };

            DataTable table = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            adapter.SelectCommand.Parameters.Add(prm1);
            adapter.Fill(table);
            connection.Close();
            adapter.Dispose();
            weak.DataSource = table; 
        }
        public static void Expired_yesterday(SqlConnection connection)
        {
            string sql = "SELECT ID , First_name , Email  FROM Members " +
                "WHERE (Reg_date <= @d OR Renewal_on <= @d) AND Is_paid = 0";
            SqlParameter param = new SqlParameter()
            {
                ParameterName = "@d",
                SqlDbType = System.Data.SqlDbType.Date,
                Direction = System.Data.ParameterDirection.Input,
                Value = DateTime.Now.Date.AddDays(-30),
            };
            DataTable table = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            adapter.SelectCommand.Parameters.Add(param);
            adapter.Fill(table);
            connection.Close();
            adapter.Dispose();
            yesterday.DataSource = table;

        }
        public void Ajoute()
        {
            if (yesterday.SelectedRows.Count < 4)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

                // Set the column properties
                buttonColumn.HeaderText = "Notification";
                buttonColumn.Name = "buttonColumn";
                buttonColumn.Text = "Send";
                buttonColumn.UseColumnTextForButtonValue = true;
                yesterday.Columns.Add(buttonColumn);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            totalEM.Text = Get_T_M(connection).ToString() + " DA";
        }

        
        private void yesterday_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (yesterday.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               
                MailMessage message = new MailMessage();
                message.From = new MailAddress("y_bouzenacha@estin.dz");
                try
                {
                    message.To.Add(yesterday.SelectedRows[0].Cells[3].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("invalid email !!!");
                }
                message.Subject = "Power GYM ...";
                message.Body = "your subscription in powergym is end please check the manager of the gym \n dir la presentation yerham waldik !!!!!!";

                // set up email client
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("y_bouzenacha@estin.dz", "bwcptennkletrwza");
                client.EnableSsl = true;

                // send email
                try
                {
                    client.Send(message);
                    MessageBox.Show("email sent with succec");
                    string sql = "UPDATE Members SET Is_notifyed = 1 WHERE ID = @id";
                    SqlParameter prm = new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = (int)yesterday.SelectedRows[0].Cells[1].Value,
                    };
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add(prm);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

    public class Expired_mb
    {
        public int Id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string Email { get; set; }

        public DateTime date { get; set; }
    }
}