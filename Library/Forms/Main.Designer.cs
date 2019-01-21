namespace Library.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pbOrders = new System.Windows.Forms.PictureBox();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.pbBoooks = new System.Windows.Forms.PictureBox();
            this.pbAdmins = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.grpTake = new System.Windows.Forms.GroupBox();
            this.btnTake = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtUserN = new MetroFramework.Controls.MetroTextBox();
            this.txtBookName = new MetroFramework.Controls.MetroTextBox();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmins)).BeginInit();
            this.grpTake.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.metroLabel1.Location = new System.Drawing.Point(32, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Books";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.LimeGreen;
            this.metroLabel2.Location = new System.Drawing.Point(120, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Users";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.LimeGreen;
            this.metroLabel3.Location = new System.Drawing.Point(205, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Orders";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // pbOrders
            // 
            this.pbOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOrders.BackgroundImage")));
            this.pbOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOrders.Location = new System.Drawing.Point(200, 37);
            this.pbOrders.Name = "pbOrders";
            this.pbOrders.Size = new System.Drawing.Size(64, 64);
            this.pbOrders.TabIndex = 6;
            this.pbOrders.TabStop = false;
            // 
            // pbUsers
            // 
            this.pbUsers.BackgroundImage = global::Library.Properties.Resources.iconfinder_users_40978;
            this.pbUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsers.Location = new System.Drawing.Point(111, 37);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(64, 64);
            this.pbUsers.TabIndex = 4;
            this.pbUsers.TabStop = false;
            this.pbUsers.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbBoooks
            // 
            this.pbBoooks.BackgroundImage = global::Library.Properties.Resources.iconfinder_bookcase_1228__1_;
            this.pbBoooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBoooks.Location = new System.Drawing.Point(23, 37);
            this.pbBoooks.Name = "pbBoooks";
            this.pbBoooks.Size = new System.Drawing.Size(64, 64);
            this.pbBoooks.TabIndex = 2;
            this.pbBoooks.TabStop = false;
            this.pbBoooks.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbAdmins
            // 
            this.pbAdmins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdmins.BackgroundImage")));
            this.pbAdmins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdmins.Location = new System.Drawing.Point(289, 37);
            this.pbAdmins.Name = "pbAdmins";
            this.pbAdmins.Size = new System.Drawing.Size(64, 64);
            this.pbAdmins.TabIndex = 8;
            this.pbAdmins.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.LimeGreen;
            this.metroLabel4.Location = new System.Drawing.Point(289, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Admins";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // grpTake
            // 
            this.grpTake.Controls.Add(this.dtStart);
            this.grpTake.Controls.Add(this.txtBookName);
            this.grpTake.Controls.Add(this.txtUserN);
            this.grpTake.Controls.Add(this.metroLabel7);
            this.grpTake.Controls.Add(this.metroLabel6);
            this.grpTake.Controls.Add(this.metroLabel5);
            this.grpTake.Controls.Add(this.btnTake);
            this.grpTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpTake.Location = new System.Drawing.Point(111, 157);
            this.grpTake.Name = "grpTake";
            this.grpTake.Size = new System.Drawing.Size(311, 277);
            this.grpTake.TabIndex = 9;
            this.grpTake.TabStop = false;
            this.grpTake.Text = "Get Book";
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTake.Location = new System.Drawing.Point(184, 207);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 23);
            this.btnTake.TabIndex = 0;
            this.btnTake.Text = "Take";
            this.btnTake.UseCustomBackColor = true;
            this.btnTake.UseCustomForeColor = true;
            this.btnTake.UseSelectable = true;
            this.btnTake.UseStyleColors = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroLabel5.Location = new System.Drawing.Point(40, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "UserNumber";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroLabel6.Location = new System.Drawing.Point(40, 109);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Book  Name";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroLabel7.Location = new System.Drawing.Point(40, 143);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Date Time";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // txtUserN
            // 
            // 
            // 
            // 
            this.txtUserN.CustomButton.Image = null;
            this.txtUserN.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtUserN.CustomButton.Name = "";
            this.txtUserN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserN.CustomButton.TabIndex = 1;
            this.txtUserN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserN.CustomButton.UseSelectable = true;
            this.txtUserN.CustomButton.Visible = false;
            this.txtUserN.Lines = new string[0];
            this.txtUserN.Location = new System.Drawing.Point(127, 72);
            this.txtUserN.MaxLength = 32767;
            this.txtUserN.Name = "txtUserN";
            this.txtUserN.PasswordChar = '\0';
            this.txtUserN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserN.SelectedText = "";
            this.txtUserN.SelectionLength = 0;
            this.txtUserN.SelectionStart = 0;
            this.txtUserN.ShortcutsEnabled = true;
            this.txtUserN.Size = new System.Drawing.Size(132, 23);
            this.txtUserN.TabIndex = 4;
            this.txtUserN.UseSelectable = true;
            this.txtUserN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBookName
            // 
            // 
            // 
            // 
            this.txtBookName.CustomButton.Image = null;
            this.txtBookName.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtBookName.CustomButton.Name = "";
            this.txtBookName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookName.CustomButton.TabIndex = 1;
            this.txtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookName.CustomButton.UseSelectable = true;
            this.txtBookName.CustomButton.Visible = false;
            this.txtBookName.Lines = new string[0];
            this.txtBookName.Location = new System.Drawing.Point(127, 109);
            this.txtBookName.MaxLength = 32767;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookName.SelectedText = "";
            this.txtBookName.SelectionLength = 0;
            this.txtBookName.SelectionStart = 0;
            this.txtBookName.ShortcutsEnabled = true;
            this.txtBookName.Size = new System.Drawing.Size(132, 23);
            this.txtBookName.TabIndex = 5;
            this.txtBookName.UseSelectable = true;
            this.txtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtStart
            // 
            this.dtStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtStart.Location = new System.Drawing.Point(127, 138);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(132, 29);
            this.dtStart.TabIndex = 6;
            this.dtStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dtStart.UseCustomBackColor = true;
            this.dtStart.UseCustomForeColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.grpTake);
            this.Controls.Add(this.pbAdmins);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.pbOrders);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pbBoooks);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmins)).EndInit();
            this.grpTake.ResumeLayout(false);
            this.grpTake.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pbBoooks;
        private System.Windows.Forms.PictureBox pbUsers;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pbOrders;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pbAdmins;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox grpTake;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroTextBox txtBookName;
        private MetroFramework.Controls.MetroTextBox txtUserN;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnTake;
    }
}