using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroceryManagementSystem
{
    public partial class forgetpass : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);
        public forgetpass()
        {
            InitializeComponent();
        }

       

        private void forgetpass_Load(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
        }

        private void btnmatch1_Click(object sender, EventArgs e)
        {

            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter UserName...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtusername.Focus();
            }
            else if (txtno.Text == "")
            {
                MessageBox.Show("Enter Phone No...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtno.Focus();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from RegTBl where UserName='" + txtusername.Text + "' and No='" + txtno.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    guna2Panel2.Visible = true;
                    guna2Panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("User not Exit..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtusername.Text = "";
                    txtno.Text = "";
                    txtusername.Focus();

                }
                conn.Close();
            }
        }


        private void btnmatch2_Click_1(object sender, EventArgs e)
        {
            if (txtsq.Text == "")
            {
                MessageBox.Show("Please Select Security Qusetion...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtsq.Focus();
            }
            else if (txtanswer.Text == "")
            {
                MessageBox.Show("Enter Answer...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtanswer.Focus();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from RegTBL where Question='" + txtsq.Text + "' and Answer='" + txtanswer.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    guna2Panel3.Visible = true;
                    guna2Panel2.Visible = false;
                }
                else
                {
                    MessageBox.Show("User not Exit..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtsq.Text = "";
                    txtanswer.Text = "";
                    txtsq.Focus();
                }
                conn.Close();
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtenp.Text == "")
            {
                MessageBox.Show("Enter New Password..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtenp.Focus();
            }
            else if (txtcp.Text == "")
            {
                MessageBox.Show("Please Confirm Password..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtcp.Focus();
                            }
            else if (txtenp.Text == txtcp.Text)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update RegTBL set Password='" + txtcp.Text + "'where UserName='" + txtusername.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password Reset Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                //login_form lg = new login_form();
                //lg.Show();
                //this.Hide();

                Login lg=new Login();
                this.Hide();
                lg.Show();
            }
            else
            {
                MessageBox.Show("New Password and Confirm PAssword are Not Match..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtenp.Text = "";
                txtcp.Text = "";
                txtenp.Focus();
            }
        }



        }



    }

