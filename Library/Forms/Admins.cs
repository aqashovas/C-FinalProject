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
    }
}
