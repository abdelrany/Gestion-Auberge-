using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer
{
    public partial class ReservationUserControl : UserControl
    {
        public ReservationUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            PresentationLayer.UsersControl.addclient f = new UsersControl.addclient();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, System.EventArgs e)
        {
            UsersControl.managerooms fmr = new UsersControl.managerooms();
            fmr.ShowDialog();
        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {
            UsersControl.reservationmanage frem = new UsersControl.reservationmanage();
            frem.ShowDialog();
        }

        private void ReservationUserControl_Load(object sender, System.EventArgs e)
        {
            totalclient();
            totalrooms();
            totalreservations();
        }
        public void totalclient()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select Count(c_id)From client";

            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            lbl_clients.Text = rows_count.ToString();

        }
        public void totalrooms()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select Count(r_no)From rooms";

            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            lbl_rooms.Text = rows_count.ToString();

        }

        public void totalreservations()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");

            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select Count(reserv_id)From reservation";

            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            lbl_reservations.Text = rows_count.ToString();

        }
    }
}
