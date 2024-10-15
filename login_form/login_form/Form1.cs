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
using main_system_app;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace login_form
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel1.Region = new Region(path);
        }

        private void Textusername_Enter(object sender, EventArgs e)
        {
            if (textusername.Text == "Username")
            {
                textusername.Text = "";
                textusername.Font = new Font(textusername.Font.FontFamily, 12, textusername.Font.Style);
                textusername.Font = new Font(textusername.Font, FontStyle.Regular);
                textusername.Font = new Font("Arial", textusername.Font.Size, textusername.Font.Style);
                textusername.ForeColor = Color.Black;
            }
        }

        private void Textusername_Leave(object sender, EventArgs e)
        {
            if (textusername.Text == "")
            {
                textusername.Text = "Username";
                textusername.Font = new Font(textusername.Font, FontStyle.Regular);
                textusername.Font = new Font("Bookman Old Style", textusername.Font.Size, textusername.Font.Style);
                textusername.ForeColor = Color.DarkGray;
            }
        }

        private void Textpassword_Enter(object sender, EventArgs e)
        {
            if (textpassword.Text == "Password")
            {
                textpassword.Text = "";
                textpassword.UseSystemPasswordChar = true;
                textpassword.Font = new Font(textpassword.Font.FontFamily, 13, textpassword.Font.Style);
                textpassword.Font = new Font(textpassword.Font, FontStyle.Regular);
                textpassword.Font = new Font("Bookman Old Style", textpassword.Font.Size, textpassword.Font.Style);
                textpassword.ForeColor = Color.Black;
            }
        }

        private void Textpassword_Leave(object sender, EventArgs e)
        {
            if (textpassword.Text == "")
            {
                textpassword.Text = "Password";
                textpassword.UseSystemPasswordChar = false;
                textpassword.Font = new Font(textpassword.Font, FontStyle.Regular);
                textpassword.Font = new Font("Bookman Old Style", textpassword.Font.Size, textpassword.Font.Style);
                textpassword.ForeColor = Color.DarkGray;
            }
        }

        private void Labelforget_MouseEnter(object sender, EventArgs e)
        {
            Font currentFont = labelforget.Font;
            labelforget.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline);
        }

        private void Labelforget_MouseLeave(object sender, EventArgs e)
        {
            Font currentFont = labelforget.Font;
            labelforget.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
        }
        public static readonly IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("Appsetting.json").Build();
        SqlConnection connection = new SqlConnection(config.GetSection("constr").Value);
        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //if (textpassword.Text == "Password" && textusername.Text == "Username")
            //{
            //    this.Hide();
            //    formApp form = new formApp();
            //    form.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password. Please try again.");
            //}
            string username = textusername.Text;
            string password = textpassword.Text;
            string sql = "select * from manager";
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                connection.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if(username == reader.GetString(1).ToString() && password == reader.GetString(2).ToString())
                        {
                            this.Hide();
                            formApp form = new formApp();
                            form.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(230, 230, 230, 230);
            this.Opacity = 0;
            Timer timer1 = new Timer
            {
                Interval = 50
            };
            timer1.Tick += new EventHandler(Timer_Tick);
            timer1.Start();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();

            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.17;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Textpassword_IconRightClick(object sender, EventArgs e)
        {
            if (textpassword.UseSystemPasswordChar == true)
            {
                textpassword.UseSystemPasswordChar = false;
                textpassword.IconRight = Properties.Resources.hide;
            }
            else
            {
                textpassword.UseSystemPasswordChar = true;
                textpassword.IconRight = Properties.Resources.show;
            }
        }

       
        private void labelforget_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000);

            // set up email message
            MailMessage message = new MailMessage();
            message.From = new MailAddress("y_bouzenacha@estin.dz");
            message.To.Add("younesbc2123@gmail.com");
            message.Subject = "Random Number";
            message.Body = $"Your random number is {randomNumber}";

            // set up email client
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("y_bouzenacha@estin.dz", "bwcptennkletrwza");
            client.EnableSsl = true;

            // send email
            client.Send(message);
            MessageBox.Show("We have send recovery code to your email");

            //Change the password to the random number sent to email
            try
            {

                string query = "UPDATE Manager set Pass_word= @ps";
                SqlParameter prm = new SqlParameter
                {
                    ParameterName = "@ps", //1682
                    SqlDbType = SqlDbType.NVarChar,
                    Value = randomNumber.ToString(),
                };
                
                SqlCommand cmd = new SqlCommand(query, connection);
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
