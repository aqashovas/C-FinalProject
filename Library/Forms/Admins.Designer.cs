﻿namespace Library.Forms
{
    partial class Admins
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comp = new System.Windows.Forms.Label();
            this.alllabel = new System.Windows.Forms.Label();
            this.speciallabel = new System.Windows.Forms.Label();
            this.numberlabel = new System.Windows.Forms.Label();
            this.uppercaselabel = new System.Windows.Forms.Label();
            this.lowercaselabel = new System.Windows.Forms.Label();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearh = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comp
            // 
            this.comp.AutoSize = true;
            this.comp.ForeColor = System.Drawing.Color.Green;
            this.comp.Location = new System.Drawing.Point(251, 174);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(57, 13);
            this.comp.TabIndex = 22;
            this.comp.Text = "Completed";
            this.comp.Visible = false;
            // 
            // alllabel
            // 
            this.alllabel.AutoSize = true;
            this.alllabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.alllabel.Location = new System.Drawing.Point(278, 174);
            this.alllabel.Name = "alllabel";
            this.alllabel.Size = new System.Drawing.Size(104, 13);
            this.alllabel.TabIndex = 21;
            this.alllabel.Text = "6 character minimum";
            // 
            // speciallabel
            // 
            this.speciallabel.AutoSize = true;
            this.speciallabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.speciallabel.Location = new System.Drawing.Point(197, 198);
            this.speciallabel.Name = "speciallabel";
            this.speciallabel.Size = new System.Drawing.Size(111, 13);
            this.speciallabel.TabIndex = 20;
            this.speciallabel.Text = "One special character";
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numberlabel.Location = new System.Drawing.Point(197, 174);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(65, 13);
            this.numberlabel.TabIndex = 19;
            this.numberlabel.Text = "One number";
            // 
            // uppercaselabel
            // 
            this.uppercaselabel.AutoSize = true;
            this.uppercaselabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uppercaselabel.Location = new System.Drawing.Point(66, 198);
            this.uppercaselabel.Name = "uppercaselabel";
            this.uppercaselabel.Size = new System.Drawing.Size(128, 13);
            this.uppercaselabel.TabIndex = 18;
            this.uppercaselabel.Text = "One uppercase character";
            // 
            // lowercaselabel
            // 
            this.lowercaselabel.AutoSize = true;
            this.lowercaselabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lowercaselabel.Location = new System.Drawing.Point(66, 174);
            this.lowercaselabel.Name = "lowercaselabel";
            this.lowercaselabel.Size = new System.Drawing.Size(126, 13);
            this.lowercaselabel.TabIndex = 17;
            this.lowercaselabel.Text = "One lowercase character";
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(167, 127);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(141, 23);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(69, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "User Number";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fullname";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(560, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(911, 636);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(233, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.UseStyleColors = true;
            this.btnUpdate.UseWaitCursor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(152, 228);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete";
            this.btnDel.UseCustomBackColor = true;
            this.btnDel.UseCustomForeColor = true;
            this.btnDel.UseSelectable = true;
            this.btnDel.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(233, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(167, 88);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(141, 23);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.comp);
            this.grpUsers.Controls.Add(this.alllabel);
            this.grpUsers.Controls.Add(this.speciallabel);
            this.grpUsers.Controls.Add(this.numberlabel);
            this.grpUsers.Controls.Add(this.uppercaselabel);
            this.grpUsers.Controls.Add(this.lowercaselabel);
            this.grpUsers.Controls.Add(this.txtPass);
            this.grpUsers.Controls.Add(this.metroLabel3);
            this.grpUsers.Controls.Add(this.btnUpdate);
            this.grpUsers.Controls.Add(this.btnDel);
            this.grpUsers.Controls.Add(this.btnAdd);
            this.grpUsers.Controls.Add(this.txtName);
            this.grpUsers.Controls.Add(this.metroLabel1);
            this.grpUsers.Location = new System.Drawing.Point(64, 210);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(417, 339);
            this.grpUsers.TabIndex = 11;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Admins";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(69, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Fullname";
            // 
            // txtSearh
            // 
            // 
            // 
            // 
            this.txtSearh.CustomButton.Image = null;
            this.txtSearh.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtSearh.CustomButton.Name = "";
            this.txtSearh.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearh.CustomButton.TabIndex = 1;
            this.txtSearh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearh.CustomButton.UseSelectable = true;
            this.txtSearh.CustomButton.Visible = false;
            this.txtSearh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearh.Lines = new string[] {
        "search by name..."};
            this.txtSearh.Location = new System.Drawing.Point(64, 142);
            this.txtSearh.MaxLength = 32767;
            this.txtSearh.Name = "txtSearh";
            this.txtSearh.PasswordChar = '\0';
            this.txtSearh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearh.SelectedText = "";
            this.txtSearh.SelectionLength = 0;
            this.txtSearh.SelectionStart = 0;
            this.txtSearh.ShortcutsEnabled = true;
            this.txtSearh.Size = new System.Drawing.Size(329, 23);
            this.txtSearh.TabIndex = 13;
            this.txtSearh.Text = "search by name...";
            this.txtSearh.UseCustomBackColor = true;
            this.txtSearh.UseCustomForeColor = true;
            this.txtSearh.UseSelectable = true;
            this.txtSearh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Library.Properties.Resources._2335590_48;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1533, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.Admin_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(120, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Library.Properties.Resources.iconfinder_xmag_8826__1_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(399, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseSelectable = true;
            // 
            // Admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpUsers);
            this.Controls.Add(this.txtSearh);
            this.Name = "Admins";
            this.Text = "Admins";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label comp;
        private System.Windows.Forms.Label alllabel;
        private System.Windows.Forms.Label speciallabel;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.Label uppercaselabel;
        private System.Windows.Forms.Label lowercaselabel;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.GroupBox grpUsers;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearh;
    }
}