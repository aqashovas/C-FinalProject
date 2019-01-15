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
    public partial class FUsers : MetroForm
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int SelectedId;
        public FUsers()
        {
            InitializeComponent();
            FillData();
            this.Style = MetroFramework.MetroColorStyle.Orange;
        }
   
      
        //axtarış üçün olan sahəyə kliklədikdə içindəki mətnin silinməsi və yenidən bütün məlumatların çağırılması
        private void txtSearh_Click(object sender, EventArgs e)
        {
            txtSearh.ResetText();
            FillData();

        }
        //istifadəçi haqqında məlumatların çıxarılması
        private void FillData()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Users.ToList())
            {
                dataGridView1.Rows.Add(item.UserId, item.USurname +" " + item.UName, item.Phone,item.Password);
            }

        }
        //istifadəçinin əlavə edilməsi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            char[] txtarray = txtPhone.Text.ToCharArray();
           
            User user = new User
            {
                UName = txtName.Text.Split(' ')[1],
                USurname = txtName.Text.Split(' ')[0],
                
            };
            foreach (char i in txtarray)
            {
                if (char.IsDigit(i))
                {
                    user.Phone = txtPhone.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "This is not a digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            string minute = Convert.ToString(DateTime.Now.Millisecond).Substring(0, 1);
            Random rnd = new Random();
            int numb = rnd.Next(100000000, 999999999);
            string a = Convert.ToString(numb % 10);
            string b = Convert.ToString((numb % 100) / 10);
            string ab = txtPhone.Text;
            string id = Convert.ToInt32(db.Users.Count() % 10).ToString();
            string abc = ab.Substring(4, 2);
            string totalNumber = abc + a + b + minute + id;

 if (db.Users.Any(u => u.Phone == txtPhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "This user has already sign uped!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
            if (db.Users.Any(u => u.Password == txtPhone.Text))
            {
                user.Password =(Convert.ToInt32(totalNumber)-1).ToString();
            }
            else
            {
               
                user.Password = totalNumber;
            }
            db.Users.Add(user);
            db.SaveChanges();}
            FillData();
            Reset();
          
           
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedId =Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnAdd.Visible = false;
            btnDel.Visible = true;
            btnUpdate.Visible = true;
        }
        private void Reset()
        {
            txtName.ResetText();
            txtPhone.ResetText();
       
        }
        //istifadəçinin silinməsi
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                db.Users.Remove(db.Users.Find(SelectedId));
                db.SaveChanges();

            }
            Reset();
            btnAdd.Visible = true;
            btnDel.Visible = false;
            btnUpdate.Visible = false;
            FillData();
        }
        //istifadəçinin yenilənməsi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            char[] txtarray = txtPhone.Text.ToCharArray();
            foreach (char i in txtarray)
            {
                if (char.IsDigit(i))
                {
                    foreach (var item in db.Users.Where(u => u.UserId == SelectedId))
                    {
                        item.UName = txtName.Text.Split(' ')[1];
                        item.USurname = txtName.Text.Split(' ')[0];
                        item.Phone = txtPhone.Text;

                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "This is not a digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            db.SaveChanges();
            btnAdd.Visible = true;
            btnDel.Visible = false;
            btnUpdate.Visible = false;
            FillData();
            Reset();

        }
        //axtarış
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(db.Users.Any(u => u.UName.Contains(txtSearh.Text) || u.USurname.Contains(txtSearh.Text)))
            {
                dataGridView1.Rows.Clear();
                foreach (var item in db.Users.Where(u => u.UName.Contains(txtSearh.Text) || u.USurname.Contains(txtSearh.Text)).ToList())
                {
                    dataGridView1.Rows.Add(item.UserId, item.USurname + " " + item.UName, item.Password);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

      
    }
}
