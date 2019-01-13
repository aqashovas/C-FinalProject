using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using Library.Models;

namespace Library.Forms
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books books = new Books();
            books.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUsers user = new FUsers();
            user.Show();
            
        }
    }
}
