using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer.UsersControl
{
    public partial class reservationmanage : Form
    {
        public reservationmanage()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txt_reservatoin_id.Text == "" || txt_client_id.Text == "" || cmb_room_type.Text == "" || cmb_room_no.Text == "" || dtp_date_in.Text == "" || dtp_date_out.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    String str = "Insert Into reservation (reserv_id,client_id,room_type,room_no,date_in,date_out)Values('" + txt_reservatoin_id.Text + "','" + txt_client_id.Text + "','" + cmb_room_type.Text + "','" + cmb_room_no.Text + "','" + dtp_date_in.Text + "','" + dtp_date_out.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    String str2 = "Select max(reserv_id) From reservation";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();
                        MessageBox.Show("Reservation Successfull ...!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Reservation Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please , Enter Another ID , This ID Is Already Used ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
        public void showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

            con.Open();

            String str = "Select * From reservation";

            SqlCommand cmd = new SqlCommand(str, con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            reservationDataGridView.DataSource = dt;

            con.Close();

        }
        public void clear()
        {
            txt_reservatoin_id.Text = "";
            txt_client_id.Text = "";
            cmb_room_type.Text = "";
            cmb_room_no.Text = "";
            dtp_date_in.Text = "";
            dtp_date_out.Text = "";
            txt_reservatoin_id.Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_reservatoin_id.Text == "" || txt_client_id.Text == "" || cmb_room_type.Text == "" || cmb_room_no.Text == "" || dtp_date_in.Text == "" || dtp_date_out.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    String str = "Update reservation Set client_id = '" + txt_client_id.Text + "',room_type = '" + cmb_room_type.Text + "',room_no = '" + cmb_room_no.Text + "',date_in = '" + dtp_date_in.Text + "',date_out = '" + dtp_date_out.Text + "' Where reserv_id = '" + txt_reservatoin_id.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    String str2 = "Select max(reserv_id) From reservation";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();
                        MessageBox.Show("Reservation was Updated Successfully ...!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Reservation Updating Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please , Enter Another ID , This ID Is Already Used ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txt_reservatoin_id.Text == "" || txt_client_id.Text == "" || cmb_room_type.Text == "" || cmb_room_no.Text == "" || dtp_date_in.Text == "" || dtp_date_out.Text == "")
            {
                MessageBox.Show("Please Fill Up All Details ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                    con.Open();

                    String str = "Delete From reservation Where reserv_id = '" + txt_reservatoin_id.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    String str2 = "Select max(reserv_id) From reservation ";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();
                        MessageBox.Show("Reservation Record was Deleted Successfully ...!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Reservation Record Deleting Failed ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

                con.Open();

                String str = "Select client_id,room_type,room_no,date_in,date_out From reservation Where reserv_id = '" + txt_reservatoin_id.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_client_id.Text = dr.GetValue(0).ToString();
                    cmb_room_type.Text = dr.GetValue(1).ToString();
                    cmb_room_no.Text = dr.GetValue(2).ToString();
                    dtp_date_in.Text = dr.GetValue(3).ToString();
                    dtp_date_out.Text = dr.GetValue(4).ToString();
                }
                else
                {

                    MessageBox.Show(" This Reservation ID is Invalid , Insert A Correct ID", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reservationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reservationmanage_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
