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
    public partial class Sales : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);
        public Sales()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da=new SqlDataAdapter("select *from SalesTbl where Sal_id like '"+txtSearch.Text+"%'",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
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

        private void closebtn_Click(object sender, EventArgs e)
        {
            ProductPanel.Visible = false;
        }
        private void GridViewShow()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Sal_id,Sal_date,Sal_customer,Sal_name,Sal_qty,Sal_price,Sal_total from SalesTbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void productLoad()
        {
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select Pro_id,Pro_name,Pro_price,Pro_qty from ProductsTbl", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            conn.Close();
        }
        private void productLoad2()
        {
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select Pro_id,Pro_name,Pro_price,Pro_qty from ProductsTbl", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView5.DataSource = dt1;
            conn.Close();
        }
        //private void productLoad3()
        //{
        //    conn.Open();
        //    SqlDataAdapter da1 = new SqlDataAdapter("select Sal_id,Sal_name,Sal_qty,Sal_price from SalesTbl", conn);
        //    DataTable dt1 = new DataTable();
        //    da1.Fill(dt1);
        //    dataGridView4.DataSource = dt1;
        //    conn.Close();
        //}

        private void costomerLoad()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomersTbl", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               
                txtcustomer.Items.Add(dr["C_name"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void costomerLoad2()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomersTbl", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                salcustomer.Items.Add(dr["C_name"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            productLoad();
            productLoad2();
            costomerLoad();
            costomerLoad2();
            GridViewShow();
            txtdate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (txtdate.Text!="" && txtcustomer.Text!="" && txtid.Text!="" && txtname.Text!="" && txtqty.Text!="" &&txtprice.Text!="")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into SalesTbl(Sal_date,Sal_customer,Sal_Pro_id,Sal_name,Sal_qty,Sal_price,Sal_total)values('"+txtdate.Text+"','"+txtcustomer.Text+"','"+txtid.Text+"','"+txtname.Text+"','"+txtqty.Text+"','"+txtprice.Text+"','"+txttot.Text+"')",conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtdate.Clear();
                txtcustomer.SelectedIndex = -1;
                txtid.Clear();
                txtname.Clear();
                txtqty.Clear();
                txtprice.Clear();
   
                GridViewShow();
            }

            else
            {
                MessageBox.Show("Enter Product..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
               txtid.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
               txtname.Text= dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
             //  txtqty.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
               txtprice.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EDIT"].Index && e.RowIndex >= 0)
            {
                //DialogResult dr = MessageBox.Show("Are you sure to edit this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ProductPanel2.Visible = true;
                salesId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                saldate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                salcustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //salid.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                salname.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
               salqty.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
               salprice.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
             //  txttot.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

               costomerLoad();
             
            }

            if (e.ColumnIndex == dataGridView1.Columns["DELETE"].Index && e.RowIndex >= 0)
            {
                String name = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure to delete record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from SalesTbl where Sal_name='" + name + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    GridViewShow();
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            ProductPanel2.Visible = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            conn.Open();
            
            SqlCommand cmd = new SqlCommand("update SalesTbl set Sal_date='" + saldate.Text + "',Sal_customer='"+salcustomer.Text+"',Sal_Pro_id='" + salid.Text + "',Sal_name='" +salname.Text + "',Sal_qty='" +salqty.Text + "',Sal_price='"+salprice.Text+"',Sal_total='"+txtTotal.Text+"'  where Sal_id='" +salesId.Text + "'  ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            salesId.Clear();
            saldate.Clear();
            salcustomer.SelectedIndex = -1;
            salid.Clear();
            salname.Clear();
            salqty.Clear();
            salprice.Clear();

            ProductPanel2.Visible = false;
            GridViewShow();

        }

      

        private void ProductsAddLoad()
        {
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select Sal_id,Sal_name,Sal_price,Sal_qty from SalesTbl", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView4.DataSource = dt1;
            conn.Close();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            String dname = txtname.Text;
            double price=Convert.ToDouble(txtprice.Text);
            double qty=Convert.ToDouble(txtqty.Text);
            double total=price * qty;
          //  dataGridView4.Rows.Add(txtid.Text,txtname.Text,txtprice.Text,txtqty.Text,total.ToString());
            //label4.Text = total.ToString();
            if (dataGridView4.Rows.Count == 0)
            {
                this.dataGridView4.Rows.Add(0, dname, price, qty, total);
            }
            else
            {
                this.dataGridView4.Rows.Add(0, dname, price, qty, total);
            }
            double sum = 0;
            for (int row = 0; row < dataGridView4.Rows.Count; row++)
            {
                sum = sum + Convert.ToDouble(dataGridView4.Rows[row].Cells[4].Value);
            }
            txttot.Text = sum.ToString();

            txtid.Clear();
            txtcustomer.SelectedIndex = -1;
            txtname.Clear();
            txtprice.Clear();
            txtqty.Clear();
        }

        private void txtdate_Click(object sender, EventArgs e)
        {
            txtdate.ReadOnly = false;
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                salid.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                salname.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                //  salqty.Text= dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                salprice.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            String dname = salname.Text;
             double price=Convert.ToDouble(salprice.Text);
            double qty=Convert.ToDouble(salqty.Text);
            double total=price * qty;
          //  dataGridView3.Rows.Add(salid.Text, salname.Text, salprice.Text, salqty.Text, total.ToString());

            if (dataGridView3.Rows.Count == 0)
            {
                this.dataGridView3.Rows.Add(0, dname, price, qty, total);
            }
            else
            {
                this.dataGridView3.Rows.Add(0, dname, price, qty, total);
            }

           double sum1 = 0;
           for (int row = 0; row < dataGridView3.Rows.Count; row++)
           {
               sum1 = sum1 + Convert.ToDouble(dataGridView3.Rows[row].Cells[4].Value);
           }
           txtTotal.Text = sum1.ToString();

           salid.Clear();
          // salcustomer.SelectedIndex = -1;
           txtname.Clear();
           salprice.Clear();
           salqty.Clear();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

      

      

      

       
    }
}
