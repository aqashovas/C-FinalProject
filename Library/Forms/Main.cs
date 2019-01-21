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
        private readonly LibraryEntities2 db = new LibraryEntities2();
        public int adminId;
        public Main(int adminid)
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Green;
            adminId = adminid;
            
            
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
        //kitab götürmək
        private void btnTake_Click(object sender, EventArgs e)
        {
            //kitabın sayının və isifadəçinin üzvlük nömrəsinin yoxlanılması
            if (db.Users.Any(u => u.Password == txtUserN.Text)&& db.Books.FirstOrDefault(b=>b.BookName==txtBookName.Text).BookCount>1){
                Order order = new Order
                {
                    BookId = db.Books.FirstOrDefault(b => b.BookName == txtBookName.Text).BookId,
                    UserId = db.Users.FirstOrDefault(u => u.Password == txtUserN.Text).UserId,
                    StartTime = dtStart.Value,
                    SAdminId = adminId,
                    Status = true
                };
                db.Orders.Add(order);
                db.SaveChanges();
            
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "You can't order!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
