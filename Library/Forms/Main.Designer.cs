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
            this.lblBooks = new MetroFramework.Controls.MetroLabel();
            this.lblUsers = new MetroFramework.Controls.MetroLabel();
            this.lblOrders = new MetroFramework.Controls.MetroLabel();
            this.lblAdmins = new MetroFramework.Controls.MetroLabel();
            this.grpTake = new System.Windows.Forms.GroupBox();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.cmbUsers = new MetroFramework.Controls.MetroComboBox();
            this.cmbBooks = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnTake = new MetroFramework.Controls.MetroButton();
            this.pbAdmins = new System.Windows.Forms.PictureBox();
            this.pbOrders = new System.Windows.Forms.PictureBox();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.pbBoooks = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBooks.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblBooks.Location = new System.Drawing.Point(32, 104);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(50, 19);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "Books";
            this.lblBooks.UseCustomBackColor = true;
            this.lblBooks.UseCustomForeColor = true;
            this.lblBooks.Click += new System.EventHandler(this.lblBooks_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsers.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblUsers.Location = new System.Drawing.Point(120, 104);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(45, 19);
            this.lblUsers.TabIndex = 3;
            this.lblUsers.Text = "Users";
            this.lblUsers.UseCustomBackColor = true;
            this.lblUsers.UseCustomForeColor = true;
            this.lblUsers.Click += new System.EventHandler(this.lblUsers_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOrders.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblOrders.Location = new System.Drawing.Point(205, 104);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(55, 19);
            this.lblOrders.TabIndex = 5;
            this.lblOrders.Text = "Orders";
            this.lblOrders.UseCustomBackColor = true;
            this.lblOrders.UseCustomForeColor = true;
            this.lblOrders.Click += new System.EventHandler(this.lblOrders_Click);
            // 
            // lblAdmins
            // 
            this.lblAdmins.AutoSize = true;
            this.lblAdmins.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAdmins.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAdmins.Location = new System.Drawing.Point(289, 104);
            this.lblAdmins.Name = "lblAdmins";
            this.lblAdmins.Size = new System.Drawing.Size(59, 19);
            this.lblAdmins.TabIndex = 7;
            this.lblAdmins.Text = "Admins";
            this.lblAdmins.UseCustomBackColor = true;
            this.lblAdmins.UseCustomForeColor = true;
            this.lblAdmins.Click += new System.EventHandler(this.lblAdmins_Click);
            // 
            // grpTake
            // 
            this.grpTake.Controls.Add(this.btnReturn);
            this.grpTake.Controls.Add(this.cmbUsers);
            this.grpTake.Controls.Add(this.cmbBooks);
            this.grpTake.Controls.Add(this.metroLabel6);
            this.grpTake.Controls.Add(this.metroLabel5);
            this.grpTake.Controls.Add(this.btnTake);
            this.grpTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpTake.Location = new System.Drawing.Point(120, 167);
            this.grpTake.Name = "grpTake";
            this.grpTake.Size = new System.Drawing.Size(408, 277);
            this.grpTake.TabIndex = 9;
            this.grpTake.TabStop = false;
            this.grpTake.Text = "Order";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(278, 185);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseCustomBackColor = true;
            this.btnReturn.UseCustomForeColor = true;
            this.btnReturn.UseSelectable = true;
            this.btnReturn.UseStyleColors = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.ItemHeight = 23;
            this.cmbUsers.Location = new System.Drawing.Point(129, 68);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(224, 29);
            this.cmbUsers.TabIndex = 8;
            this.cmbUsers.UseSelectable = true;
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.ItemHeight = 23;
            this.cmbBooks.Location = new System.Drawing.Point(129, 103);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(224, 29);
            this.cmbBooks.TabIndex = 7;
            this.cmbBooks.UseSelectable = true;
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
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTake.ForeColor = System.Drawing.Color.White;
            this.btnTake.Location = new System.Drawing.Point(278, 156);
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
            // pbAdmins
            // 
            this.pbAdmins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdmins.BackgroundImage")));
            this.pbAdmins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdmins.Location = new System.Drawing.Point(289, 37);
            this.pbAdmins.Name = "pbAdmins";
            this.pbAdmins.Size = new System.Drawing.Size(64, 64);
            this.pbAdmins.TabIndex = 8;
            this.pbAdmins.TabStop = false;
            this.pbAdmins.Click += new System.EventHandler(this.pbAdmins_Click);
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
            this.pbOrders.Click += new System.EventHandler(this.pbOrders_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(557, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 277);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waiting";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(41, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(318, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UserNumber";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Name";
            this.Column2.Name = "Column2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTake);
            this.Controls.Add(this.pbAdmins);
            this.Controls.Add(this.lblAdmins);
            this.Controls.Add(this.pbOrders);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.pbBoooks);
            this.Controls.Add(this.lblBooks);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.grpTake.ResumeLayout(false);
            this.grpTake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblBooks;
        private System.Windows.Forms.PictureBox pbBoooks;
        private System.Windows.Forms.PictureBox pbUsers;
        private MetroFramework.Controls.MetroLabel lblUsers;
        private System.Windows.Forms.PictureBox pbOrders;
        private MetroFramework.Controls.MetroLabel lblOrders;
        private System.Windows.Forms.PictureBox pbAdmins;
        private MetroFramework.Controls.MetroLabel lblAdmins;
        private System.Windows.Forms.GroupBox grpTake;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnTake;
        private MetroFramework.Controls.MetroComboBox cmbBooks;
        private MetroFramework.Controls.MetroComboBox cmbUsers;
        private MetroFramework.Controls.MetroButton btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}