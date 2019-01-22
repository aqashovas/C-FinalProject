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
        private readonly LibraryEntities2 db = new LibraryEntities2();
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
                
                    if ( db.Admins.Any(a=>a.ALogName== txtName.Text  && a.Password==txtPass.Text))
                    {
                        //adminin id -sinin əsas forma göndərilməsi
                        int adminid = db.Admins.FirstOrDefault(a => a.ALogName == txtName.Text).Id;

                    ////əsas formun açılması
                    Forms.Main main = new Forms.Main(adminid);
                    this.Hide();
                        main.Show();
                        

                    }
                    else 
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Username or password are is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Do not leave empty space!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            txtPass.PasswordChar ='\0';
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            txtPass.PasswordChar = '●';
        }
    }
}
