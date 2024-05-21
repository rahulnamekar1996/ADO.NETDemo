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
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;


        public Form3()
        {

            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);
        }
        private DataSet GetAllProducts()
        {
            string qry = "select * from products";
            da = new SqlDataAdapter(qry, con);
            // add PK to the col which is in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // scb will track the DataSet & generate the qry --> assign to DataAdapter
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // emp is the name given to the table which is in the DataSet
            // if not given then it will take default name is [0]
            //da.Fill(ds);
            da.Fill(ds, "pro");
            return ds;

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllProducts();
                // create new row to add record
                DataRow row = ds.Tables["pro"].NewRow();
                row["name"] = txtpname.Text;
                row["author"] = txtAuthorName.Text;
                row["price"] = txtprice.Text;
                //attach row to the emp table
                ds.Tables["pro"].Rows.Add(row);
                int result = da.Update(ds.Tables["pro"]);
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
                ds = GetAllProducts();
                DataRow row = ds.Tables["pro"].Rows.Find(txtpid.Text);
                if (row != null)
                {
                   txtpname.Text = row["name"].ToString();
                    txtAuthorName.Text = row["author"].ToString();
                    txtprice.Text = row["price"].ToString();
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
                ds = GetAllProducts();
                DataRow row = ds.Tables["pro"].Rows.Find(txtpid.Text);
                if (row != null)
                {
                    // override the value from text box to row
                    row["name"] = txtpname.Text;
                    row["author"] = txtAuthorName.Text;
                    row["price"] = txtprice.Text;
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
                ds = GetAllProducts();
                DataRow row = ds.Tables["pro"].Rows.Find(txtpid.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["pro"]);
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
            ds = GetAllProducts();
            dataGridView1.DataSource = ds.Tables["pro"];
        }
        private void ClearFileds()
        {
            txtpid.Clear();
            txtpname.Clear();
            txtAuthorName.Clear();
            txtprice.Clear();
        }
    }
}
