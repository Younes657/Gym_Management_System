using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static main_system_app.UserControl2;

namespace main_system_app
{
    internal class test
    {
        public static void coachLst(SqlConnection connection, Guna.UI2.WinForms.Guna2ComboBox box)
        {
            string sql = "SELECT ID_C , First_name FROM Coachs";
            List<Coach_ls> ls = new List<Coach_ls>();
            connection.Open();
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Coach_ls cl = new Coach_ls()
                        {
                            first = reader.GetString(1),
                            id = reader.GetInt32(0)
                        };

                        ls.Add(cl);
                    }
                }
            }
            connection.Close();
            //List<string> ls_c = new List<string>();
            //foreach(var item in ls)
            //{
            //    ls_c.Add(item.first);
            //}
            //Cid.Items.AddRange(ls_c.ToArray());
            ls.Add(new Coach_ls { first = "UNKNOWN", id = null });
            box.DataSource = ls;
            box.DisplayMember = "first";
            box.ValueMember = "id";
            
        }
        public static void DELETE_ALL(SqlConnection connection, string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void Check(SqlConnection connection)
        {
            string sql = "SELECT ID , Reg_date , Renewal_on FROM Members " +
                "WHERE Reg_date <= @d OR Renewal_on <= @d";
            List<IDD> lsd = new List<IDD>();
            SqlParameter param = new SqlParameter()
            {
                ParameterName = "@d",
                SqlDbType = System.Data.SqlDbType.Date,
                Direction = System.Data.ParameterDirection.Input,
                Value = DateTime.Now.Date.AddDays(-30),
            };
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(param);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                IDD idd = new IDD
                {
                    Id = reader.GetInt32(0),
                    Date_reg = reader.GetDateTime(1),
                    Date_new = reader.GetDateTime(2)
                };
                lsd.Add(idd);
            }
            reader.Close();
            connection.Close();
            command.Dispose();
            
            string sql2 = "UPDATE Members SET  Is_date_end = 1 WHERE ID = @id";
            connection.Open();
            SqlCommand command2 = new SqlCommand(sql2, connection);
            SqlParameter prm = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Input,
            };
            command2.Parameters.Add(prm);
            foreach (var item in lsd)
            {
                command2.Parameters["@id"].Value = item.Id;
                 command2.ExecuteNonQuery();
            }
            connection.Close();
            
            command2.Dispose();
        }
    }
    public class IDD
    {
        public int Id { get; set; }
        public DateTime Date_reg { get; set; }
        public DateTime Date_new { get; set; }
    }
}
