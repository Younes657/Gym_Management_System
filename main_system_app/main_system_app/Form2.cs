using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace main_system_app
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
 int nLeftRect,     // x-coordinate of upper-left corner
 int nTopRect,      // y-coordinate of upper-left corner
 int nRightRect,    // x-coordinate of lower-right corner
 int nBottomRect,   // y-coordinate of lower-right corner
 int nWidthEllipse, // width of ellipse
 int nHeightEllipse // height of ellipse

);
        public Form2()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static readonly IConfiguration config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
        SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if(username.Text == "" || password.Text == "" || confPassword.Text == "") 
            {
                MessageBox.Show("Invalid ! check again");
            }
            else
            {
                if(password.Text == confPassword.Text)
                {
                    string sql = "UPDATE Manager SET Username = @user , Pass_word = @pass";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@user", username.Text);
                    cmd.Parameters.AddWithValue("@pass", password.Text);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Operation Done ...");
                        username.Text = "";
                        password.Text = "";
                        confPassword.Text = "";
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("password incorrect check again !!!");
                }
            }
        }
    }
}
