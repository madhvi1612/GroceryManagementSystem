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
    public partial class ProductView : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn); 
        public ProductView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ProductPanel.Visible == false)
            {
                ProductPanel.Visible = true;
            }
            else
            {
                ProductPanel.Visible = false;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            ProductPanel.Visible = false;
        }
        private void GridViewShow()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from ProductsTbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            CategoryLoad();
            GridViewShow();
        }

        private void CategoryLoad()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from categoryTbl",conn);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                txtcat.Items.Add(dr["cat_name"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtcat.Text != "" && txtpru.Text != "" && txtsale.Text != "")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductsTbl(Pro_name,Pro_category,Pro_cost,Pro_price,Pro_qty)values('" + txtname.Text + "','" + txtcat.Text + "','" + txtpru.Text + "','" + txtsale.Text + "','"+txtqty.Text+"')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtname.Clear();
                txtcat.Text = "";
                txtpru.Clear();
                txtsale.Clear();
                txtqty.Clear();
                GridViewShow();

               
            }
            else
            {
                MessageBox.Show("Enter Product..!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from ProductsTbl where Pro_name like '"+txtsearch.Text+"%'",conn);
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
                productPanel2.Visible = true;
                proid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                proname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                procost.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                proprice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
               procat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
               ProQty.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
               CategoryLoad1();
            }

            if(e.ColumnIndex==dataGridView1.Columns["DELETE"].Index &&e.RowIndex>=0)
            {
                String name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                  DialogResult dr = MessageBox.Show("Are you sure to delete record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductsTbl where Pro_name='"+name+"'",conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    GridViewShow();
                }
            }
        }
        private void CategoryLoad1()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from categoryTbl", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                procat.Items.Add(dr["cat_name"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            proname.Clear();
            procost.Clear();
            proprice.Clear();
            procost.Clear();
            ProQty.Clear();
            productPanel2.Visible = false;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update ProductsTbl set Pro_name='" + proname.Text + "',Pro_cost='" + procost.Text + "',Pro_price='" + proprice.Text + "',Pro_category='" + procat.Text + "',Pro_qty='" + ProQty.Text + "'  where Pro_id='" + proid.Text + "'  ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            proid.Clear();
            proname.Clear();
            procost.Clear();
            proprice.Clear();
            ProQty.Clear();
            productPanel2.Visible = false;
            GridViewShow();
        

        }

       

     
     

     
    }
}
