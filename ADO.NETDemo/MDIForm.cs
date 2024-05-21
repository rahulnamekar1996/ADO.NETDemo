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
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void conneectedEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
           form1.MdiParent= this;
            form1.Show();
        }

        private void dissconnectedEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void disconnectedProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();

        }

        private void dissconectedStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }
    }
}
