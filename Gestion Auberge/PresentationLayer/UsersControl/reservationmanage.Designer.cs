
namespace Gestion_Auberge.PresentationLayer.UsersControl
{
    partial class reservationmanage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservationmanage));
            this.panel3 = new System.Windows.Forms.Panel();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_date_in = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmb_room_no = new System.Windows.Forms.ComboBox();
            this.cmb_room_type = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_client_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_date_out = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_reservatoin_id = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.reservationDataGridView);
            this.panel3.Controls.Add(this.clientDataGridView);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(450, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 733);
            this.panel3.TabIndex = 11;
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.ReadOnly = true;
            this.reservationDataGridView.Size = new System.Drawing.Size(897, 730);
            this.reservationDataGridView.TabIndex = 1;
            this.reservationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationDataGridView_CellContentClick);
            // 
            // clientDataGridView
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.clientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.clientDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.clientDataGridView.Size = new System.Drawing.Size(875, 733);
            this.clientDataGridView.TabIndex = 0;
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
            this.guna2Button4.Location = new System.Drawing.Point(34, 333);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(349, 45);
            this.guna2Button4.TabIndex = 1;
            this.guna2Button4.Text = "Close";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
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
            this.guna2Button3.Location = new System.Drawing.Point(34, 282);
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
            this.guna2Button2.Location = new System.Drawing.Point(274, 282);
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
            this.guna2Button1.Location = new System.Drawing.Point(149, 282);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(119, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Edit";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dtp_date_in
            // 
            this.dtp_date_in.BorderColor = System.Drawing.Color.Gray;
            this.dtp_date_in.BorderThickness = 1;
            this.dtp_date_in.CheckedState.Parent = this.dtp_date_in;
            this.dtp_date_in.FillColor = System.Drawing.Color.White;
            this.dtp_date_in.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_date_in.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_date_in.HoverState.Parent = this.dtp_date_in;
            this.dtp_date_in.Location = new System.Drawing.Point(171, 185);
            this.dtp_date_in.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_date_in.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_date_in.Name = "dtp_date_in";
            this.dtp_date_in.ShadowDecoration.Parent = this.dtp_date_in;
            this.dtp_date_in.Size = new System.Drawing.Size(212, 36);
            this.dtp_date_in.TabIndex = 15;
            this.dtp_date_in.Value = new System.DateTime(2021, 3, 21, 16, 5, 10, 57);
            // 
            // cmb_room_no
            // 
            this.cmb_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_room_no.FormattingEnabled = true;
            this.cmb_room_no.Items.AddRange(new object[] {
            "Free",
            "Paid"});
            this.cmb_room_no.Location = new System.Drawing.Point(171, 150);
            this.cmb_room_no.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_room_no.Name = "cmb_room_no";
            this.cmb_room_no.Size = new System.Drawing.Size(212, 23);
            this.cmb_room_no.TabIndex = 14;
            // 
            // cmb_room_type
            // 
            this.cmb_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_room_type.FormattingEnabled = true;
            this.cmb_room_type.Items.AddRange(new object[] {
            "Single",
            "Couple",
            "Family"});
            this.cmb_room_type.Location = new System.Drawing.Point(171, 118);
            this.cmb_room_type.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_room_type.Name = "cmb_room_type";
            this.cmb_room_type.Size = new System.Drawing.Size(212, 23);
            this.cmb_room_type.TabIndex = 14;
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
            this.panel1.Size = new System.Drawing.Size(1334, 67);
            this.panel1.TabIndex = 9;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1269, 10);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reservation Management";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label7.Location = new System.Drawing.Point(36, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Room No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Room Type";
            // 
            // txt_client_id
            // 
            this.txt_client_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_client_id.Location = new System.Drawing.Point(171, 85);
            this.txt_client_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_client_id.Name = "txt_client_id";
            this.txt_client_id.Size = new System.Drawing.Size(212, 21);
            this.txt_client_id.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label5.Location = new System.Drawing.Point(37, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date In";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.dtp_date_out);
            this.panel2.Controls.Add(this.dtp_date_in);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.cmb_room_no);
            this.panel2.Controls.Add(this.cmb_room_type);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_reservatoin_id);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_client_id);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 512);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtp_date_out
            // 
            this.dtp_date_out.BorderColor = System.Drawing.Color.Gray;
            this.dtp_date_out.BorderThickness = 1;
            this.dtp_date_out.CheckedState.Parent = this.dtp_date_out;
            this.dtp_date_out.FillColor = System.Drawing.Color.White;
            this.dtp_date_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_date_out.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_date_out.HoverState.Parent = this.dtp_date_out;
            this.dtp_date_out.Location = new System.Drawing.Point(171, 227);
            this.dtp_date_out.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_date_out.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_date_out.Name = "dtp_date_out";
            this.dtp_date_out.ShadowDecoration.Parent = this.dtp_date_out;
            this.dtp_date_out.Size = new System.Drawing.Size(212, 36);
            this.dtp_date_out.TabIndex = 15;
            this.dtp_date_out.Value = new System.DateTime(2021, 3, 21, 16, 5, 10, 57);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label4.Location = new System.Drawing.Point(36, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reservation ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.label6.Location = new System.Drawing.Point(37, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Date Out";
            // 
            // txt_reservatoin_id
            // 
            this.txt_reservatoin_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reservatoin_id.Location = new System.Drawing.Point(171, 53);
            this.txt_reservatoin_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_reservatoin_id.Name = "txt_reservatoin_id";
            this.txt_reservatoin_id.Size = new System.Drawing.Size(181, 21);
            this.txt_reservatoin_id.TabIndex = 7;
            // 
            // reservationmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 798);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(279, 108);
            this.Name = "reservationmanage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "reservationmanage";
            this.Load += new System.EventHandler(this.reservationmanage_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        public System.Windows.Forms.DataGridView clientDataGridView;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_date_in;
        private System.Windows.Forms.ComboBox cmb_room_no;
        private System.Windows.Forms.ComboBox cmb_room_type;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_client_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_date_out;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_reservatoin_id;
    }
}