
namespace Gestion_Auberge.PresentationLayer.UsersControl
{
    partial class addclient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addclient));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_client_gender = new System.Windows.Forms.ComboBox();
            this.txt_client_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_client_contact = new System.Windows.Forms.TextBox();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_client_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_client_registration_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_client_dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.clientDataGridView);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(412, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 733);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(910, 730);
            this.dataGridView1.TabIndex = 1;
            // 
            // clientDataGridView
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.clientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.clientDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.clientDataGridView.ColumnHeadersHeight = 40;
            this.clientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDataGridView.EnableHeadersVisualStyles = false;
            this.clientDataGridView.GridColor = System.Drawing.Color.Purple;
            this.clientDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.ReadOnly = true;
            this.clientDataGridView.RowHeadersVisible = false;
            this.clientDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clientDataGridView.RowTemplate.Height = 35;
            this.clientDataGridView.Size = new System.Drawing.Size(910, 733);
            this.clientDataGridView.TabIndex = 0;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(34, 367);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(109, 45);
            this.guna2Button3.TabIndex = 1;
            this.guna2Button3.Text = "Save";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(267, 367);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(109, 45);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Remove";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(149, 367);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(109, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Edit";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cmb_client_gender
            // 
            this.cmb_client_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_client_gender.FormattingEnabled = true;
            this.cmb_client_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_client_gender.Location = new System.Drawing.Point(171, 107);
            this.cmb_client_gender.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_client_gender.Name = "cmb_client_gender";
            this.cmb_client_gender.Size = new System.Drawing.Size(212, 23);
            this.cmb_client_gender.TabIndex = 14;
            // 
            // txt_client_address
            // 
            this.txt_client_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_client_address.Location = new System.Drawing.Point(171, 255);
            this.txt_client_address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_client_address.Multiline = true;
            this.txt_client_address.Name = "txt_client_address";
            this.txt_client_address.Size = new System.Drawing.Size(212, 88);
            this.txt_client_address.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label8.Location = new System.Drawing.Point(31, 263);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Client Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label7.Location = new System.Drawing.Point(31, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Client Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client ID ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label6.Location = new System.Drawing.Point(31, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Registration Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label3.Location = new System.Drawing.Point(31, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Client Name";
            // 
            // txt_client_contact
            // 
            this.txt_client_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_client_contact.Location = new System.Drawing.Point(171, 184);
            this.txt_client_contact.Margin = new System.Windows.Forms.Padding(2);
            this.txt_client_contact.Name = "txt_client_contact";
            this.txt_client_contact.Size = new System.Drawing.Size(212, 21);
            this.txt_client_contact.TabIndex = 11;
            // 
            // txt_client_name
            // 
            this.txt_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_client_name.Location = new System.Drawing.Point(171, 75);
            this.txt_client_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.Size = new System.Drawing.Size(212, 21);
            this.txt_client_name.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label5.Location = new System.Drawing.Point(31, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date Of Birth";
            // 
            // txt_client_id
            // 
            this.txt_client_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_client_id.Location = new System.Drawing.Point(171, 45);
            this.txt_client_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_client_id.Name = "txt_client_id";
            this.txt_client_id.Size = new System.Drawing.Size(181, 21);
            this.txt_client_id.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clients Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 67);
            this.panel1.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1270, 10);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Client Gender";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dtp_client_registration_date);
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.dtp_client_dob);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.cmb_client_gender);
            this.panel2.Controls.Add(this.txt_client_address);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_client_contact);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_client_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_client_id);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 512);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtp_client_registration_date
            // 
            this.dtp_client_registration_date.BorderColor = System.Drawing.Color.Gray;
            this.dtp_client_registration_date.BorderThickness = 1;
            this.dtp_client_registration_date.CheckedState.Parent = this.dtp_client_registration_date;
            this.dtp_client_registration_date.FillColor = System.Drawing.Color.White;
            this.dtp_client_registration_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_client_registration_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_client_registration_date.HoverState.Parent = this.dtp_client_registration_date;
            this.dtp_client_registration_date.Location = new System.Drawing.Point(171, 214);
            this.dtp_client_registration_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_client_registration_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_client_registration_date.Name = "dtp_client_registration_date";
            this.dtp_client_registration_date.ShadowDecoration.Parent = this.dtp_client_registration_date;
            this.dtp_client_registration_date.Size = new System.Drawing.Size(212, 36);
            this.dtp_client_registration_date.TabIndex = 15;
            this.dtp_client_registration_date.Value = new System.DateTime(2021, 3, 21, 16, 5, 10, 57);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(34, 418);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(342, 45);
            this.guna2Button4.TabIndex = 1;
            this.guna2Button4.Text = "Close";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // dtp_client_dob
            // 
            this.dtp_client_dob.BorderColor = System.Drawing.Color.Gray;
            this.dtp_client_dob.BorderThickness = 1;
            this.dtp_client_dob.CheckedState.Parent = this.dtp_client_dob;
            this.dtp_client_dob.FillColor = System.Drawing.Color.White;
            this.dtp_client_dob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_client_dob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_client_dob.HoverState.Parent = this.dtp_client_dob;
            this.dtp_client_dob.Location = new System.Drawing.Point(171, 140);
            this.dtp_client_dob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_client_dob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_client_dob.Name = "dtp_client_dob";
            this.dtp_client_dob.ShadowDecoration.Parent = this.dtp_client_dob;
            this.dtp_client_dob.Size = new System.Drawing.Size(212, 36);
            this.dtp_client_dob.TabIndex = 15;
            this.dtp_client_dob.Value = new System.DateTime(2021, 3, 21, 16, 5, 10, 57);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(351, 45);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // addclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 798);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(279, 108);
            this.Name = "addclient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.addclient_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmb_client_gender;
        private System.Windows.Forms.TextBox txt_client_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_client_contact;
        private System.Windows.Forms.TextBox txt_client_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_client_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_client_registration_date;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_client_dob;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}