using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace GroceryManagementSystem
{
    public partial class Login : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtunm.Text == "")
            {
                MessageBox.Show("Enter User Name...!");
                txtunm.Focus();
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Enter Password...!");
                txtpass.Focus();
            }
            else
            {
                conn.Open();
               // SqlCommand cmd = new SqlCommand("insert into Login(id,UserName,Password) values('"+txtunm.Text+",'"+txtpass.Text+"'')",conn);
                SqlCommand cmd = new SqlCommand("select *from RegTBL where UserName='"+txtunm.Text+"' and Password='"+txtpass.Text+"' ",conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    MessageBox.Show("Login Successfully....!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr.Close();
                   
                  
                   // conn.Open();
                    SqlCommand cmd1 = new SqlCommand("update TemporyTbl set T_name='"+txtunm.Text+"' where T_id=1 ", conn);
                    cmd1.ExecuteNonQuery();
                   // conn.Close();

                    Mainfrm mf = new Mainfrm();
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("invalid UserName and password");
                }
                conn.Close();
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reg r1 = new Reg();
            this.Hide();
            r1.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpass fr = new forgetpass();
            this.Hide();
            fr.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changepass cng = new changepass();
            this.Hide();
            cng.Show();
        }

      

       
    }
}
