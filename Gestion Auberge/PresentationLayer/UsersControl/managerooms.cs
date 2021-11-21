using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Gestion_Auberge.PresentationLayer.UsersControl
{
    public partial class managerooms : Form
    {
        public managerooms()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txt_room_no.Text == "" || cmb_room_type.Text == "" || dtp_date.Text == "" || cmd_room_free_paid.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    String str = "Insert Into rooms (r_no,r_type,date,r_free_paid)Values('" + txt_room_no.Text + "','" + cmb_room_type.Text + "','" + dtp_date.Text + "','" + cmd_room_free_paid.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    String str2 = "Select max(r_no) From rooms";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();
                        MessageBox.Show("Room Record Added Successfully ...!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Room Record Adding Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please , Enter Anthor Room No. , This No. Is Already Used ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        public void showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

            con.Open();

            String str = "Select * From rooms";

            SqlCommand cmd = new SqlCommand(str, con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            roomsDataGridView.DataSource = dt;

            con.Close();

        }
        public void clear()
        {
            txt_room_no.Text = "";
            cmb_room_type.Text = "";
            dtp_date.Text = "";
            cmd_room_free_paid.Text = "";
            txt_room_no.Focus();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (txt_room_no.Text == "" || cmb_room_type.Text == "" || dtp_date.Text == "" || cmd_room_free_paid.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    String str = "Delete From rooms Where r_no = '" + txt_room_no.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    String str2 = "Select max(r_no) From rooms";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();
                        MessageBox.Show("Room's Record Deleted Successfully ...!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Room Record Deleted Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txt_room_no.Text == "" || cmb_room_type.Text == "" || dtp_date.Text == "" || cmd_room_free_paid.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    String str = "Update rooms Set r_type = '" + cmb_room_type.Text + "',date = '" + dtp_date.Text + "',r_free_paid = '" + cmd_room_free_paid.Text + "' Where r_no = '" + txt_room_no.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    String str2 = "Select max(r_no) From rooms";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();
                        MessageBox.Show("Room's Record Updated Successfully ...!", "Room's Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Room's Record Updating is Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please , Enter Another Room No. , This No. Is Already Used ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void managerooms_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

            con.Open();

            String str = "Select r_type,date,r_free_paid From rooms Where r_no = '" + txt_room_no.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cmb_room_type.Text = dr.GetValue(0).ToString();
                dtp_date.Text = dr.GetValue(1).ToString();
                cmd_room_free_paid.Text = dr.GetValue(2).ToString();
            }
            else
            {

                MessageBox.Show(" This Room No. is Invalid, Please Insert The Correct No.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            con.Close();
        }
    }
}
