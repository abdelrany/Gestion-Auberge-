using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Gestion_Auberge.PresentationLayer.Fpass
{
    public partial class Sendcode : UserControl
    {
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();
        string randomcode;
        public static string to;
        public Sendcode()
        {
            InitializeComponent();

        }

        private void returnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            txtboxemailres.Clear();
            txtboxverificationcode.Clear();
        }

        private void Sendcode_Load(object sender, EventArgs e)
        {
            pictureBoxcodesentsucces.Visible = false;
            labelcodesent.Visible = false;
        }

        private void txtboxverificationcode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void txtboxverificationcode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtboxverificationcode.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtboxverificationcode.Text = string.Empty;
            }
        }

        private void txtboxemailres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsendcodeveri_Click(object sender, EventArgs e)
        {

            if (validate_emailaddress.IsMatch(txtboxemailres.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxemailres.Focus();
                return;
            }


            else
            {
                string from, pass, msgbody;
                Random rand = new Random();
                randomcode = (rand.Next(999999)).ToString();
                MailMessage msg = new MailMessage();
                to = (txtboxemailres.Text).ToString();
                from = "youremail@gmail.com";
                pass = "yourpassword";
                msgbody = "your reset code is " + randomcode;
                msg.To.Add(to);
                msg.From = new MailAddress(from);
                msg.Body = msgbody;
                msg.Subject = "Your password reseting Code is : ";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(msg);
                    pictureBoxcodesentsucces.Visible = true;
                    labelcodesent.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (randomcode == (txtboxverificationcode.Text).ToString())
            {
                to = txtboxemailres.Text;

                PresentationLayer.Fpass.Reset_password second = new PresentationLayer.Fpass.Reset_password();
                this.Hide();
                this.Parent.Controls.Add(second);
                second.Location = new Point(0, 0);
                second.BringToFront();
                second.Show();

            }
            else
            {
                MessageBox.Show("Wrong Code", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
