
namespace Gestion_Auberge
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.txtboxusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblpleasewait = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblverification = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerauth = new System.Windows.Forms.Timer(this.components);
            this.timerresultlogin = new System.Windows.Forms.Timer(this.components);
            this.lblconnected = new System.Windows.Forms.Label();
            this.lblwrong = new System.Windows.Forms.Label();
            this.timerconnected = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.guna2RadialGauge1 = new Guna.UI2.WinForms.Guna2RadialGauge();
            this.btnReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnadmin = new Guna.UI2.WinForms.Guna2Button();
            this.fpass = new System.Windows.Forms.Label();
            this.returntomain = new System.Windows.Forms.Button();
            this.wrong = new System.Windows.Forms.PictureBox();
            this.deletecharusername = new System.Windows.Forms.PictureBox();
            this.passvisible = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.connected = new System.Windows.Forms.PictureBox();
            this.loading = new System.Windows.Forms.PictureBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.reset_password1 = new Gestion_Auberge.PresentationLayer.Fpass.Reset_password();
            this.sendcode1 = new Gestion_Auberge.PresentationLayer.Fpass.Sendcode();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletecharusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // txtboxusername
            // 
            this.txtboxusername.Animated = true;
            this.txtboxusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxusername.DefaultText = "";
            this.txtboxusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxusername.DisabledState.Parent = this.txtboxusername;
            this.txtboxusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxusername.FocusedState.Parent = this.txtboxusername;
            this.txtboxusername.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtboxusername.ForeColor = System.Drawing.Color.Black;
            this.txtboxusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxusername.HoverState.Parent = this.txtboxusername;
            this.txtboxusername.Location = new System.Drawing.Point(183, 200);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.PasswordChar = '\0';
            this.txtboxusername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtboxusername.PlaceholderText = "type here";
            this.txtboxusername.SelectedText = "";
            this.txtboxusername.ShadowDecoration.Parent = this.txtboxusername;
            this.txtboxusername.Size = new System.Drawing.Size(222, 31);
            this.txtboxusername.TabIndex = 0;
            this.txtboxusername.TextChanged += new System.EventHandler(this.txtboxusername_TextChanged);
            this.txtboxusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxusername_KeyPress);
            // 
            // txtboxpassword
            // 
            this.txtboxpassword.Animated = true;
            this.txtboxpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxpassword.DefaultText = "";
            this.txtboxpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxpassword.DisabledState.Parent = this.txtboxpassword;
            this.txtboxpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxpassword.FocusedState.Parent = this.txtboxpassword;
            this.txtboxpassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtboxpassword.ForeColor = System.Drawing.Color.Black;
            this.txtboxpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxpassword.HoverState.Parent = this.txtboxpassword;
            this.txtboxpassword.Location = new System.Drawing.Point(183, 241);
            this.txtboxpassword.Name = "txtboxpassword";
            this.txtboxpassword.PasswordChar = '\0';
            this.txtboxpassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtboxpassword.PlaceholderText = "type here";
            this.txtboxpassword.SelectedText = "";
            this.txtboxpassword.ShadowDecoration.Parent = this.txtboxpassword;
            this.txtboxpassword.Size = new System.Drawing.Size(222, 31);
            this.txtboxpassword.TabIndex = 1;
            this.txtboxpassword.TextChanged += new System.EventHandler(this.txtboxpassword_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(97, 207);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(66, 19);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Username";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(98, 247);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 19);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Password";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // lblpleasewait
            // 
            this.lblpleasewait.BackColor = System.Drawing.Color.Transparent;
            this.lblpleasewait.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpleasewait.Location = new System.Drawing.Point(220, 378);
            this.lblpleasewait.Name = "lblpleasewait";
            this.lblpleasewait.Size = new System.Drawing.Size(77, 19);
            this.lblpleasewait.TabIndex = 5;
            this.lblpleasewait.Text = "Please wait ";
            this.lblpleasewait.Visible = false;
            // 
            // lblverification
            // 
            this.lblverification.BackColor = System.Drawing.Color.Transparent;
            this.lblverification.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblverification.Location = new System.Drawing.Point(220, 378);
            this.lblverification.Name = "lblverification";
            this.lblverification.Size = new System.Drawing.Size(171, 19);
            this.lblverification.TabIndex = 5;
            this.lblverification.Text = "Authentication in progress";
            this.lblverification.Visible = false;
            this.lblverification.Click += new System.EventHandler(this.lblauthprog_Click);
            // 
            // timerauth
            // 
            this.timerauth.Interval = 3000;
            this.timerauth.Tick += new System.EventHandler(this.timerauth_Tick);
            // 
            // timerresultlogin
            // 
            this.timerresultlogin.Interval = 3000;
            this.timerresultlogin.Tick += new System.EventHandler(this.timerresultlogin_Tick);
            // 
            // lblconnected
            // 
            this.lblconnected.AutoSize = true;
            this.lblconnected.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblconnected.Location = new System.Drawing.Point(213, 379);
            this.lblconnected.Name = "lblconnected";
            this.lblconnected.Size = new System.Drawing.Size(82, 17);
            this.lblconnected.TabIndex = 13;
            this.lblconnected.Text = "Connected";
            // 
            // lblwrong
            // 
            this.lblwrong.AutoSize = true;
            this.lblwrong.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblwrong.Location = new System.Drawing.Point(214, 381);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(205, 34);
            this.lblwrong.TabIndex = 13;
            this.lblwrong.Text = "Wrong username or password \r\nPlease try again";
            // 
            // timerconnected
            // 
            this.timerconnected.Interval = 1000;
            this.timerconnected.Tick += new System.EventHandler(this.timerconnected_Tick);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.guna2ProgressIndicator1);
            this.panelMain.Controls.Add(this.guna2RadialGauge1);
            this.panelMain.Controls.Add(this.btnReservation);
            this.panelMain.Controls.Add(this.btnadmin);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(556, 592);
            this.panelMain.TabIndex = 14;
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.CircleSize = 1F;
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(135, 74);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.guna2ProgressIndicator1.TabIndex = 2;
            // 
            // guna2RadialGauge1
            // 
            this.guna2RadialGauge1.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.guna2RadialGauge1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2RadialGauge1.Location = new System.Drawing.Point(30, 339);
            this.guna2RadialGauge1.MinimumSize = new System.Drawing.Size(30, 30);
            this.guna2RadialGauge1.Name = "guna2RadialGauge1";
            this.guna2RadialGauge1.Size = new System.Drawing.Size(240, 240);
            this.guna2RadialGauge1.TabIndex = 1;
            // 
            // btnReservation
            // 
            this.btnReservation.CheckedState.Parent = this.btnReservation;
            this.btnReservation.CustomImages.Parent = this.btnReservation;
            this.btnReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.HoverState.Parent = this.btnReservation;
            this.btnReservation.Location = new System.Drawing.Point(160, 279);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.ShadowDecoration.Parent = this.btnReservation;
            this.btnReservation.Size = new System.Drawing.Size(233, 45);
            this.btnReservation.TabIndex = 0;
            this.btnReservation.Text = "Réservation";
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.CheckedState.Parent = this.btnadmin;
            this.btnadmin.CustomImages.Parent = this.btnadmin;
            this.btnadmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.btnadmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadmin.ForeColor = System.Drawing.Color.White;
            this.btnadmin.HoverState.Parent = this.btnadmin;
            this.btnadmin.Location = new System.Drawing.Point(160, 207);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.ShadowDecoration.Parent = this.btnadmin;
            this.btnadmin.Size = new System.Drawing.Size(233, 45);
            this.btnadmin.TabIndex = 0;
            this.btnadmin.Text = "Connexion";
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // fpass
            // 
            this.fpass.AutoSize = true;
            this.fpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpass.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpass.Location = new System.Drawing.Point(244, 283);
            this.fpass.Name = "fpass";
            this.fpass.Size = new System.Drawing.Size(101, 15);
            this.fpass.TabIndex = 16;
            this.fpass.Text = "Forgot password";
            this.fpass.Click += new System.EventHandler(this.fpass_Click);
            // 
            // returntomain
            // 
            this.returntomain.BackColor = System.Drawing.Color.Transparent;
            this.returntomain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returntomain.FlatAppearance.BorderSize = 0;
            this.returntomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returntomain.Image = ((System.Drawing.Image)(resources.GetObject("returntomain.Image")));
            this.returntomain.Location = new System.Drawing.Point(1, 0);
            this.returntomain.Name = "returntomain";
            this.returntomain.Size = new System.Drawing.Size(34, 25);
            this.returntomain.TabIndex = 15;
            this.returntomain.UseVisualStyleBackColor = false;
            this.returntomain.Click += new System.EventHandler(this.returntomain_Click);
            // 
            // wrong
            // 
            this.wrong.Image = ((System.Drawing.Image)(resources.GetObject("wrong.Image")));
            this.wrong.Location = new System.Drawing.Point(177, 372);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(30, 31);
            this.wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wrong.TabIndex = 12;
            this.wrong.TabStop = false;
            // 
            // deletecharusername
            // 
            this.deletecharusername.BackColor = System.Drawing.Color.White;
            this.deletecharusername.Image = ((System.Drawing.Image)(resources.GetObject("deletecharusername.Image")));
            this.deletecharusername.Location = new System.Drawing.Point(376, 207);
            this.deletecharusername.Name = "deletecharusername";
            this.deletecharusername.Size = new System.Drawing.Size(19, 19);
            this.deletecharusername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletecharusername.TabIndex = 10;
            this.deletecharusername.TabStop = false;
            this.deletecharusername.Click += new System.EventHandler(this.deletecharusername_Click);
            // 
            // passvisible
            // 
            this.passvisible.BackColor = System.Drawing.Color.White;
            this.passvisible.Image = ((System.Drawing.Image)(resources.GetObject("passvisible.Image")));
            this.passvisible.Location = new System.Drawing.Point(376, 247);
            this.passvisible.Name = "passvisible";
            this.passvisible.Size = new System.Drawing.Size(19, 19);
            this.passvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passvisible.TabIndex = 10;
            this.passvisible.TabStop = false;
            this.passvisible.Click += new System.EventHandler(this.passvisible_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(99)))), ((int)(((byte)(54)))));
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Black;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(937, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(20, 19);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 9;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // connected
            // 
            this.connected.Image = ((System.Drawing.Image)(resources.GetObject("connected.Image")));
            this.connected.Location = new System.Drawing.Point(179, 373);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(25, 26);
            this.connected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.connected.TabIndex = 7;
            this.connected.TabStop = false;
            this.connected.Visible = false;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(180, 376);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(24, 23);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading.TabIndex = 6;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogin.Location = new System.Drawing.Point(183, 310);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.Size = new System.Drawing.Size(222, 42);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Authentification";
            this.btnlogin.TextOffset = new System.Drawing.Point(7, 0);
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(556, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(414, 592);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // reset_password1
            // 
            this.reset_password1.Location = new System.Drawing.Point(0, 0);
            this.reset_password1.Name = "reset_password1";
            this.reset_password1.Size = new System.Drawing.Size(556, 592);
            this.reset_password1.TabIndex = 18;
            // 
            // sendcode1
            // 
            this.sendcode1.Location = new System.Drawing.Point(0, -1);
            this.sendcode1.Name = "sendcode1";
            this.sendcode1.Size = new System.Drawing.Size(556, 592);
            this.sendcode1.TabIndex = 17;
            this.sendcode1.Load += new System.EventHandler(this.sendcode1_Load);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 590);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.sendcode1);
            this.Controls.Add(this.reset_password1);
            this.Controls.Add(this.fpass);
            this.Controls.Add(this.returntomain);
            this.Controls.Add(this.lblwrong);
            this.Controls.Add(this.lblconnected);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.deletecharusername);
            this.Controls.Add(this.passvisible);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.connected);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblverification);
            this.Controls.Add(this.lblpleasewait);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtboxpassword);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletecharusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtboxusername;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtboxpassword;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblpleasewait;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.PictureBox connected;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblverification;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.PictureBox passvisible;
        private System.Windows.Forms.PictureBox deletecharusername;
        private System.Windows.Forms.Timer timerauth;
        private System.Windows.Forms.Timer timerresultlogin;
        private System.Windows.Forms.PictureBox wrong;
        private System.Windows.Forms.Label lblwrong;
        private System.Windows.Forms.Label lblconnected;
        private System.Windows.Forms.Timer timerconnected;
        private System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnReservation;
        private Guna.UI2.WinForms.Guna2Button btnadmin;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
        private Guna.UI2.WinForms.Guna2RadialGauge guna2RadialGauge1;
        private System.Windows.Forms.Button returntomain;
        private System.Windows.Forms.Label fpass;
        private PresentationLayer.Fpass.Sendcode sendcode1;
        private PresentationLayer.Fpass.Reset_password reset_password1;
    }
}

