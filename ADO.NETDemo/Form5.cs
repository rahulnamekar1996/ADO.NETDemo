using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NETDemo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "admin" && txtpassword.Text == "admin123")
            {
                MessageBox.Show("Login Succesful");
                MDIForm mDI = new MDIForm();
             
                mDI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Loggin failed");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpassword.Clear();
        }
    }
}
