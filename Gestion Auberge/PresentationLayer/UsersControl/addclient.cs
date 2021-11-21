using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer.UsersControl
{
    public partial class addclient : Form
    {
        public addclient()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txt_client_address.Clear();
            txt_client_contact.Clear();
            txt_client_id.Clear();
            txt_client_name.Clear();
            cmb_client_gender.Text = "";
            dtp_client_dob.Text = "";
            dtp_client_registration_date.Text = "";
            txt_client_id.Focus();

        }
        public void Showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");
            con.Open();

            string str = "Select * From client";

            SqlCommand cmd = new SqlCommand(str, con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

            con.Open();

            string str = "Select c_name,c_gender,c_dateofbirth,c_contact,c_registration_date,c_address From client Where c_id = '" + txt_client_id.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_client_name.Text = dr.GetValue(0).ToString();
                cmb_client_gender.Text = dr.GetValue(1).ToString();
                dtp_client_dob.Text = dr.GetValue(2).ToString();
                txt_client_contact.Text = dr.GetValue(3).ToString();
                dtp_client_registration_date.Text = dr.GetValue(4).ToString();
                txt_client_address.Text = dr.GetValue(5).ToString();
            }
            else
            {

                MessageBox.Show(" This Client Id is Invalid, Please Insert a Correct one", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            con.Close();
        }

        private void guna2Button3_Click(object sender, System.EventArgs e)
        {
            if (txt_client_id.Text == "" || txt_client_name.Text == "" || txt_client_contact.Text == "" || txt_client_address.Text == "" || cmb_client_gender.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    string str = "Insert Into client (c_id,c_name,c_gender,c_dateofbirth,c_contact,c_registration_date,c_address)Values('" + txt_client_id.Text + "','" + txt_client_name.Text + "','" + cmb_client_gender.Text + "','" + dtp_client_dob.Text + "','" + txt_client_contact.Text + "','" + dtp_client_registration_date.Text + "','" + txt_client_address.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    string str2 = "Select max(c_id) From client";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        Showdata();
                        MessageBox.Show("Client's Registration is Successfull ...!", "Clients Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Client's Registration is Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please , Enter Another ID , This ID Is Already Used ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_client_name.Text == "" || txt_client_contact.Text == "" || txt_client_address.Text == "" || cmb_client_gender.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    String str = "Update client Set c_name = '" + txt_client_name.Text + "',c_gender = '" + cmb_client_gender.Text + "',c_dateofbirth = '" + dtp_client_dob.Text + "',c_contact = '" + txt_client_contact.Text + "',c_registration_date = '" + dtp_client_registration_date.Text + "',c_address = '" + txt_client_address.Text + "' Where c_id = '" + txt_client_id.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    String str2 = "Select max(c_id) From client";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        Showdata();
                        MessageBox.Show("Client Record Updated Successfully ...!", "Client Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Client Record Updating Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txt_client_name.Text == "" || txt_client_contact.Text == "" || txt_client_address.Text == "" || cmb_client_gender.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    String str = "Delete From client Where c_id = '" + txt_client_id.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    String str2 = "Select max(c_id) From client";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        Showdata();
                        MessageBox.Show("Client's Record was Deleted Successfully ...!", "SHRS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Client's Record Deleting is Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addclient_Load(object sender, EventArgs e)
        {
            Showdata();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
