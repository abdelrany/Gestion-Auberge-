
namespace Gestion_Auberge.PresentationLayer
{
    partial class Login_Success
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Success));
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelusertype = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.pictureBoxFemale = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.SidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestaurant = new Guna.UI2.WinForms.Guna2Button();
            this.btnCleaning = new Guna.UI2.WinForms.Guna2Button();
            this.btnActivity = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnlogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.a = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeltime = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.employeesUserControl1 = new Gestion_Auberge.PresentationLayer.UsersControl.EmployeesUserControl();
            this.reservationUserControl1 = new Gestion_Auberge.PresentationLayer.ReservationUserControl();
            this.restaurantUserControl1 = new Gestion_Auberge.PresentationLayer.RestaurantUserControl();
            this.settingsUserControl1 = new Gestion_Auberge.PresentationLayer.UsersControl.SettingsUserControl();
            this.cleaningUserControl1 = new Gestion_Auberge.CleaningUserControl();
            this.activityUserControl1 = new Gestion_Auberge.ActivityUserControl();
            this.homeUserControl1 = new Gestion_Auberge.PresentationLayer.HomeUserControl();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFemale)).BeginInit();
            this.paneltop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.Panel1.Controls.Add(this.guna2Separator1);
            this.Panel1.Controls.Add(this.labelusertype);
            this.Panel1.Controls.Add(this.labeluser);
            this.Panel1.Controls.Add(this.pictureBoxFemale);
            this.Panel1.Controls.Add(this.SidePanel);
            this.Panel1.Controls.Add(this.btnSetting);
            this.Panel1.Controls.Add(this.btnEmployee);
            this.Panel1.Controls.Add(this.btnReservation);
            this.Panel1.Controls.Add(this.btnRestaurant);
            this.Panel1.Controls.Add(this.btnCleaning);
            this.Panel1.Controls.Add(this.btnActivity);
            this.Panel1.Controls.Add(this.btnHome);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(279, 744);
            this.Panel1.TabIndex = 3;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 177);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(279, 47);
            this.guna2Separator1.TabIndex = 8;
            // 
            // labelusertype
            // 
            this.labelusertype.AutoSize = true;
            this.labelusertype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.labelusertype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusertype.ForeColor = System.Drawing.Color.Transparent;
            this.labelusertype.Location = new System.Drawing.Point(143, 106);
            this.labelusertype.Name = "labelusertype";
            this.labelusertype.Size = new System.Drawing.Size(96, 16);
            this.labelusertype.TabIndex = 7;
            this.labelusertype.Text = "Administrator";
            this.labelusertype.Click += new System.EventHandler(this.labeluser_Click);
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.labeluser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.ForeColor = System.Drawing.Color.Transparent;
            this.labeluser.Location = new System.Drawing.Point(143, 78);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(44, 16);
            this.labeluser.TabIndex = 7;
            this.labeluser.Text = "walid";
            this.labeluser.Click += new System.EventHandler(this.labeluser_Click);
            // 
            // pictureBoxFemale
            // 
            this.pictureBoxFemale.Location = new System.Drawing.Point(3, 29);
            this.pictureBoxFemale.Name = "pictureBoxFemale";
            this.pictureBoxFemale.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxFemale.ShadowDecoration.Parent = this.pictureBoxFemale;
            this.pictureBoxFemale.Size = new System.Drawing.Size(113, 101);
            this.pictureBoxFemale.TabIndex = 6;
            this.pictureBoxFemale.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(0, 258);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.ShadowDecoration.Parent = this.SidePanel;
            this.SidePanel.Size = new System.Drawing.Size(15, 45);
            this.SidePanel.TabIndex = 4;
            // 
            // btnSetting
            // 
            this.btnSetting.Animated = true;
            this.btnSetting.CheckedState.Parent = this.btnSetting;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.CustomImages.Parent = this.btnSetting;
            this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.Parent = this.btnSetting;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnSetting.Location = new System.Drawing.Point(0, 564);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(279, 45);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Settings";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Animated = true;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnEmployee.Location = new System.Drawing.Point(0, 513);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(279, 45);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "      Employees";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Animated = true;
            this.btnReservation.BorderColor = System.Drawing.Color.Transparent;
            this.btnReservation.CheckedState.Parent = this.btnReservation;
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.CustomImages.Parent = this.btnReservation;
            this.btnReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.HoverState.Parent = this.btnReservation;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservation.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnReservation.Location = new System.Drawing.Point(0, 462);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.ShadowDecoration.Parent = this.btnReservation;
            this.btnReservation.Size = new System.Drawing.Size(279, 45);
            this.btnReservation.TabIndex = 0;
            this.btnReservation.Text = "       Reservation";
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.Animated = true;
            this.btnRestaurant.BorderColor = System.Drawing.Color.Transparent;
            this.btnRestaurant.CheckedState.Parent = this.btnRestaurant;
            this.btnRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurant.CustomImages.Parent = this.btnRestaurant;
            this.btnRestaurant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnRestaurant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRestaurant.ForeColor = System.Drawing.Color.White;
            this.btnRestaurant.HoverState.Parent = this.btnRestaurant;
            this.btnRestaurant.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurant.Image")));
            this.btnRestaurant.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRestaurant.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnRestaurant.Location = new System.Drawing.Point(0, 411);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.ShadowDecoration.Parent = this.btnRestaurant;
            this.btnRestaurant.Size = new System.Drawing.Size(279, 45);
            this.btnRestaurant.TabIndex = 0;
            this.btnRestaurant.Text = "     Restaurant";
            this.btnRestaurant.Click += new System.EventHandler(this.btnRestaurant_Click);
            // 
            // btnCleaning
            // 
            this.btnCleaning.Animated = true;
            this.btnCleaning.BorderColor = System.Drawing.Color.Transparent;
            this.btnCleaning.CheckedState.Parent = this.btnCleaning;
            this.btnCleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleaning.CustomImages.Parent = this.btnCleaning;
            this.btnCleaning.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnCleaning.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCleaning.ForeColor = System.Drawing.Color.White;
            this.btnCleaning.HoverState.Parent = this.btnCleaning;
            this.btnCleaning.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaning.Image")));
            this.btnCleaning.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCleaning.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnCleaning.Location = new System.Drawing.Point(0, 360);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.ShadowDecoration.Parent = this.btnCleaning;
            this.btnCleaning.Size = new System.Drawing.Size(279, 45);
            this.btnCleaning.TabIndex = 0;
            this.btnCleaning.Text = "   Cleaning";
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // btnActivity
            // 
            this.btnActivity.Animated = true;
            this.btnActivity.BorderColor = System.Drawing.Color.Transparent;
            this.btnActivity.CheckedState.Parent = this.btnActivity;
            this.btnActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivity.CustomImages.Parent = this.btnActivity;
            this.btnActivity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnActivity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActivity.ForeColor = System.Drawing.Color.White;
            this.btnActivity.HoverState.Parent = this.btnActivity;
            this.btnActivity.Image = ((System.Drawing.Image)(resources.GetObject("btnActivity.Image")));
            this.btnActivity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActivity.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnActivity.Location = new System.Drawing.Point(0, 309);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.ShadowDecoration.Parent = this.btnActivity;
            this.btnActivity.Size = new System.Drawing.Size(279, 45);
            this.btnActivity.TabIndex = 0;
            this.btnActivity.Text = " Activity";
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnHome.Location = new System.Drawing.Point(0, 258);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(279, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.btnlogout);
            this.paneltop.Controls.Add(this.a);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(279, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1325, 68);
            this.paneltop.TabIndex = 4;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.Location = new System.Drawing.Point(1269, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(42, 42);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.UseTransparentBackground = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // a
            // 
            this.a.CheckedState.Parent = this.a;
            this.a.CustomImages.Parent = this.a;
            this.a.FillColor = System.Drawing.Color.White;
            this.a.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.a.ForeColor = System.Drawing.Color.White;
            this.a.HoverState.Parent = this.a;
            this.a.Location = new System.Drawing.Point(1263, 6);
            this.a.Name = "a";
            this.a.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.a.ShadowDecoration.Parent = this.a;
            this.a.Size = new System.Drawing.Size(54, 53);
            this.a.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panel2.Controls.Add(this.labeltime);
            this.panel2.Location = new System.Drawing.Point(257, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 40);
            this.panel2.TabIndex = 5;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.Transparent;
            this.labeltime.Location = new System.Drawing.Point(37, 12);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(38, 16);
            this.labeltime.TabIndex = 6;
            this.labeltime.Text = "Time";
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // employeesUserControl1
            // 
            this.employeesUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesUserControl1.Location = new System.Drawing.Point(283, 110);
            this.employeesUserControl1.Name = "employeesUserControl1";
            this.employeesUserControl1.Size = new System.Drawing.Size(1326, 634);
            this.employeesUserControl1.TabIndex = 6;
            // 
            // reservationUserControl1
            // 
            this.reservationUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationUserControl1.Location = new System.Drawing.Point(284, 109);
            this.reservationUserControl1.Name = "reservationUserControl1";
            this.reservationUserControl1.Size = new System.Drawing.Size(1325, 635);
            this.reservationUserControl1.TabIndex = 7;
            // 
            // restaurantUserControl1
            // 
            this.restaurantUserControl1.Location = new System.Drawing.Point(280, 108);
            this.restaurantUserControl1.Name = "restaurantUserControl1";
            this.restaurantUserControl1.Size = new System.Drawing.Size(1311, 585);
            this.restaurantUserControl1.TabIndex = 8;
            // 
            // settingsUserControl1
            // 
            this.settingsUserControl1.Location = new System.Drawing.Point(279, 108);
            this.settingsUserControl1.Name = "settingsUserControl1";
            this.settingsUserControl1.Size = new System.Drawing.Size(1351, 604);
            this.settingsUserControl1.TabIndex = 9;
            // 
            // cleaningUserControl1
            // 
            this.cleaningUserControl1.Location = new System.Drawing.Point(279, 107);
            this.cleaningUserControl1.Name = "cleaningUserControl1";
            this.cleaningUserControl1.Size = new System.Drawing.Size(1326, 637);
            this.cleaningUserControl1.TabIndex = 10;
            // 
            // activityUserControl1
            // 
            this.activityUserControl1.Location = new System.Drawing.Point(279, 106);
            this.activityUserControl1.Name = "activityUserControl1";
            this.activityUserControl1.Size = new System.Drawing.Size(1323, 635);
            this.activityUserControl1.TabIndex = 11;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Location = new System.Drawing.Point(279, 106);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(1326, 635);
            this.homeUserControl1.TabIndex = 12;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(42, 66);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(74, 73);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 9;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Login_Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 744);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.activityUserControl1);
            this.Controls.Add(this.cleaningUserControl1);
            this.Controls.Add(this.settingsUserControl1);
            this.Controls.Add(this.restaurantUserControl1);
            this.Controls.Add(this.reservationUserControl1);
            this.Controls.Add(this.employeesUserControl1);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Success";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Success_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFemale)).EndInit();
            this.paneltop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnReservation;
        private Guna.UI2.WinForms.Guna2Button btnRestaurant;
        private Guna.UI2.WinForms.Guna2Button btnCleaning;
        private Guna.UI2.WinForms.Guna2Button btnActivity;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Panel SidePanel;
        private System.Windows.Forms.Panel paneltop;
        private Guna.UI2.WinForms.Guna2CircleButton btnlogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxFemale;
        private Guna.UI2.WinForms.Guna2CircleButton a;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer time;
        private UsersControl.EmployeesUserControl employeesUserControl1;
        private System.Windows.Forms.Label labelusertype;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private ReservationUserControl reservationUserControl1;
        private RestaurantUserControl restaurantUserControl1;
        private UsersControl.SettingsUserControl settingsUserControl1;
        private CleaningUserControl cleaningUserControl1;
        private ActivityUserControl activityUserControl1;
        private HomeUserControl homeUserControl1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}