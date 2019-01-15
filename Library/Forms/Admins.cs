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
        private readonly LibraryEntities db = new LibraryEntities();
        private int SelectedId;
        public Admins()
        {
            InitializeComponent();


        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            char[] txtarray = txtPass.Text.ToCharArray();
            foreach (char i in txtarray)
            {


                if (char.IsDigit(i))
                {
                    numberlabel.ForeColor = Color.Blue;
                }
                else if (char.IsLower(i))
                {
                    lowercaselabel.ForeColor = Color.Blue;
                }
                else if (char.IsUpper(i))
                {
                    uppercaselabel.ForeColor = Color.Blue;
                }
                else
                {
                    speciallabel.ForeColor = Color.Blue;
                }

                if (txtarray.Length >= 6 && speciallabel.ForeColor == Color.Blue && uppercaselabel.ForeColor == Color.Blue && lowercaselabel.ForeColor == Color.Blue && numberlabel.ForeColor == Color.Blue)
                {
                    comp.Visible = true;
                    uppercaselabel.Visible = false;
                    lowercaselabel.Visible = false;
                    speciallabel.Visible = false;
                    numberlabel.Visible = false;
                    alllabel.Visible = false;
                }


            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (db.Admins.Any(a => a.ALogName == txtLogname.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "This admin has already sign uped!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Admin admin = new Admin
                {
                    ALogName = txtLogname.Text,
                    AName = txtName.Text.Split(' ')[1],
                    ASurname = txtName.Text.Split(' ')[0],
                    
                };
                if (comp.Visible == true)
                {
                    admin.Password = txtPass.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please,choose correct password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                db.Admins.Add(admin);
                db.SaveChanges();
                FillData();
                Reset();
            }
        }

        private void Reset()
        {
            txtLogname.ResetText();
            txtName.ResetText();
            txtPass.ResetText();
            
        }
        private void FillData()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Admins.ToList())
            {
                dataGridView1.Rows.Add(item.Id, item.ASurname + " " + item.AName, item.ALogName, item.Password);
            }
        }
        private void txtSearh_Click(object sender, EventArgs e)
        {
            txtSearh.ResetText();
            FillData();
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedId =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtLogname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnAdd.Visible = false;
            btnDel.Visible = true;
            btnUpdate.Visible = true;


        }

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
    }
}
