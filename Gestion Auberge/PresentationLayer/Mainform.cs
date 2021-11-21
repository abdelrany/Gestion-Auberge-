using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion_Auberge
{
    public partial class Main : Form
    {

        DataBusiness.Login log = new DataBusiness.Login();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtboxpassword.UseSystemPasswordChar = true;

            wrong.Visible = false;
            lblwrong.Visible = false;
            lblconnected.Visible = false;
            connected.Visible = false;
            returntomain.Hide();
            sendcode1.Visible = false;

        }

        private void txtboxpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtboxpassword.UseSystemPasswordChar == false)
            {
                this.txtboxpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxpassword.UseSystemPasswordChar = true;
            }
            wrong.Visible = false;
            lblwrong.Visible = false;
            loading.Visible = false;
            connected.Visible = false;
            lblconnected.Visible = false;
            lblverification.Visible = false;
            lblpleasewait.Visible = false;
            timerauth.Enabled = false;
        }

        private void lblauthprog_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtboxusername.Text == "")
            {

                wrong.Visible = false;
                lblwrong.Visible = false;
                loading.Visible = false;
                connected.Visible = false;
                lblconnected.Visible = false;
                lblverification.Visible = false;
                lblpleasewait.Visible = false;
                txtboxusername.Focus();
            }

            else if (txtboxpassword.Text == "")
            {
                wrong.Visible = false;
                lblwrong.Visible = false;
                loading.Visible = false;
                connected.Visible = false;
                lblconnected.Visible = false;
                lblverification.Visible = false;
                lblpleasewait.Visible = false;
                txtboxpassword.Focus();
            }


            else
            {
                loading.Visible = true;
                lblverification.Visible = true;
                timerauth.Enabled = true;
            }



        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void passvisible_Click(object sender, EventArgs e)
        {

            if (txtboxpassword.UseSystemPasswordChar == false)
            {
                this.txtboxpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtboxpassword.UseSystemPasswordChar = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            PresentationLayer.ReservationForm frmreser = new PresentationLayer.ReservationForm();
            frmreser.Show();


        }

        private void txtboxusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = Char.IsPunctuation(e.KeyChar) ||
                            Char.IsSeparator(e.KeyChar) ||
                            Char.IsSymbol(e.KeyChar);
            }

        }

        private void deletecharusername_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txtboxusername.Text, "") < 0))
            {
                txtboxusername.Text = txtboxusername.Text.Substring(0, txtboxusername.Text.Length - 1 + 1);
            }
            else
            {
                txtboxusername.Text = txtboxusername.Text.Substring(0, txtboxusername.Text.Length - 1);
            }

        }



        private void timerauth_Tick(object sender, EventArgs e)
        {

            lblverification.Visible = false;
            lblpleasewait.Visible = true;
            loading.Visible = true;
            timerauth.Enabled = false;
            timerresultlogin.Start();

        }

        private void timerresultlogin_Tick(object sender, EventArgs e)
        {

            DataTable ta = log.login(txtboxusername.Text, txtboxpassword.Text);

            if (ta.Rows.Count > 0)
            {
                loading.Visible = false;
                lblpleasewait.Visible = false;
                connected.Visible = true;
                lblconnected.Visible = true;
                lblwrong.Visible = false;
                wrong.Visible = false;
                timerresultlogin.Stop();
                timerconnected.Enabled = true;


            }
            else
            {
                loading.Visible = false;
                lblpleasewait.Visible = false;
                wrong.Visible = true;
                lblwrong.Visible = true;
                timerresultlogin.Stop();

            }

            timerresultlogin.Enabled = false;
        }

        private void txtboxusername_TextChanged(object sender, EventArgs e)
        {
            wrong.Visible = false;
            lblwrong.Visible = false;
            loading.Visible = false;
            connected.Visible = false;
            lblconnected.Visible = false;
            lblverification.Visible = false;
            lblpleasewait.Visible = false;
            timerauth.Enabled = false;
        }

        private void timerconnected_Tick(object sender, EventArgs e)
        {
            timerconnected.Stop();
            PresentationLayer.Login_Success frm = new PresentationLayer.Login_Success();
            frm.usernamecon = txtboxusername.Text;
            txtboxusername.Clear();
            txtboxpassword.Clear();
            frm.Show();


        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            PresentationLayer.ReservationForm frm = new PresentationLayer.ReservationForm();
            frm.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            this.panelMain.Hide();
            txtboxusername.Focus();
            returntomain.Visible = true;
        }

        private void returntomain_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            returntomain.Visible = false;
        }

        private void fpass_Click(object sender, EventArgs e)
        {
            sendcode1.Visible = true;

        }

        private void sendcode1_Load(object sender, EventArgs e)
        {

        }
    }
}
