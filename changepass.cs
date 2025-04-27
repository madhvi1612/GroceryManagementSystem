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
    public partial class changepass : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);
        public changepass()
        {
            InitializeComponent();
        }

        private void changepass_Load(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
        }

        private void btnmatch_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter UserName...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtusername.Focus();
            }
            else if (txtoldpass.Text == "")
            {
                MessageBox.Show("Enter Password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtoldpass.Focus();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from RegTBL where UserName='"+txtusername.Text+"' and Password='"+txtoldpass.Text+"'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //lbuser.Text = dr["UserName"].ToString();
                    //gb1.Visible = false;
                    //gb2.Visible = true;

                    guna2Panel1.Visible = false;
                    guna2Panel2.Visible = true;
                }
                else
                {
                    MessageBox.Show("User not Exit..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    txtusername.Text = "";
                    txtoldpass.Text = "";
                    txtusername.Focus();
                }
                conn.Close();
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtcnp.Text == "")
            {
                MessageBox.Show("Enter New Password..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtcnp.Focus();
            }
            else if (txtcp.Text == "")
            {
                MessageBox.Show("Please Confirm Password..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtcp.Focus();
            }
            else if (txtcnp.Text == txtcp.Text)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update RegTBL set Password='" + txtcp.Text + "'where UserName='" + txtusername.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Reset Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                conn.Close();

                Login l1 = new Login();
                this.Hide();
                l1.Show();
            }
            else
            {
                MessageBox.Show("New Password and Confirm PAssword are Not Match..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtcnp.Text = "";
                txtcp.Text = "";
                txtcnp.Focus();
            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login l2 = new Login();
            this.Hide();
            l2.Show();
        }

       

 
    }
}
