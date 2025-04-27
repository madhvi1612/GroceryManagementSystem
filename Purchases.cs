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
    public partial class Purchases : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);
        public Purchases()
        {
            InitializeComponent();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from PurchasesTbl where Pur_id like ''"+txtsearch.Text+"%",conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        
        private void SuppliersLoad()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SuppliersTbl", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pursupp.Items.Add(dr["Spl_name"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            SuppliersLoad();
            GridViewShow();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            PurchasPanel1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PurchasPanel1.Visible == false)
            {
                PurchasPanel1.Visible = true;
            }
            else
            {
                PurchasPanel1.Visible = false;
            }
        }

        private void GridViewShow()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Pur_id,Pur_date,Pur_supplier,Pur_amount from PurchasesTbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (purdate.Text !="" &&  pursupp.Text!=""  &&  purpro.Text!=""  &&  purqty.Text!=""  &&  purcost.Text!=""  &&  puramount.Text!="")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into PurchasesTbl(Pur_date,Pur_supplier,Pur_pro,Pur_qty,Pur_cost,Pur_amount)values('" + purdate.Text + "','" + pursupp.Text + "','" + purpro.Text + "','" + purqty.Text + "','" + purcost.Text + "','" + puramount.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                purdate.Clear();
                pursupp.SelectedIndex = -1;
                purpro.Clear();
                purqty.Clear();
                purcost.Clear();
                puramount.Clear();
                GridViewShow();
            }

            else
            {
                MessageBox.Show("Enter Product..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuppliersLoad1()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SuppliersTbl", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtsupp.Items.Add(dr["Spl_name"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex == dataGridView1.Columns["EDIT"].Index && e.RowIndex >= 0)
            {
                //DialogResult dr = MessageBox.Show("Are you sure to edit this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 PurchasPanel2.Visible = true;
               txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               txtdate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
               txtsupp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
               txtpro.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
               txtqty.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
               txtpric.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
               txtamount.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
               SuppliersLoad1();
            }
           if (e.ColumnIndex == dataGridView1.Columns["DELETE"].Index && e.RowIndex >= 0)
           {
               String supplier = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
               DialogResult dr = MessageBox.Show("Are you sure to delete record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (dr == DialogResult.Yes)
               {
                   conn.Open();
                   SqlCommand cmd = new SqlCommand("delete from PurchasesTbl where Pur_supplier='" +supplier + "'", conn);
                   cmd.ExecuteNonQuery();
                   conn.Close();
                   GridViewShow();
               }
           }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            PurchasPanel2.Visible = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            conn.Open();
           SqlCommand cmd = new SqlCommand("update PurchasesTbl set Pur_date='" + txtdate.Text + "',Pur_supplier='" + txtsupp.Text + "',Pur_pro='" + txtpro.Text + "',Pur_qty='" +txtqty.Text + "',Pur_cost='"+txtpric.Text+"',Pur_amount='"+txtamount.Text+"' where Pur_id='" + txtid.Text + "'  ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            txtid.Clear();
            txtdate.Clear();
            txtsupp.SelectedIndex = -1;
            txtpro.Clear();
            txtqty.Clear();
            txtpric.Clear();
            txtamount.Clear();
            PurchasPanel2.Visible = false;
            GridViewShow();
        }

       
        
       

       

        

        }

}
      
   

