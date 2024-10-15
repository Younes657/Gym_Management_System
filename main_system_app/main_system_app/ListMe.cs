using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace main_system_app
{
    public partial class ListMe : Form
    {
        public static readonly IConfiguration config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
        SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);
        public ListMe()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void View_Load(object sender, EventArgs e)
        {
            View_M(connection);
            test.Check(connection);
        }
        public  void View_M(SqlConnection connection)
        {
            string query = "select M.ID , M.First_name , M.Last_name , M.Email , M.Gender , Reg_date , ISNULL(C.First_name , 'UNKNOWN') as Coach, Subscribtion_type,Is_paid, Is_date_end as [Date End] , Is_notifyed as [Notifyed] , Renewal_on , M.Age from Members M left join Coachs C on M.CoachID = C.ID_C";
            
                connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);

            DataTable ds = new DataTable();
            
            sda.Fill(ds);
            connection.Close();

            table_Member.DataSource = ds;
        }

        private void refrech_Click(object sender, EventArgs e)
        {
            View_M(connection);
            test.Check(connection);
        }

        private void searchLIST_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "select M.ID , M.First_name , M.Last_name , M.Email , M.Gender , Reg_date, ISNULL(C.First_name , 'UNKNOWN') as Coach, Subscribtion_type,Is_paid ,Is_date_end, Is_notifyed , Renewal_on , M.Age from Members M left join Coachs C on M.CoachID = C.ID_C WHERE M.First_name LIKE '%'+@name+'%'  OR M.Last_name Like '%'+@name+'%'";
            
            SqlParameter prm = new SqlParameter()
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = searchLIST.Text,
            };
            var tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            adapter.SelectCommand.Parameters.Add(prm);
            adapter.Fill(tbl);
            connection.Close();
            table_Member.DataSource = tbl;
        }
    }
}
