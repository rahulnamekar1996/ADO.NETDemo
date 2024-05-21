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
using System.Xml.Linq;

namespace ADO.NETDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);

        }
        private void ClearFields()
        {
            txtEmployeeid.Clear();
            txtEmployeename.Clear();
            txtcity.Clear();
            txtSallryy.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 - write query
                string qry = "insert into employee values(@name,@city,@salary)";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@name", txtEmployeename.Text);
                cmd.Parameters.AddWithValue("@city", txtcity.Text);
                cmd.Parameters.AddWithValue("@salary", txtSallryy.Text);
                // fire the query
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // step 1
                string qry = "select * from employee where id=@id";
                // step2
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtEmployeeid.Text);
                //step3 execute the qry
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // whether row is present or not
                {
                    while (dr.Read()) // read row by row -- while loop or you can use if block to read single row
                    {
                        // read column
                        txtEmployeename.Text = dr["name"].ToString();
                        txtcity.Text = dr["city"].ToString();
                        txtSallryy.Text = dr["salary"].ToString();
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
            finally
            {
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 - write query
                string qry = "update employee set name=@name,city=@city,salary=@salary where id=@id";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@name", txtEmployeename.Text);
                cmd.Parameters.AddWithValue("@city", txtcity.Text);
                cmd.Parameters.AddWithValue("@salary", txtSallryy.Text);
                cmd.Parameters.AddWithValue("@id", txtEmployeeid.Text);
                // fire the query
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                // step1 - write query
                string qry = "delete from employee where id=@id";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@id", txtEmployeeid.Text);
                // fire the query
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                con.Close();
            }

        }

        private void btnShowAllResult_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            

            
        }
    }
}
