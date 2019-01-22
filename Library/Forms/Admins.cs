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
using Library.Models;

namespace Library.Forms
{
    public partial class Admins : MetroForm
    {
        private readonly LibraryEntities2 db = new LibraryEntities2();
        private int SelectedId;
        public Admins()
        {
            InitializeComponent();
            FillData();


        }
      
      
        //textbox'ların təmizlənməsi
        private void Reset()
        {
            txtLogname.ResetText();
            txtName.ResetText();
            txtPass.ResetText();
            
        }
        //cədvəldən məlumatların çıxarılması
        private void FillData()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Admins.ToList())
            {
                dataGridView1.Rows.Add(item.Id, item.ASurname + " " + item.AName, item.ALogName, item.Password);
            }
        }
        //axtaarışın aparılması
        private void txtSearh_Click(object sender, EventArgs e)
        {
            txtSearh.ResetText();
            FillData();
            
        }
        //cədvəldən məlumatın seçilməsi
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedId =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtLogname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnAdd.Visible = false;
            btnDel.Visible = true;
            btnUpdate.Visible = true;
            lblBack.Visible = true;


        }
        //adminin silinməsi
        private void btnDel_Click(object sender, EventArgs e)
        {

            DialogResult r = MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                db.Admins.Remove(db.Admins.Find(SelectedId));
                db.SaveChanges();

            }
            Reset();
            btnAdd.Visible = true;
            btnDel.Visible = false;
            btnUpdate.Visible = false;
            FillData();
        }
        //admins cədvəlinin yenilənməsi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Admins.Where(a=>a.Id==SelectedId).ToList())
            {
                item.AName = txtName.Text.Split(' ')[1];
                item.ASurname = txtName.Text.Split(' ')[0];
                item.Password = txtPass.Text;

            }
            db.SaveChanges();
            btnAdd.Visible = true;
            btnDel.Visible = false;
            btnUpdate.Visible = false;
            FillData();
            Reset();
        }
        //axtarışın aparılması
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (db.Admins.Any(u => u.AName.Contains(txtSearh.Text) || u.ASurname.Contains(txtSearh.Text) || u.ALogName.Contains(txtSearh.Text)))
            {
                dataGridView1.Rows.Clear();
                foreach (var item in db.Admins.Where(u => u.AName.Contains(txtSearh.Text) || u.ASurname.Contains(txtSearh.Text) || u.ALogName.Contains(txtSearh.Text)).ToList())
                {
                    dataGridView1.Rows.Add(item.Id, item.ASurname + " " + item.AName, item.ALogName, item.Password);

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //formu əvvəlki vəziyyətə qaytarmaq
        private void Back()
        {
            Reset();
            btnDel.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            lblBack.Visible = false;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Back();
        }
        //adminin əlavə edilməsi

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (db.Admins.Any(a => a.ALogName == txtLogname.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "This admin has already sign uped!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Admin admin = new Admin
            {
                ALogName = txtLogname.Text,
                AName = txtName.Text.Split(' ')[1],
                ASurname = txtName.Text.Split(' ')[0],
                Password = txtPass.Text

            };

            db.Admins.Add(admin);
            db.SaveChanges();
            FillData();
            Reset();

        }
    }
}
