namespace Library.Forms
{
    partial class B_Orders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearh = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(82, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Call this user";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Delay Time";
            this.Column3.Name = "Column3";
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
        "search by book name..."};
            this.txtSearh.Location = new System.Drawing.Point(82, 81);
            this.txtSearh.MaxLength = 32767;
            this.txtSearh.Name = "txtSearh";
            this.txtSearh.PasswordChar = '\0';
            this.txtSearh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearh.SelectedText = "";
            this.txtSearh.SelectionLength = 0;
            this.txtSearh.SelectionStart = 0;
            this.txtSearh.ShortcutsEnabled = true;
            this.txtSearh.Size = new System.Drawing.Size(329, 23);
            this.txtSearh.TabIndex = 5;
            this.txtSearh.Text = "search by book name...";
            this.txtSearh.UseCustomBackColor = true;
            this.txtSearh.UseCustomForeColor = true;
            this.txtSearh.UseSelectable = true;
            this.txtSearh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearh.Click += new System.EventHandler(this.txtSearh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Library.Properties.Resources.iconfinder_xmag_8826__1_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(417, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // B_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.txtSearh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "B_Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MetroFramework.Controls.MetroTextBox txtSearh;
        private MetroFramework.Controls.MetroButton btnSearch;
    }
}