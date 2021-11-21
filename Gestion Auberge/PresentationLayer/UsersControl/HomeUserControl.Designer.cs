
namespace Gestion_Auberge.PresentationLayer
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.precedent = new Guna.UI2.WinForms.Guna2Button();
            this.suivant = new Guna.UI2.WinForms.Guna2Button();
            this.txtboxurl = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 45);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1322, 685);
            this.webBrowser1.TabIndex = 0;
            // 
            // precedent
            // 
            this.precedent.CheckedState.Parent = this.precedent;
            this.precedent.CustomImages.Parent = this.precedent;
            this.precedent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.precedent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precedent.ForeColor = System.Drawing.Color.White;
            this.precedent.HoverState.Parent = this.precedent;
            this.precedent.Location = new System.Drawing.Point(-1, 0);
            this.precedent.Name = "precedent";
            this.precedent.ShadowDecoration.Parent = this.precedent;
            this.precedent.Size = new System.Drawing.Size(60, 45);
            this.precedent.TabIndex = 1;
            this.precedent.Text = "<<";
            this.precedent.Click += new System.EventHandler(this.precedent_Click);
            // 
            // suivant
            // 
            this.suivant.CheckedState.Parent = this.suivant;
            this.suivant.CustomImages.Parent = this.suivant;
            this.suivant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.suivant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant.ForeColor = System.Drawing.Color.White;
            this.suivant.HoverState.Parent = this.suivant;
            this.suivant.Location = new System.Drawing.Point(59, 0);
            this.suivant.Name = "suivant";
            this.suivant.ShadowDecoration.Parent = this.suivant;
            this.suivant.Size = new System.Drawing.Size(60, 45);
            this.suivant.TabIndex = 1;
            this.suivant.Text = ">>";
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // txtboxurl
            // 
            this.txtboxurl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxurl.DefaultText = "";
            this.txtboxurl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxurl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxurl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxurl.DisabledState.Parent = this.txtboxurl;
            this.txtboxurl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxurl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxurl.FocusedState.Parent = this.txtboxurl;
            this.txtboxurl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxurl.ForeColor = System.Drawing.Color.Black;
            this.txtboxurl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxurl.HoverState.Parent = this.txtboxurl;
            this.txtboxurl.Location = new System.Drawing.Point(119, 0);
            this.txtboxurl.Name = "txtboxurl";
            this.txtboxurl.PasswordChar = '\0';
            this.txtboxurl.PlaceholderText = "";
            this.txtboxurl.SelectedText = "";
            this.txtboxurl.ShadowDecoration.Parent = this.txtboxurl;
            this.txtboxurl.Size = new System.Drawing.Size(1144, 45);
            this.txtboxurl.TabIndex = 2;
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.Location = new System.Drawing.Point(1259, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(63, 45);
            this.guna2Button3.TabIndex = 1;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.txtboxurl);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.precedent);
            this.Controls.Add(this.webBrowser1);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1577, 730);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button precedent;
        private Guna.UI2.WinForms.Guna2Button suivant;
        private Guna.UI2.WinForms.Guna2TextBox txtboxurl;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}
