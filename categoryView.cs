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


    public partial class categoryView : Form
    {

        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);

        public categoryView()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (CategoryPanel.Visible == false)
            {
                CategoryPanel.Visible = true;
            }
            else
            {
                CategoryPanel.Visible = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CategoryPanel.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CategoryPanel.Visible = false;
        }

        private void GridViewShow()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from CategoryTbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void categoryView_Load(object sender, EventArgs e)
        {
            GridViewShow();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (txtcatname.Text != "")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into categoryTbl(cat_name) values('" + txtcatname.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtcatname.Clear();
                CategoryPanel.Visible = false;
                GridViewShow();
            }
            else
            {
                MessageBox.Show("Enter Caterory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select *from categoryTbl where Cat_name like '" + txtsearch.Text + "%'", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EDIT"].Index && e.RowIndex >= 0)
            {
                //DialogResult dr = MessageBox.Show("Are you sure to edit this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                panel2.Visible = true;
                catid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                catname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

            if (e.ColumnIndex == dataGridView1.Columns["DELETE"].Index && e.RowIndex >= 0)
            {
                String name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure to delete record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from categoryTbl where cat_name='"+name+"'",conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    GridViewShow();
                }
            }
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update categoryTbl set cat_name='"+catname.Text+"' where cat_id='"+catid.Text+"'  ",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            catid.Clear();
            catname.Clear();
            panel2.Visible = false;
            GridViewShow();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            catid.Clear();
            catname.Clear();
            panel2.Visible = false;
        }

    }
}
