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
using MetroFramework;
using Library.Models;

namespace Library.Forms
{
    public partial class B_Orders : MetroForm
    {
        private readonly LibraryEntities2 db = new LibraryEntities2();
        private DateTime dateTimenow = DateTime.Now.AddMonths(-1);
        public B_Orders()
        {
            InitializeComponent();
            FillData();
        }
        private void FillData()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Orders.Where(o => o.StartTime < dateTimenow && o.Status == true).ToList())
            {
                dataGridView1.Rows.Add(item.User.Phone, item.Book.BookName,Convert.ToInt32 (DateTime.Now.Subtract(item.StartTime.AddMonths(1)).TotalDays) + " days");
            }
          
        }

        private void txtSearh_Click(object sender, EventArgs e)
        {
            txtSearh.ResetText();
            FillData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Orders.Where(o => o.StartTime < dateTimenow && o.Status == true && o.Book.BookName.Contains(txtSearh.Text)).ToList())
            {
                dataGridView1.Rows.Add(item.User.Phone, item.Book.BookName, Convert.ToInt32(DateTime.Now.Subtract(item.StartTime.AddMonths(1)).TotalDays) + " days");

            }
        }
    }
}
