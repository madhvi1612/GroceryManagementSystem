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
    public partial class Users : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);
        public Users()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da=new SqlDataAdapter("select *from UsersTbl where U_id like '"+txtSearch.Text+"%' ",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UserPanel2.Visible == false)
            {
                UserPanel2.Visible = true;
            }
            else
            {
                UserPanel2.Visible = false;
            }
        }
      

        private void GridViewShow()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from UsersTbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            UserPanel2.Visible = false;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (txtnm.Text != "" && txtunm.Text!="" && txtpass.Text!=""&& txtphone.Text!="")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into UsersTbl(U_FullName,U_userName,U_pass,U_phone,U_image) values('" + txtnm.Text + "','" + txtunm.Text + "','" + txtpass.Text + "','" + txtphone.Text + "','" + FilePath + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtnm.Clear();
                txtunm.Clear();
                txtphone.Clear();
                txtphone.Clear();
               UserPanel2.Visible=false;
                //GridViewShow();
            }
            else
            {
                MessageBox.Show("Enter User Information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            GridViewShow();
        }
        public String FilePath = "";
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

        private void txtpic_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (e.ColumnIndex == dataGridView1.Columns["EDIT"].Index && e.RowIndex >= 0)
        //    {
        //        //DialogResult dr = MessageBox.Show("Are you sure to edit this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //         PurchasPanel2.Visible = true;
        //       txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        //       txtdate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        //       txtsupp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        //       txtpro.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        //       txtqty.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        //       txtpric.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        //       txtamount.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        //       SuppliersLoad1();
        //    }
        //   if (e.ColumnIndex == dataGridView1.Columns["DELETE"].Index && e.RowIndex >= 0)
        //   {
        //       String supplier = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        //       DialogResult dr = MessageBox.Show("Are you sure to delete record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //       if (dr == DialogResult.Yes)
        //       {
        //           conn.Open();
        //           SqlCommand cmd = new SqlCommand("delete from PurchasesTbl where Pur_supplier='" +supplier + "'", conn);
        //           cmd.ExecuteNonQuery();
        //           conn.Close();
        //           GridViewShow();
               }

        
    }
        }
  
