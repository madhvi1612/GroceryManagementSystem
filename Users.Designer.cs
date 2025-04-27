namespace GroceryManagementSystem
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtpic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnbr = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtunm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnm = new Guna.UI2.WinForms.Guna2TextBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2Button();
            this.savebtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.UserPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpic)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1223, 156);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Location = new System.Drawing.Point(953, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(160, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAdd.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Calisto MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(72, 113);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(97, 26);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Users List";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(53, 55);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(274, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.UserName,
            this.Phone,
            this.Role,
            this.EDIT,
            this.DELETE});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1223, 491);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "U_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.DataPropertyName = "U_fullName";
            this.NAME.HeaderText = " FULL NAME";
            this.NAME.Name = "NAME";
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "U_userName";
            this.UserName.HeaderText = "USER NAME";
            this.UserName.Name = "UserName";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "U_phone";
            this.Phone.HeaderText = "PHONE";
            this.Phone.Name = "Phone";
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "U_role";
            this.Role.HeaderText = "ROLE";
            this.Role.Name = "Role";
            // 
            // EDIT
            // 
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.Image = global::GroceryManagementSystem.Properties.Resources.Edit_icon;
            this.EDIT.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EDIT.Name = "EDIT";
            this.EDIT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EDIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.Image = global::GroceryManagementSystem.Properties.Resources.delete_icon;
            this.DELETE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DELETE.Name = "DELETE";
            this.DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DELETE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserPanel2
            // 
            this.UserPanel2.BackColor = System.Drawing.Color.Lavender;
            this.UserPanel2.Controls.Add(this.txtpic);
            this.UserPanel2.Controls.Add(this.btnbr);
            this.UserPanel2.Controls.Add(this.label4);
            this.UserPanel2.Controls.Add(this.label3);
            this.UserPanel2.Controls.Add(this.label2);
            this.UserPanel2.Controls.Add(this.label1);
            this.UserPanel2.Controls.Add(this.txtphone);
            this.UserPanel2.Controls.Add(this.txtpass);
            this.UserPanel2.Controls.Add(this.txtunm);
            this.UserPanel2.Controls.Add(this.txtnm);
            this.UserPanel2.Controls.Add(this.closebtn);
            this.UserPanel2.Controls.Add(this.savebtn);
            this.UserPanel2.Controls.Add(this.guna2Panel4);
            this.UserPanel2.Location = new System.Drawing.Point(158, 182);
            this.UserPanel2.Name = "UserPanel2";
            this.UserPanel2.ShadowDecoration.Parent = this.UserPanel2;
            this.UserPanel2.Size = new System.Drawing.Size(836, 419);
            this.UserPanel2.TabIndex = 17;
            this.UserPanel2.Visible = false;
            // 
            // txtpic
            // 
            this.txtpic.Image = ((System.Drawing.Image)(resources.GetObject("txtpic.Image")));
            this.txtpic.Location = new System.Drawing.Point(637, 138);
            this.txtpic.Name = "txtpic";
            this.txtpic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtpic.ShadowDecoration.Parent = this.txtpic;
            this.txtpic.Size = new System.Drawing.Size(142, 134);
            this.txtpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtpic.TabIndex = 41;
            this.txtpic.TabStop = false;
            this.txtpic.Click += new System.EventHandler(this.txtpic_Click);
            // 
            // btnbr
            // 
            this.btnbr.BorderRadius = 20;
            this.btnbr.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnbr.CheckedState.Parent = this.btnbr;
            this.btnbr.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnbr.CustomImages.Parent = this.btnbr;
            this.btnbr.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnbr.FillColor = System.Drawing.Color.Navy;
            this.btnbr.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnbr.ForeColor = System.Drawing.Color.White;
            this.btnbr.HoverState.Parent = this.btnbr;
            this.btnbr.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnbr.Location = new System.Drawing.Point(637, 278);
            this.btnbr.Name = "btnbr";
            this.btnbr.ShadowDecoration.Parent = this.btnbr;
            this.btnbr.Size = new System.Drawing.Size(151, 45);
            this.btnbr.TabIndex = 40;
            this.btnbr.Text = "Browse";
            this.btnbr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnbr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnbr.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnbr.Click += new System.EventHandler(this.btnbr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            // 
            // txtphone
            // 
            this.txtphone.BorderColor = System.Drawing.Color.Black;
            this.txtphone.BorderRadius = 15;
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.DefaultText = "";
            this.txtphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.DisabledState.Parent = this.txtphone;
            this.txtphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.FocusedState.Parent = this.txtphone;
            this.txtphone.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.HoverState.Parent = this.txtphone;
            this.txtphone.Location = new System.Drawing.Point(325, 266);
            this.txtphone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderText = "";
            this.txtphone.SelectedText = "";
            this.txtphone.ShadowDecoration.Parent = this.txtphone;
            this.txtphone.Size = new System.Drawing.Size(260, 36);
            this.txtphone.TabIndex = 35;
            // 
            // txtpass
            // 
            this.txtpass.BorderColor = System.Drawing.Color.Black;
            this.txtpass.BorderRadius = 15;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.Parent = this.txtpass;
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.FocusedState.Parent = this.txtpass;
            this.txtpass.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.HoverState.Parent = this.txtpass;
            this.txtpass.Location = new System.Drawing.Point(31, 266);
            this.txtpass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.PlaceholderText = "";
            this.txtpass.SelectedText = "";
            this.txtpass.ShadowDecoration.Parent = this.txtpass;
            this.txtpass.Size = new System.Drawing.Size(260, 36);
            this.txtpass.TabIndex = 34;
            // 
            // txtunm
            // 
            this.txtunm.BorderColor = System.Drawing.Color.Black;
            this.txtunm.BorderRadius = 15;
            this.txtunm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunm.DefaultText = "";
            this.txtunm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtunm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtunm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunm.DisabledState.Parent = this.txtunm;
            this.txtunm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunm.FocusedState.Parent = this.txtunm;
            this.txtunm.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtunm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunm.HoverState.Parent = this.txtunm;
            this.txtunm.Location = new System.Drawing.Point(325, 165);
            this.txtunm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtunm.Name = "txtunm";
            this.txtunm.PasswordChar = '\0';
            this.txtunm.PlaceholderText = "";
            this.txtunm.SelectedText = "";
            this.txtunm.ShadowDecoration.Parent = this.txtunm;
            this.txtunm.Size = new System.Drawing.Size(260, 36);
            this.txtunm.TabIndex = 33;
            // 
            // txtnm
            // 
            this.txtnm.BorderColor = System.Drawing.Color.Black;
            this.txtnm.BorderRadius = 15;
            this.txtnm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnm.DefaultText = "";
            this.txtnm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnm.DisabledState.Parent = this.txtnm;
            this.txtnm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnm.FocusedState.Parent = this.txtnm;
            this.txtnm.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtnm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnm.HoverState.Parent = this.txtnm;
            this.txtnm.Location = new System.Drawing.Point(31, 165);
            this.txtnm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtnm.Name = "txtnm";
            this.txtnm.PasswordChar = '\0';
            this.txtnm.PlaceholderText = "";
            this.txtnm.SelectedText = "";
            this.txtnm.ShadowDecoration.Parent = this.txtnm;
            this.txtnm.Size = new System.Drawing.Size(260, 36);
            this.txtnm.TabIndex = 32;
            // 
            // closebtn
            // 
            this.closebtn.BorderRadius = 15;
            this.closebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.closebtn.CheckedState.Parent = this.closebtn;
            this.closebtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.closebtn.CustomImages.Parent = this.closebtn;
            this.closebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closebtn.FillColor = System.Drawing.Color.Red;
            this.closebtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.HoverState.Parent = this.closebtn;
            this.closebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closebtn.Location = new System.Drawing.Point(202, 346);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Parent = this.closebtn;
            this.closebtn.Size = new System.Drawing.Size(134, 45);
            this.closebtn.TabIndex = 10;
            this.closebtn.Text = "CLOSE";
            this.closebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closebtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.closebtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Lavender;
            this.savebtn.BorderRadius = 15;
            this.savebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.savebtn.CheckedState.Parent = this.savebtn;
            this.savebtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.savebtn.CustomImages.Parent = this.savebtn;
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.savebtn.FillColor = System.Drawing.Color.MidnightBlue;
            this.savebtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.HoverState.Parent = this.savebtn;
            this.savebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savebtn.Location = new System.Drawing.Point(40, 346);
            this.savebtn.Name = "savebtn";
            this.savebtn.ShadowDecoration.Parent = this.savebtn;
            this.savebtn.Size = new System.Drawing.Size(134, 45);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "SAVE";
            this.savebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savebtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.savebtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel4.BorderColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(836, 115);
            this.guna2Panel4.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(339, 48);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(105, 24);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "UserDetails";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1223, 647);
            this.Controls.Add(this.UserPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.UserPanel2.ResumeLayout(false);
            this.UserPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpic)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Panel UserPanel2;
        private Guna.UI2.WinForms.Guna2Button closebtn;
        private Guna.UI2.WinForms.Guna2Button savebtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtphone;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2TextBox txtunm;
        private Guna.UI2.WinForms.Guna2TextBox txtnm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtpic;
        private Guna.UI2.WinForms.Guna2Button btnbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewImageColumn EDIT;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}