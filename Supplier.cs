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
    public partial class Supplier : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn); 
        public Supplier()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (SupplierPanel.Visible == false)
            {
                SupplierPanel.Visible = true;
            }
            else
            {
                SupplierPanel.Visible = false;
            }
        }
        private void GridViewShow()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from SuppliersTbl",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            conn.Close();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            GridViewShow();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtphone.Text != "" && txtemail.Text != "" && txtaddress.Text != "")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into SuppliersTbl (Spl_name,Spl_phone,Spl_email,Spl_address)values('" + txtname.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtaddress.Text + "') ", conn);
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
                MessageBox.Show("Enter supplier detail...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            SupplierPanel.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from  SuppliersTbl where Spl_name like '"+txtSearch.Text+"%' ",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EDIT"].Index && e.RowIndex >= 0)
            {
                //DialogResult dr = MessageBox.Show("Are you sure to edit this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                SupplierPanel2.Visible = true;
                supid.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                supname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
               supphone.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                supemail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                supaddress.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
               // CategoryLoad1();
            }
            if(e.ColumnIndex==dataGridView1.Columns["DELETE"].Index && e.RowIndex>=0)
            {
                String name= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure to delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from SuppliersTbl where Spl_name='"+name+"' ",conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    GridViewShow();
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update SuppliersTbl set Spl_name='" + supname.Text + "',Spl_phone='" + supphone.Text + "',Spl_email='" + supemail.Text + "',Spl_address='"+supaddress.Text+"' where Spl_id='" + supid.Text + "'  ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            supid.Clear();
            supname.Clear();
            supphone.Clear();
            supaddress.Clear();
            SupplierPanel2.Visible = false;
            GridViewShow();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            supid.Clear();
            supname.Clear();
            supphone.Clear();
            supemail.Clear();
            supaddress.Clear();
            SupplierPanel2.Visible = false;
        }

       
    }
}
