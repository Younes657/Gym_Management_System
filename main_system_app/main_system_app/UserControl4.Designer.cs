namespace main_system_app
{
    partial class UserControl4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.renew = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            cid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.age = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.search_btn = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.namef = new Guna.UI2.WinForms.Guna2TextBox();
            this.namel = new Guna.UI2.WinForms.Guna2TextBox();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.delete_all = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PAID = new System.Windows.Forms.CheckBox();
            table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnView = new Guna.UI2.WinForms.Guna2GradientButton();
            this.resetbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(table)).BeginInit();
            this.SuspendLayout();
            // 
            // renew
            // 
            this.renew.BackColor = System.Drawing.Color.Transparent;
            this.renew.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.renew.BorderColor = System.Drawing.Color.Silver;
            this.renew.BorderSize = 1;
            this.renew.CustomFormat = null;
            this.renew.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.renew.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.renew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.renew.ForeColor = System.Drawing.Color.LightGray;
            this.renew.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.renew.Location = new System.Drawing.Point(984, 311);
            this.renew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renew.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.renew.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.renew.Name = "renew";
            this.renew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.renew.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.renew.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.renew.OnPressedColor = System.Drawing.Color.Black;
            this.renew.Radius = 8;
            this.renew.Size = new System.Drawing.Size(168, 52);
            this.renew.TabIndex = 151;
            this.renew.Text = "4/20/2023";
            this.renew.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit;
            this.renew.Value = new System.DateTime(2023, 4, 20, 22, 13, 31, 591);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(978, 268);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 29);
            this.label12.TabIndex = 150;
            this.label12.Text = "renew Date  :";
            // 
            // cid
            // 
            cid.BackColor = System.Drawing.Color.Transparent;
            cid.BorderRadius = 8;
            cid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            cid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            cid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            cid.Font = new System.Drawing.Font("Segoe UI", 10F);
            cid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cid.ItemHeight = 28;
            cid.Location = new System.Drawing.Point(768, 311);
            cid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cid.Name = "cid";
            cid.Size = new System.Drawing.Size(199, 34);
            cid.TabIndex = 149;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(40, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 29);
            this.label5.TabIndex = 146;
            this.label5.Text = "Monthly subscription :";
            // 
            // stp
            // 
            this.stp.BackColor = System.Drawing.Color.Transparent;
            this.stp.BorderRadius = 8;
            this.stp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.stp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.stp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.stp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stp.ItemHeight = 28;
            this.stp.Items.AddRange(new object[] {
            "7/7",
            "3/7"});
            this.stp.Location = new System.Drawing.Point(39, 315);
            this.stp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stp.Name = "stp";
            this.stp.Size = new System.Drawing.Size(318, 34);
            this.stp.StartIndex = 0;
            this.stp.TabIndex = 147;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(762, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 148;
            this.label7.Text = "Coach :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(951, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 29);
            this.label10.TabIndex = 143;
            this.label10.Text = "Age :";
            // 
            // age
            // 
            this.age.BorderRadius = 8;
            this.age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age.DefaultText = "";
            this.age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.age.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.age.Location = new System.Drawing.Point(939, 185);
            this.age.Margin = new System.Windows.Forms.Padding(6);
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.PlaceholderText = "Age";
            this.age.SelectedText = "";
            this.age.Size = new System.Drawing.Size(146, 49);
            this.age.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(40, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 135;
            this.label1.Text = " name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(529, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 136;
            this.label2.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(264, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 137;
            this.label3.Text = "last name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(393, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 138;
            this.label6.Text = "Email : ";
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.BorderRadius = 8;
            this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gender.ItemHeight = 28;
            this.gender.Items.AddRange(new object[] {
            "m",
            "f"});
            this.gender.Location = new System.Drawing.Point(534, 185);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(108, 34);
            this.gender.TabIndex = 142;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(431, 432);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(162, 62);
            this.guna2GradientButton1.TabIndex = 133;
            this.guna2GradientButton1.Text = "Update";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.guna2GradientButton4.BorderRadius = 5;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Location = new System.Drawing.Point(227, 432);
            this.guna2GradientButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(162, 62);
            this.guna2GradientButton4.TabIndex = 132;
            this.guna2GradientButton4.Text = "Delete";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // search_btn
            // 
            this.search_btn.BorderThickness = 2;
            this.search_btn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_btn.DefaultText = "";
            this.search_btn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_btn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_btn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.search_btn.Location = new System.Drawing.Point(237, 526);
            this.search_btn.Margin = new System.Windows.Forms.Padding(8);
            this.search_btn.Name = "search_btn";
            this.search_btn.PasswordChar = '\0';
            this.search_btn.PlaceholderText = "Search by first name or last name ... ";
            this.search_btn.SelectedText = "";
            this.search_btn.Size = new System.Drawing.Size(660, 49);
            this.search_btn.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.search_btn.TabIndex = 131;
            this.search_btn.TextOffset = new System.Drawing.Point(6, 0);
            this.search_btn.TextChanged += new System.EventHandler(this.search_btn_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.panel2.Location = new System.Drawing.Point(40, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 46);
            this.panel2.TabIndex = 130;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(63, 12);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(289, 58);
            this.guna2HtmlLabel1.TabIndex = 129;
            this.guna2HtmlLabel1.Text = "Edit Members";
            // 
            // namef
            // 
            this.namef.BorderRadius = 8;
            this.namef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namef.DefaultText = "";
            this.namef.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.namef.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.namef.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namef.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namef.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.namef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.namef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namef.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.namef.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.namef.IconLeft = global::main_system_app.Properties.Resources.icons8_user_30;
            this.namef.Location = new System.Drawing.Point(46, 185);
            this.namef.Margin = new System.Windows.Forms.Padding(6);
            this.namef.Name = "namef";
            this.namef.PasswordChar = '\0';
            this.namef.PlaceholderText = "Name";
            this.namef.SelectedText = "";
            this.namef.Size = new System.Drawing.Size(173, 49);
            this.namef.TabIndex = 139;
            this.namef.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // namel
            // 
            this.namel.BorderRadius = 8;
            this.namel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namel.DefaultText = "";
            this.namel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.namel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.namel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.namel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.namel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.namel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.namel.IconLeft = global::main_system_app.Properties.Resources.icons8_user_30;
            this.namel.Location = new System.Drawing.Point(258, 185);
            this.namel.Margin = new System.Windows.Forms.Padding(6);
            this.namel.Name = "namel";
            this.namel.PasswordChar = '\0';
            this.namel.PlaceholderText = "Last Name";
            this.namel.SelectedText = "";
            this.namel.Size = new System.Drawing.Size(235, 49);
            this.namel.TabIndex = 140;
            this.namel.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // email
            // 
            this.email.BorderRadius = 8;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.email.IconLeft = global::main_system_app.Properties.Resources.icons8_courrier_301;
            this.email.Location = new System.Drawing.Point(386, 314);
            this.email.Margin = new System.Windows.Forms.Padding(6);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "Email";
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(369, 49);
            this.email.TabIndex = 141;
            this.email.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // delete_all
            // 
            this.delete_all.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.delete_all.BorderRadius = 5;
            this.delete_all.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_all.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_all.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_all.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_all.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_all.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.delete_all.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.delete_all.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_all.ForeColor = System.Drawing.Color.White;
            this.delete_all.Location = new System.Drawing.Point(39, 432);
            this.delete_all.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete_all.Name = "delete_all";
            this.delete_all.Size = new System.Drawing.Size(162, 62);
            this.delete_all.TabIndex = 155;
            this.delete_all.Text = "Delete All";
            this.delete_all.Click += new System.EventHandler(this.delete_all_Click_1);
            // 
            // PAID
            // 
            this.PAID.AutoSize = true;
            this.PAID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PAID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAID.ForeColor = System.Drawing.Color.White;
            this.PAID.Location = new System.Drawing.Point(711, 185);
            this.PAID.Name = "PAID";
            this.PAID.Padding = new System.Windows.Forms.Padding(10);
            this.PAID.Size = new System.Drawing.Size(126, 53);
            this.PAID.TabIndex = 157;
            this.PAID.Text = "Paid ?";
            this.PAID.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            table.ColumnHeadersHeight = 28;
            table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            table.DefaultCellStyle = dataGridViewCellStyle3;
            table.GridColor = System.Drawing.Color.DimGray;
            table.Location = new System.Drawing.Point(97, 646);
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersVisible = false;
            table.RowHeadersWidth = 62;
            table.RowTemplate.Height = 28;
            table.Size = new System.Drawing.Size(1077, 354);
            table.TabIndex = 158;
            table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            table.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            table.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            table.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            table.ThemeStyle.HeaderStyle.Height = 28;
            table.ThemeStyle.ReadOnly = true;
            table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.DimGray;
            table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            table.ThemeStyle.RowsStyle.Height = 28;
            table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(table_CellClick_1);
            // 
            // btnView
            // 
            this.btnView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.btnView.BorderRadius = 5;
            this.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnView.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnView.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(906, 432);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(196, 62);
            this.btnView.TabIndex = 159;
            this.btnView.Text = "View Member";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.resetbtn.BorderRadius = 5;
            this.resetbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.resetbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.resetbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.Color.White;
            this.resetbtn.Location = new System.Drawing.Point(630, 432);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(162, 62);
            this.resetbtn.TabIndex = 160;
            this.resetbtn.Text = "Reset";
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.btnView);
            this.Controls.Add(table);
            this.Controls.Add(this.PAID);
            this.Controls.Add(this.delete_all);
            this.Controls.Add(this.renew);
            this.Controls.Add(this.label12);
            this.Controls.Add(cid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.namef);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(1185, 1014);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            ((System.ComponentModel.ISupportInitialize)(table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDateTimePicker renew;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox stp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox gender;
        private Guna.UI2.WinForms.Guna2TextBox namef;
        private Guna.UI2.WinForms.Guna2TextBox namel;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2TextBox search_btn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton delete_all;
        private System.Windows.Forms.CheckBox PAID;
        private Guna.UI2.WinForms.Guna2GradientButton btnView;
        private Guna.UI2.WinForms.Guna2GradientButton resetbtn;
        public static Guna.UI2.WinForms.Guna2ComboBox cid;
        private static Guna.UI2.WinForms.Guna2DataGridView table;
    }
}
