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
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmins)).BeginInit();
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 920);
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
    }
}