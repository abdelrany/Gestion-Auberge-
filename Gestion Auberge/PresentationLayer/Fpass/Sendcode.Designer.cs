
namespace Gestion_Auberge.PresentationLayer.Fpass
{
    partial class Sendcode
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sendcode));
            this.btnsendcodeveri = new Guna.UI2.WinForms.Guna2Button();
            this.btncheckcode = new Guna.UI2.WinForms.Guna2Button();
            this.txtboxemailres = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxverificationcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.returnback = new System.Windows.Forms.Button();
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.labelcodesent = new System.Windows.Forms.Label();
            this.pictureBoxcodesentsucces = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcodesentsucces)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsendcodeveri
            // 
            this.btnsendcodeveri.CheckedState.Parent = this.btnsendcodeveri;
            this.btnsendcodeveri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsendcodeveri.CustomImages.Parent = this.btnsendcodeveri;
            this.btnsendcodeveri.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.btnsendcodeveri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsendcodeveri.ForeColor = System.Drawing.Color.White;
            this.btnsendcodeveri.HoverState.Parent = this.btnsendcodeveri;
            this.btnsendcodeveri.Location = new System.Drawing.Point(341, 200);
            this.btnsendcodeveri.Name = "btnsendcodeveri";
            this.btnsendcodeveri.ShadowDecoration.Parent = this.btnsendcodeveri;
            this.btnsendcodeveri.Size = new System.Drawing.Size(61, 36);
            this.btnsendcodeveri.TabIndex = 1;
            this.btnsendcodeveri.Text = "Send";
            this.btnsendcodeveri.Click += new System.EventHandler(this.btnsendcodeveri_Click);
            // 
            // btncheckcode
            // 
            this.btncheckcode.CheckedState.Parent = this.btncheckcode;
            this.btncheckcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckcode.CustomImages.Parent = this.btncheckcode;
            this.btncheckcode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.btncheckcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncheckcode.ForeColor = System.Drawing.Color.White;
            this.btncheckcode.HoverState.Parent = this.btncheckcode;
            this.btncheckcode.Location = new System.Drawing.Point(341, 280);
            this.btncheckcode.Name = "btncheckcode";
            this.btncheckcode.ShadowDecoration.Parent = this.btncheckcode;
            this.btncheckcode.Size = new System.Drawing.Size(61, 36);
            this.btncheckcode.TabIndex = 3;
            this.btncheckcode.Text = "Check";
            this.btncheckcode.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtboxemailres
            // 
            this.txtboxemailres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxemailres.DefaultText = "";
            this.txtboxemailres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxemailres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxemailres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxemailres.DisabledState.Parent = this.txtboxemailres;
            this.txtboxemailres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxemailres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxemailres.FocusedState.Parent = this.txtboxemailres;
            this.txtboxemailres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxemailres.ForeColor = System.Drawing.Color.Black;
            this.txtboxemailres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxemailres.HoverState.Parent = this.txtboxemailres;
            this.txtboxemailres.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtboxemailres.IconLeft")));
            this.txtboxemailres.Location = new System.Drawing.Point(107, 200);
            this.txtboxemailres.Name = "txtboxemailres";
            this.txtboxemailres.PasswordChar = '\0';
            this.txtboxemailres.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtboxemailres.PlaceholderText = "Enter your email";
            this.txtboxemailres.SelectedText = "";
            this.txtboxemailres.ShadowDecoration.Parent = this.txtboxemailres;
            this.txtboxemailres.Size = new System.Drawing.Size(235, 36);
            this.txtboxemailres.TabIndex = 0;
            this.txtboxemailres.TextOffset = new System.Drawing.Point(8, 0);
            this.txtboxemailres.TextChanged += new System.EventHandler(this.txtboxemailres_TextChanged);
            // 
            // txtboxverificationcode
            // 
            this.txtboxverificationcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxverificationcode.DefaultText = "";
            this.txtboxverificationcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxverificationcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxverificationcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxverificationcode.DisabledState.Parent = this.txtboxverificationcode;
            this.txtboxverificationcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxverificationcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxverificationcode.FocusedState.Parent = this.txtboxverificationcode;
            this.txtboxverificationcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxverificationcode.ForeColor = System.Drawing.Color.Black;
            this.txtboxverificationcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxverificationcode.HoverState.Parent = this.txtboxverificationcode;
            this.txtboxverificationcode.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtboxverificationcode.IconLeft")));
            this.txtboxverificationcode.Location = new System.Drawing.Point(178, 280);
            this.txtboxverificationcode.MaxLength = 10;
            this.txtboxverificationcode.Name = "txtboxverificationcode";
            this.txtboxverificationcode.PasswordChar = '\0';
            this.txtboxverificationcode.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtboxverificationcode.PlaceholderText = "Verification code";
            this.txtboxverificationcode.SelectedText = "";
            this.txtboxverificationcode.ShadowDecoration.Parent = this.txtboxverificationcode;
            this.txtboxverificationcode.Size = new System.Drawing.Size(163, 36);
            this.txtboxverificationcode.TabIndex = 2;
            this.txtboxverificationcode.TextOffset = new System.Drawing.Point(8, 0);
            this.txtboxverificationcode.TextChanged += new System.EventHandler(this.txtboxverificationcode_TextChanged);
            this.txtboxverificationcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxverificationcode_KeyPress);
            // 
            // returnback
            // 
            this.returnback.BackColor = System.Drawing.Color.Transparent;
            this.returnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnback.FlatAppearance.BorderSize = 0;
            this.returnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnback.Image = ((System.Drawing.Image)(resources.GetObject("returnback.Image")));
            this.returnback.Location = new System.Drawing.Point(0, 0);
            this.returnback.Name = "returnback";
            this.returnback.Size = new System.Drawing.Size(34, 25);
            this.returnback.TabIndex = 4;
            this.returnback.UseVisualStyleBackColor = false;
            this.returnback.Click += new System.EventHandler(this.returnback_Click);
            // 
            // Elipse1
            // 
            this.Elipse1.TargetControl = this;
            // 
            // labelcodesent
            // 
            this.labelcodesent.AutoSize = true;
            this.labelcodesent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodesent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelcodesent.Location = new System.Drawing.Point(196, 250);
            this.labelcodesent.Name = "labelcodesent";
            this.labelcodesent.Size = new System.Drawing.Size(213, 17);
            this.labelcodesent.TabIndex = 5;
            this.labelcodesent.Text = "Your code was sent successfully ";
            this.labelcodesent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxcodesentsucces
            // 
            this.pictureBoxcodesentsucces.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcodesentsucces.Image")));
            this.pictureBoxcodesentsucces.Location = new System.Drawing.Point(177, 249);
            this.pictureBoxcodesentsucces.Name = "pictureBoxcodesentsucces";
            this.pictureBoxcodesentsucces.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxcodesentsucces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxcodesentsucces.TabIndex = 6;
            this.pictureBoxcodesentsucces.TabStop = false;
            // 
            // Sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxcodesentsucces);
            this.Controls.Add(this.labelcodesent);
            this.Controls.Add(this.returnback);
            this.Controls.Add(this.txtboxverificationcode);
            this.Controls.Add(this.txtboxemailres);
            this.Controls.Add(this.btncheckcode);
            this.Controls.Add(this.btnsendcodeveri);
            this.Location = new System.Drawing.Point(58, 141);
            this.Name = "Sendcode";
            this.Size = new System.Drawing.Size(556, 592);
            this.Load += new System.EventHandler(this.Sendcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcodesentsucces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnsendcodeveri;
        private Guna.UI2.WinForms.Guna2Button btncheckcode;
        private Guna.UI2.WinForms.Guna2TextBox txtboxemailres;
        private Guna.UI2.WinForms.Guna2TextBox txtboxverificationcode;
        private System.Windows.Forms.Button returnback;
        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private System.Windows.Forms.PictureBox pictureBoxcodesentsucces;
        private System.Windows.Forms.Label labelcodesent;
    }
}
