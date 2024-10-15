namespace login_form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.textpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelforget = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.textpassword);
            this.panel1.Controls.Add(this.guna2GradientButton1);
            this.panel1.Controls.Add(this.textusername);
            this.panel1.Controls.Add(this.labelforget);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(534, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 660);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::login_form.Properties.Resources.icons8_male_user_50_3_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(206, 23);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(165, 138);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 21;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // textpassword
            // 
            this.textpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textpassword.DefaultText = "Password";
            this.textpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textpassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textpassword.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.textpassword.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textpassword.HoverState.BorderColor = System.Drawing.Color.Black;
            this.textpassword.IconLeft = global::login_form.Properties.Resources.icons8_lock_30;
            this.textpassword.IconRight = global::login_form.Properties.Resources.show;
            this.textpassword.Location = new System.Drawing.Point(70, 375);
            this.textpassword.Margin = new System.Windows.Forms.Padding(6);
            this.textpassword.Name = "textpassword";
            this.textpassword.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.textpassword.PasswordChar = '\0';
            this.textpassword.PlaceholderText = "";
            this.textpassword.SelectedText = "";
            this.textpassword.Size = new System.Drawing.Size(416, 83);
            this.textpassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textpassword.TabIndex = 24;
            this.textpassword.IconRightClick += new System.EventHandler(this.Textpassword_IconRightClick);
            this.textpassword.Enter += new System.EventHandler(this.Textpassword_Enter);
            this.textpassword.Leave += new System.EventHandler(this.Textpassword_Leave);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.DimGray;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(158, 543);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2GradientButton1.Size = new System.Drawing.Size(240, 68);
            this.guna2GradientButton1.TabIndex = 22;
            this.guna2GradientButton1.Text = "Login";
            this.guna2GradientButton1.Click += new System.EventHandler(this.Guna2GradientButton1_Click);
            // 
            // textusername
            // 
            this.textusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textusername.DefaultText = "Username";
            this.textusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textusername.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textusername.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.textusername.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.textusername.ForeColor = System.Drawing.Color.DarkGray;
            this.textusername.HoverState.BorderColor = System.Drawing.Color.Black;
            this.textusername.IconLeft = global::login_form.Properties.Resources.icons8_user_30;
            this.textusername.Location = new System.Drawing.Point(70, 248);
            this.textusername.Margin = new System.Windows.Forms.Padding(6);
            this.textusername.Name = "textusername";
            this.textusername.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.textusername.PasswordChar = '\0';
            this.textusername.PlaceholderText = "";
            this.textusername.SelectedText = "";
            this.textusername.Size = new System.Drawing.Size(416, 83);
            this.textusername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textusername.TabIndex = 23;
            this.textusername.Enter += new System.EventHandler(this.Textusername_Enter);
            this.textusername.Leave += new System.EventHandler(this.Textusername_Leave);
            // 
            // labelforget
            // 
            this.labelforget.BackColor = System.Drawing.Color.Transparent;
            this.labelforget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforget.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelforget.Location = new System.Drawing.Point(84, 485);
            this.labelforget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelforget.Name = "labelforget";
            this.labelforget.Size = new System.Drawing.Size(166, 27);
            this.labelforget.TabIndex = 23;
            this.labelforget.Text = "Forget Password ?";
            this.labelforget.Click += new System.EventHandler(this.labelforget_Click);
            this.labelforget.MouseEnter += new System.EventHandler(this.Labelforget_MouseEnter);
            this.labelforget.MouseLeave += new System.EventHandler(this.Labelforget_MouseLeave);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(322, 482);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(166, 29);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Remember Me";
            this.checkBox2.UseVisualStyleBackColor = false;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(207, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 60);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::login_form.Properties.Resources.FB_IMG_1678020118035_removebg_preview_1_;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(-6, 115);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(423, 395);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 14;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1110, 9);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 35);
            this.guna2ControlBox2.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login_form.Properties.Resources._101_single_default;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 731);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textpassword;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox textusername;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelforget;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

