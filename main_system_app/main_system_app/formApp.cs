using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
//using login_form;

namespace main_system_app
{
    public partial class formApp : Form
    {   
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,
int nTopRect,
int nRightRect,
int nBottomRect,
int nWidthEllipse,
int nHeightEllipse
);
        private const int DropDownHeightIncrement = 10;
        private const int DropDownHeightIncrement1 = 10;
        private const int DropDownMaxHeight = 90;
        private const int DropDownMaxHeight1 = 90;
        private bool isExpanded1 = false;
        private bool isExpanded = false;
        private bool isslide = false;
      
        private Timer timer = new Timer();
        private Timer timer1 = new Timer();
        public formApp()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panel2.Height = dashboarBTn.Height;
            panel2.Top = dashboarBTn.Top;
            panel2.Left = dashboarBTn.Left;
            //userControl11.BringToFront();
            // Set up the timer control
            timer.Interval = 3;
            timer1.Interval = 3;
            timer.Tick += new EventHandler(timer_Tick);
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void DashboarBTn_Click(object sender, EventArgs e)
        {

            MovePanel(dashboarBTn);
            userControl11.BringToFront();
        }
        private void MovePanel(Button button)
        {
            int targetTop = button.Top;
            int targetHeight = button.Height;
            int targetLeft = button.Left;

            // Set the number of animation steps and the delay between steps
            int steps = 10;
            int delay = 10;

            // Calculate the step size for each animation parameter
            int topStep = (targetTop - panel2.Top) / steps;
            int heightStep = (targetHeight - panel2.Height) / steps;
            int leftStep = (targetLeft - panel2.Left) / steps;

            // Disable the button to prevent multiple animations
            button.Enabled = false;

            // Create a Timer control and set its properties
            Timer timer = new Timer();
            timer.Interval = delay;
            int stepCount = 0;

            // Set the Tick event handler for the Timer control
            timer.Tick += (sender, e) =>
            {
                // Move the panel by one animation step
                panel2.Top += topStep;
                panel2.Height += heightStep;
                panel2.Left += leftStep;
                stepCount++;

                // Check if we have completed all the animation steps
                if (stepCount == steps)
                {
                    // Stop the Timer control and enable the button
                    timer.Stop();
                    button.Enabled = true;

                    // Set the final position and size of the panel
                    panel2.Top = targetTop;
                    panel2.Height = targetHeight;
                    panel2.Left = targetLeft;
                }
            };
            // Start the Timer control
            timer.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MovePanel(button2);

            panel3.Location = new Point(
                 button2.Left,
                 button2.Top + button2.Height
             );
            if (isExpanded1)
            {
                timer.Start();
                isExpanded1 = false;
            }
            else
            {
                panel3.Size = new Size(panel3.Width, 0);
                panel3.Visible = true;
                timer.Start();
                isExpanded1 = true;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (isExpanded1)
            {
                button4.Top += DropDownHeightIncrement1;
                button9.Top += DropDownHeightIncrement1;
                button1.Top += DropDownHeightIncrement1;
                panel3.Height += DropDownHeightIncrement1;
                if (panel3.Height >= DropDownMaxHeight1)
                {
                    timer.Stop();
                }
            }
            else
            {
                button1.Top -= DropDownHeightIncrement1;
                button4.Top -= DropDownHeightIncrement1;
                button9.Top -= DropDownHeightIncrement1;
                panel3.Height -= DropDownHeightIncrement1;
                if (panel3.Height <= 0)
                {
                    timer.Stop();
                    panel3.Visible = false;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                button9.Top += DropDownHeightIncrement1;
                button1.Top += DropDownHeightIncrement1;
                panel4.Height += DropDownHeightIncrement;
                if (panel4.Height >= DropDownMaxHeight)
                {
                    timer1.Stop();
                }
            }
            else
            {
                button1.Top -= DropDownHeightIncrement1;
                button9.Top -= DropDownHeightIncrement1;
                panel4.Height -= DropDownHeightIncrement;
                if (panel4.Height <= 0)
                {
                    timer1.Stop();
                    panel4.Visible = false;
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MovePanel(button4);
           
            userControl31.BringToFront();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            MovePanel(button9);
         
            userControl51.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MovePanel(button1);
           
            userControl61.BringToFront();
        }

        private void Button10_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
            timer3.Start();
        }

        private void Button10_MouseLeave(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MovePanel(dashboarBTn);
            userControl11.BringToFront();
            this.Opacity = 0;
            Timer timer10 = new Timer
            {
                Interval = 50
            };
            timer10.Tick += new EventHandler(Timer_Tick);
            timer10.Start();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();

            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.17;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (isslide)
            {
                panel5.Width -= 10;
                if (panel5.Width == panel5.MinimumSize.Width)
                {
                    isslide = false;
                    timer3.Stop();
                }
            }
            else
            {
                panel5.Width += 10;
                if (panel5.Width == panel5.MaximumSize.Width)
                {
                    isslide = true;
                    timer3.Stop();
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
            MovePanel(button2);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            userControl41.BringToFront();
            MovePanel(button2);
        }

        private void Guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.CenterScreen; // Set the position of Form2 to center of the screen
            form3.Load += async (s, ev) =>
            {
                // Perform any initialization tasks for Form2 asynchronously
                await Task.Delay(500); // Delay for 500 milliseconds (0.5 seconds)
                form3.Show(); // Show Form2
            };
            form3.Owner = this;
            form3.ShowInTaskbar = false;

            form3.Activated += (s, ev) =>
            {
                Form2 form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
                if (form != null)
                {
                    form.TopMost = true; // Set Form1 to be always on top of other controls when Form2 is activated
                }
            };

            // Form2 Deactivate event handler
            form3.Deactivate += (s, ev) =>
            {
                Form2 form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
                if (form != null)
                {
                    form.TopMost = false; // Set Form1 back to normal when Form2 is deactivated
                }
            };
            form3.Show();


            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual; // Set the position of Form1 manually
            form2.Owner = this;
            form2.Location = new Point(form3.Left + 300, form3.Top + 150); // Set the position of Form1 relative to Form2
            form2.Load += async (s, ev) =>
            {
                // Perform any initialization tasks for Form1 asynchronously
                await Task.Delay(500); // Delay for 500 milliseconds (0.5 seconds)
                form2.Show(); // Show Form1
            };
            form2.ShowInTaskbar = false;
            form2.FormClosed += (s, args) =>
            {
                // Close Form2 when Form1 is closed
                form3.Close();
            };

            form2.Show();
        }

        private void Guna2CircleButton2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // MessageBox.Show("Closing cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
          /*  loginform loginform = new loginform();
            loginform.Show();
            this.Close();
            */
        }
        private void UserControl61_Load(object sender, EventArgs e)
        {

        }
    }
    }

