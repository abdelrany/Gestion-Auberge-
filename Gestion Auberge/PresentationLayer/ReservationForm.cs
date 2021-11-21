using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;


namespace Gestion_Auberge.PresentationLayer
{
    public partial class ReservationForm : Form
    {
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        SqlConnection con = new SqlConnection(@"data source = .\sqlexpress ; initial catalog = hostel ; integrated security = yes");

        //private static Regex PasswordValidation()
        //{
        //    string pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

        //    return new Regex(pattern, RegexOptions.IgnoreCase);
        //}
        //static Regex vaildate_password = PasswordValidation();

        static Regex validate_emailaddress = email_validation();


        public ReservationForm()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ToggleSwitch1.Checked == true)
            {
                this.BackColor = ColorTranslator.FromHtml("0x393935");

            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("0xF0F0F0");
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnvaliderreser_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate_emailaddress.IsMatch(txtboxgmail.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtboxgmail.Focus();
                    return;

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into Reservationinterne values ('" + textBoxcin.Text + "','" + textBoxnom.Text + "','" + textBoxpre.Text + "','" + txtboxgmail.Text + "','" + guna2DateTimePicker1.Text + "'," + nbrsejour.ToString() + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           


        }

        private void txtboxgmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
