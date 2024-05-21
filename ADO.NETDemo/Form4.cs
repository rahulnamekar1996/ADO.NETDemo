using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NETDemo
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form4()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private DataSet GetAllStudent()
        {
            string qry = "select * from student";
            da = new SqlDataAdapter(qry, con);
            // add PK to the col which is in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // scb will track the DataSet & generate the qry --> assign to DataAdapter
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // emp is the name given to the table which is in the DataSet
            // if not given then it will take default name is [0]
            //da.Fill(ds);
            da.Fill(ds, "stud");
            return ds;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                // create new row to add record
                DataRow row = ds.Tables["stud"].NewRow();
                row["name"] = txtsname.Text;
                row["city"] = txtcity.Text;
            
                //attach row to the emp table
                ds.Tables["stud"].Rows.Add(row);
                int result = da.Update(ds.Tables["stud"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                    ClearFileds();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].Rows.Find(txtsid.Text);
                if (row != null)
                {
                    txtsname.Text = row["name"].ToString();
                    txtcity.Text = row["city"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].Rows.Find(txtsid.Text);
                if (row != null)
                {
                    // override the value from text box to row
                    row["name"] = txtsname.Text;
                    row["city"] = txtcity.Text;
                 
                    int result = da.Update(ds.Tables["emp"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record updated");
                        ClearFileds();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].Rows.Find(txtsid.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["stud"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                        ClearFileds();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            ds = GetAllStudent();
            dataGridView2.DataSource = ds.Tables["stud"];
        }
        private void ClearFileds()
        {
            txtsid.Clear();
            txtsname.Clear();
            txtcity.Clear();
        
        }
    }
}
