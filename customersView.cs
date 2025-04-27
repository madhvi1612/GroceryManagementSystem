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
    public partial class customersView : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn); 
        public customersView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CustomerPanel.Visible == false)
            {
                CustomerPanel.Visible = true;
            }
            else
            {
                CustomerPanel.Visible = false;
            }
        }

        private void GridViewShow()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from CustomersTbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void customersView_Load(object sender, EventArgs e)
        {
            GridViewShow();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text != ""  && txtphone.Text != ""  && txtemail.Text != ""  && txtaddress.Text != "")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomersTbl(C_name,C_phone,C_email,C_address)values('" + txtname.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtaddress.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtname.Clear();
                txtphone.Clear();
                txtemail.Clear();
                txtaddress.Clear();
                GridViewShow();
            }
            else
            {
                MessageBox.Show("Enter Customer Details...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            CustomerPanel.Visible = false;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from CustomersTbl where C_name like '"+txtsearch.Text+"%'",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            conn.Close();
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            cstid.Clear();
            cstname.Clear();
            cstphone.Clear();
            cstemail.Clear();
            cstaddress.Clear();
            customerPanel2.Visible = false;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EDIT"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to edit this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                customerPanel2.Visible = true;
                cstid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cstname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cstphone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cstemail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cstaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }

            if(e.ColumnIndex==dataGridView1.Columns["DELETE"].Index && e.RowIndex>=0)
            {
                String name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure to delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomersTbl where C_name='"+name+"' ",conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    GridViewShow();
                }
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update CustomersTbl set C_name='" + cstname.Text + "',C_Phone='" + cstphone.Text + "' , C_email='" + cstemail.Text + "',C_address='" + cstaddress.Text + "'where C_id='" + cstid.Text + "'  ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cstid.Clear();
            cstname.Clear();
            cstphone.Clear();
            cstemail.Clear();
            cstaddress.Clear();
            customerPanel2.Visible = false;
            GridViewShow();


        }

       
      
      
        }
      
    }

