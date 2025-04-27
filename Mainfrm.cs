using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroceryManagementSystem
{
   
    public partial class Mainfrm : Form
    {
        static String cn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(cn);
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            HomePage hm = new HomePage();
            hm.TopLevel = false;
            panel1.Controls.Add(hm);
            hm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hm.Dock = DockStyle.Fill;
            hm.Show();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            categoryView cat = new categoryView();
            cat.TopLevel = false;
            panel1.Controls.Add(cat);
            cat.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cat.Dock = DockStyle.Fill;
            cat.Show();

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ProductView pd = new ProductView();
            pd.TopLevel = false;
            panel1.Controls.Add(pd);
            pd.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pd.Dock = DockStyle.Fill;
            pd.Show();

        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            customersView cm = new customersView();
            cm.TopLevel = false;
            panel1.Controls.Add(cm);
            cm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cm.Dock = DockStyle.Fill;
            cm.Show();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Supplier sp = new Supplier();
            sp.TopLevel = false;
            panel1.Controls.Add(sp);
            sp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Purchases pr = new Purchases();
            pr.TopLevel = false;
            panel1.Controls.Add(pr);
            pr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pr.Dock = DockStyle.Fill;
            pr.Show();
        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Sales s = new Sales();
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            s.Dock = DockStyle.Fill;
            s.Show();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Users u = new Users();
            u.TopLevel = false;
            panel1.Controls.Add(u);
            u.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd=new SqlCommand("select * from TemporyTbl where T_id=1",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtusernm.Text=dr["T_name"].ToString();

            }
            dr.Close();
            conn.Close();




            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from RegTBL where UserName='" + txtusernm.Text + "'", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {

               // byte[] imageData = (byte[])dr2["Image"];
                //using (MemoryStream ms = new MemoryStream(imageData))
                //{
                //    txtpic.Image=new Bitmap(ms);
                //}

                //byte[] imagedata = (byte[])dr2[10];

                //using (MemoryStream ms = new MemoryStream(imagedata))
                //{
                //    txtpic.Image = new Bitmap(ms);
                //}



                //FileStream fs = new FileStream("Image.bmp",FileMode.Create);
                //byte[] picbyte = (byte[])dr2["Image"];
                //fs.Write(picbyte, 0, picbyte.Length);
                //txtpic.Image = Image.FromFile("Image.bmp");
                //fs.Close();
                //fs = null;

                //  txtpic.Image]= dr2["Image"];
                //String imagePath = dr2["Image"].ToString();
                //txtpic.Image = Image.FromStream(imagePath);

            }
            dr2.Close();
            conn.Close();
            
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Report pr = new Report();
            pr.TopLevel = false;
            panel1.Controls.Add(pr);
            pr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pr.Dock = DockStyle.Fill;
            pr.Show();
        }

    }




}
