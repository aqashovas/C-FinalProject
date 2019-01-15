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
    public partial class Books : MetroForm
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int SelectedId;
        public Books()
        {
            InitializeComponent();
           
            FillData();
        }
        //yeni kitab əlavə edilməsi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                BookName = txtName.Text,
                BookCount =Convert.ToInt32(numCount.Value),
                DatePenaltyPrice=Math.Round(Convert.ToDecimal(txtPrice.Text),1)
            };
            db.Books.Add(book);
            db.SaveChanges();
            Reset();
            FillData();

        }
        //məlumatların çağırılmsı
        private void FillData()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Books.ToList())
            {
                dataGridView1.Rows.Add(item.BookId, item.BookName, item.BookCount, item.DatePenaltyPrice);
            }
        }
        //Mətlərin təmizlənməsi
        private void Reset()
        {
            txtName.ResetText();
            txtPrice.ResetText();
            numCount.ResetText();
        }
        //seçilmiş kitabın silinməsi
        private void btnDel_Click(object sender, EventArgs e)
        {
         DialogResult r=MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                db.Books.Remove(db.Books.Find(SelectedId));
                db.SaveChanges();
              
            }
            Reset();
            btnAdd.Visible = true;
            btnDel.Visible = false;
            btnUpdate.Visible = false;
            FillData();
        }
        //seçilən sıranın konfiqurasiya bölməsinə köçürülməsi
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numCount.Value =Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnAdd.Visible = false;
            btnDel.Visible = true;
            btnUpdate.Visible = true;
        }
        //seçilmiş kitabın yebilənməsi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Books.Where(b=>b.BookId==SelectedId).ToList())
            {
                item.BookName = txtName.Text;
                item.BookCount =Convert.ToInt32( numCount.Value);
                item.DatePenaltyPrice=Convert.ToDecimal(txtPrice.Text);

            }
            db.SaveChanges();
            Reset();
            btnAdd.Visible = true;
            btnDel.Visible = false;
            btnUpdate.Visible = false;
            FillData();

        }

        private void txtSearh_Click(object sender, EventArgs e)
        {
            txtSearh.ResetText();
            FillData();
            
        }
        //kitabın adına görə axtarış
        private void btnSearch_Click(object sender, EventArgs e)
        {
         
                dataGridView1.Rows.Clear();
                foreach (var item in db.Books.Where(b => b.BookName.Contains(txtSearh.Text)).ToList())
                {
                    dataGridView1.Rows.Add(item.BookId, item.BookName, item.BookCount, item.DatePenaltyPrice);
                }
            

            if (db.Books.Any(b => b.BookName.Contains(txtSearh.Text)))
            {
                MetroFramework.MetroMessageBox.Show(this, "Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        //əsas forma keçid 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
