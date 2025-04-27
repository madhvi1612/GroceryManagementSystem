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
using System.IO;

namespace GroceryManagementSystem
{
    public partial class Reg : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);
        public Reg()
        {
            InitializeComponent();
        }
        private void AutoId()
        {
            conn.Open();
            int id = 0;
            SqlCommand cmd = new SqlCommand("select Count(id) from RegTBL", conn);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            if (id == 0)
            {
                id += 1;
                txtid.Text = id.ToString();
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("select MAX(id) from RegTBL",conn);
                id = Convert.ToInt32(cmd1.ExecuteScalar());
                id += 1;
                txtid.Text = id.ToString();
            }
            conn.Close();
        }
        private void Clear()
        {
            txtid.Clear();
            txtunm.Clear();
            txtpass.Clear();
            txtemail.Clear();
            txtfnm.Clear();
            txtno.Clear();
            txtdob.Clear();
            cmbque.SelectedIndex = -1;
            txtans.Clear();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            AutoId();
            conn.Open();
            txtregdate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            SqlCommand cmd = new SqlCommand("select *from RegTBL where id>0", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbid.Items.Add(dr["id"].ToString());
            }
            dr.Close();
            conn.Close();

        }
        private void regbtn_Click(object sender, EventArgs e)
        {
            if (txtunm.Text == "")
            {
                MessageBox.Show("Enter User Name...!!!");
                txtunm.Focus();
            }
                else if(txtemail.Text=="")
            {
                MessageBox.Show("Enter email address....!!!");
                txtemail.Focus();
                }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Enter Password...!!!");
                txtpass.Focus();
            }
            else if (txtfnm.Text == "")
            {
                MessageBox.Show("Enter Full Name...!!!");
                txtfnm.Focus();
            }
            else if (txtno.Text == "")
            {
                MessageBox.Show("Enter your contact number...!!!");
                txtno.Focus();
            }
            else if (txtdob.Text == "")
            {
                MessageBox.Show("Enter your DOB...!!!");
                txtdob.Focus();
            }
            else if (txtans.Text == "")
            {
                MessageBox.Show("Enter your answer..!!!");
                txtans.Focus();
            }
            else
            {
                byte[] imageData = File.ReadAllBytes(FilePath);

                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into RegTBL(id,UserName,Password,Email,FullName,No,DOB,RegDate,Question,Answer,Image)values('" + txtid.Text + "','" + txtunm.Text + "','" + txtpass.Text + "','" + txtemail.Text + "','" + txtfnm.Text + "','" + txtno.Text + "','" + txtdob.Text + "','" + txtregdate.Text + "','" + cmbque.Text + "','" + txtans.Text + "','" + imageData + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin Registertion successfully...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                Login l1 = new Login();
                this.Hide();
                l1.Show();
            }
        }
      

       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtdob.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtunm.ReadOnly = true;
            txtfnm.ReadOnly = true;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from RegTBL where id='"+cmbid.SelectedItem+"'",conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtid.Text = dr["id"].ToString();
                //txtunm.Text = dr["UserName"].ToString();
                txtunm.Text = "*** *** ***";
              //  txtpass.Text = dr["Password"].ToString();
                txtpass.Text = "*** *** ***";
                //txtemail.Text = dr["Email"].ToString();
                txtemail.Text = "*** *** ***";
                txtfnm.Text = dr["FullName"].ToString();
                txtno.Text = dr["No"].ToString();
                txtdob.Text = dr["DOB"].ToString();
                txtregdate.Text = dr["RegDate"].ToString();
               // cmbque.Text = dr["Question"].ToString();
                cmbque.Text = "*** *** ***";
                //txtans.Text = dr["Answer"].ToString();
                txtans.Text = "*** *** ***";
            }
            dr.Close();
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();
        }

        public string FilePath = "";
        private void btnbr_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images(.jpg, .png)|*.png; *.jpg*";
            if(op.ShowDialog()==DialogResult.OK)
            {
                FilePath = op.FileName;
                txtpic.Image = new Bitmap(FilePath);
            }
        }          

        }
    }

