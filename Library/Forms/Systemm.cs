using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using Library.Models;

namespace Library
{
    public partial class Form1 : MetroForm
    {
        //bazanın çağırılması
        private readonly LibraryEntities db = new LibraryEntities();
        public Form1()
        {
            InitializeComponent();
            //formun başlıq rənginin dəyişdirilməasi
            this.Style = MetroFramework.MetroColorStyle.Black;
        }

        
        //Sistemə daxil olan adminin yoxlanılması
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtPass.Text))){
                foreach (var item in db.Admins.ToList())
                {
                    if (txtName.Text == item.ALogName && txtPass.Text == item.Password)
                    {
                        MessageBox.Show("Ok");
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Username or password are is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Do not leave empty space!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
