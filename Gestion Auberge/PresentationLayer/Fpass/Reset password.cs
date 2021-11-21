using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer.Fpass
{
    public partial class Reset_password : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Hostel;Integrated Security=True");
        private static Regex PasswordValidation()
        {
            string pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_password = PasswordValidation();
        string username = Sendcode.to;
        public Reset_password()
        {
            InitializeComponent();
        }

        private void btnvisiblenewpassconfirm_Click(object sender, EventArgs e)
        {
            if (validate_password.IsMatch(txtboxnewpass.Text) != true)
            {
                MessageBox.Show("Password must be atleast 8 to 15 characters. It contains atleast one Upper case and numbers.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtboxnewpass.Focus();
                return;
            }


            else if (txtboxnewpass.Text != txtboxconfirmnewpass.Text)
            {
                MessageBox.Show("The passwords you wrote are different", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else
            {

                SqlDataAdapter da = new SqlDataAdapter("select count(*) from Login where Username = '" + txtusernametoreset.Text + "'", con);
                DataTable ta = new DataTable();
                da.Fill(ta);
                if (ta.Rows.Count > 0)
                {
                    panel2.Hide();
                    panel1.Hide();
                    panel3.Visible = true;

                }

                else
                {

                    SqlCommand cmd = new SqlCommand("Update Login Set Password='" + txtboxnewpass.Text + "' where Username ='" + txtusernametoreset.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    panel1.Visible = true;
                    panel2.Hide();
                    panel3.Hide();

                }


            }




        }

        private void Reset_password_Load(object sender, EventArgs e)
        {
            this.Hide();
            panel1.Visible = false;
            panel2.Visible = false;
            this.txtboxnewpass.UseSystemPasswordChar = true;
            this.txtboxconfirmnewpass.UseSystemPasswordChar = true;
        }

        private void btnvisiblenewpass_Click(object sender, EventArgs e)
        {

            if (txtboxnewpass.UseSystemPasswordChar == false && txtboxconfirmnewpass.UseSystemPasswordChar == false)
            {
                this.txtboxnewpass.UseSystemPasswordChar = true;
                this.txtboxconfirmnewpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtboxnewpass.UseSystemPasswordChar = false;
                txtboxconfirmnewpass.UseSystemPasswordChar = false;
            }
        }

        private void btngobackafterreset_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
