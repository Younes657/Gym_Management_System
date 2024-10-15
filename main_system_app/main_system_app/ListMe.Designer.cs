using System.Runtime.InteropServices;

namespace main_system_app
{
    partial class ListMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnExit = new System.Windows.Forms.Button();
            this.table_Member = new Guna.UI2.WinForms.Guna2DataGridView();
            this.refrech = new Guna.UI2.WinForms.Guna2GradientButton();
            this.searchLIST = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(1782, 10);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 31);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // table_Member
            // 
            this.table_Member.AllowUserToAddRows = false;
            this.table_Member.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.table_Member.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_Member.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Member.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_Member.ColumnHeadersHeight = 28;
            this.table_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_Member.DefaultCellStyle = dataGridViewCellStyle3;
            this.table_Member.GridColor = System.Drawing.Color.DimGray;
            this.table_Member.Location = new System.Drawing.Point(38, 125);
            this.table_Member.Name = "table_Member";
            this.table_Member.ReadOnly = true;
            this.table_Member.RowHeadersVisible = false;
            this.table_Member.RowHeadersWidth = 62;
            this.table_Member.RowTemplate.Height = 28;
            this.table_Member.Size = new System.Drawing.Size(1734, 754);
            this.table_Member.TabIndex = 160;
            this.table_Member.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.table_Member.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_Member.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.table_Member.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table_Member.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table_Member.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.table_Member.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.table_Member.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.table_Member.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table_Member.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_Member.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table_Member.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table_Member.ThemeStyle.HeaderStyle.Height = 28;
            this.table_Member.ThemeStyle.ReadOnly = true;
            this.table_Member.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.table_Member.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_Member.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_Member.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.table_Member.ThemeStyle.RowsStyle.Height = 28;
            this.table_Member.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.table_Member.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            // 
            // refrech
            // 
            this.refrech.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(61)))));
            this.refrech.BorderRadius = 5;
            this.refrech.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refrech.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refrech.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refrech.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refrech.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refrech.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.refrech.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.refrech.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refrech.ForeColor = System.Drawing.Color.White;
            this.refrech.Location = new System.Drawing.Point(1113, 39);
            this.refrech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refrech.Name = "refrech";
            this.refrech.Size = new System.Drawing.Size(162, 62);
            this.refrech.TabIndex = 161;
            this.refrech.Text = "Refrech";
            this.refrech.Click += new System.EventHandler(this.refrech_Click);
            // 
            // searchLIST
            // 
            this.searchLIST.BorderThickness = 2;
            this.searchLIST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchLIST.DefaultText = "";
            this.searchLIST.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchLIST.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchLIST.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchLIST.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchLIST.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchLIST.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(64)))));
            this.searchLIST.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.searchLIST.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchLIST.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.searchLIST.Location = new System.Drawing.Point(206, 52);
            this.searchLIST.Margin = new System.Windows.Forms.Padding(8);
            this.searchLIST.Name = "searchLIST";
            this.searchLIST.PasswordChar = '\0';
            this.searchLIST.PlaceholderText = "Search by first name or last name ... ";
            this.searchLIST.SelectedText = "";
            this.searchLIST.Size = new System.Drawing.Size(660, 49);
            this.searchLIST.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.searchLIST.TabIndex = 162;
            this.searchLIST.TextOffset = new System.Drawing.Point(6, 0);
            this.searchLIST.TextChanged += new System.EventHandler(this.searchLIST_TextChanged);
            // 
            // ListMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1823, 891);
            this.Controls.Add(this.searchLIST);
            this.Controls.Add(this.refrech);
            this.Controls.Add(this.table_Member);
            this.Controls.Add(this.BtnExit);
            this.MaximizeBox = false;
            this.Name = "ListMe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_Member)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnExit;
        private Guna.UI2.WinForms.Guna2DataGridView table_Member;
        private Guna.UI2.WinForms.Guna2GradientButton refrech;
        private Guna.UI2.WinForms.Guna2TextBox searchLIST;
    }
}