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
            //hansı adminin giriş edildiyinin əsas forma göndərilməsi
            adminId = adminid;
            FillCmbBooks();
            FillCmbUsers();
            CallOrders();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           //kitablar formunun açılması
            Books books = new Books(this);
            books.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
         //istifadəçilərin formunun açılması   
            FUsers user = new FUsers(this);
            user.Show();
            
        }
        //bazadakı kitabların adlarını göstərmək
        public void FillCmbBooks()
        {
            cmbBooks.Items.Clear();
            foreach (var item in db.Books.ToList())
            {
                cmbBooks.Items.Add(item.BookName);
            }
        }
       
        //bazadakı istifadəçi nömrələrini göstərmək
        public void FillCmbUsers()
        {
            cmbUsers.Items.Clear();
            foreach (var item in db.Users.ToList())
            {
                cmbUsers.Items.Add(item.Password);
            }
        }
        //kitab götürmək
        private void btnTake_Click(object sender, EventArgs e)
        {
            //kitabın sayının və isifadəçinin üzvlük nömrəsinin yoxlanılması
            if (db.Users.Any(u => u.Password == cmbUsers.Text) && db.Books.FirstOrDefault(b => b.BookName == cmbBooks.Text).BookCount > 1 && !db.Orders.Any(o => o.User.Password == cmbUsers.Text && o.Book.BookName == cmbBooks.Text && o.Status == true))
            {
                Order order = new Order
                {
                    BookId = db.Books.FirstOrDefault(b => b.BookName == cmbBooks.Text).BookId,
                    UserId = db.Users.FirstOrDefault(u => u.Password == cmbUsers.Text).UserId,
                    StartTime = DateTime.Now,
                    SAdminId = adminId,
                    Status = true
                };
                db.Orders.Add(order);
                db.Books.FirstOrDefault(b => b.BookName == cmbBooks.Text).BookCount = Convert.ToInt32(db.Books.FirstOrDefault(b => b.BookName == cmbBooks.Text).BookCount) - 1;
                db.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Taked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CallOrders();


            }

            else
            {
                MetroFramework.MetroMessageBox.Show(this, "You can't order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (db.Orders.Any(o => o.User.Password == cmbUsers.Text && o.Book.BookName == cmbBooks.Text && o.Status == true))
                {
                    MetroFramework.MetroMessageBox.Show(this, "This book is ordered by this user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                DateTime dateTime = DateTime.Now.AddMonths(-1);
                 if (db.Orders.Any(o => o.User.Password == cmbUsers.Text && o.Status==true && o.StartTime<=dateTime))
                {
                    MetroFramework.MetroMessageBox.Show(this, "This user has debt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                 if (db.Books.FirstOrDefault(b => b.BookName == cmbBooks.Text).BookCount <= 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "This book's count is 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        //kitabın qaytarılması
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //istifadəçi tərəfindən bu kitabın götürülb götürülməməmsinin yoxlanılması
            if (db.Orders.Any(o => o.User.Password == cmbUsers.Text && o.Book.BookName==cmbBooks.Text && o.Status == true))
            {
                db.Orders.FirstOrDefault(o => o.User.Password == cmbUsers.Text && o.Book.BookName == cmbBooks.Text && o.Status==true).EAdminId = adminId;
                db.Orders.FirstOrDefault(o => o.User.Password == cmbUsers.Text && o.Book.BookName == cmbBooks.Text && o.Status == true).EndTime = DateTime.Now;

                if (db.Orders.FirstOrDefault(o => o.User.Password == cmbUsers.Text && o.Book.BookName == cmbBooks.Text && o.Status == true).StartTime.AddMonths(1) < DateTime.Now)
                {
                    db.Orders.FirstOrDefault(o => o.User.Password == cmbUsers.Text && o.Book.BookName == cmbBooks.Text && o.Status == true).PenaltyPrice = Math.Round(Convert.ToDecimal(db.Books.FirstOrDefault(b => b.BookName == cmbBooks.Text).DatePenaltyPrice *Convert.ToDecimal(DateTime.Now.Subtract( db.Orders.FirstOrDefault(o => o.User.Password == cmbUsers.Text && o.Book.BookName == cmbBooks.Text && o.Status == true).StartTime.AddMonths(1)).TotalDays)), 1) ;

                }

                db.Orders.FirstOrDefault(o => o.User.Password == cmbUsers.Text && o.Book.BookName == cmbBooks.Text && o.Status == true).Status = false;

                db.Books.FirstOrDefault(b => b.BookName == cmbBooks.Text).BookCount = Convert.ToInt32(db.Books.FirstOrDefault(b => b.BookName == cmbBooks.Text).BookCount) + 1;
                db.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Returned!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CallOrders();

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void pbAdmins_Click(object sender, EventArgs e)
        {
            //adminlər formunun açılması
            Admins admins = new Admins();
            admins.Show();
        }
        //qaytarılmalı olan kitablara baxmaq üçün olan forma keçid
        private void pbOrders_Click(object sender, EventArgs e)
        {
            B_Orders b_Orders = new B_Orders();
            b_Orders.Show();
        }
        //qaytarılmamış kitablar
        public void CallOrders()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Orders.Where(o=>o.Status==true).ToList())
            {
                dataGridView1.Rows.Add(item.User.Password, item.Book.BookName);
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbUsers.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbBooks.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
        //formu bağladıqda proyektdən çxış edilməsi
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBooks_Click(object sender, EventArgs e)
        {
            //kitablar formunun açılması
            Books books = new Books(this);
            books.Show();
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {
            FUsers fUsers = new FUsers(this);
            fUsers.Show();
        }

        private void lblOrders_Click(object sender, EventArgs e)
        {
            B_Orders b_Orders  = new B_Orders();
            b_Orders.Show();
        }

        private void lblAdmins_Click(object sender, EventArgs e)
        {
            Admins admins = new Admins();
            admins.Show();
        }
    }
}
