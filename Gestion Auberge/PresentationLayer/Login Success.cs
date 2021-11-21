using System;
using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer
{
    public partial class Login_Success : Form
    {
        public string usernamecon;

        public Login_Success()
        {
            InitializeComponent();

            //this.toolStripStatusLabelComputerName.Text = " The computer name is : " + Environment.MachineName;
        }

        private void Login_Success_Load(object sender, EventArgs e)
        {
            time.Start();
            labeltime.Text = usernamecon;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            homeUserControl1.BringToFront();
            activityUserControl1.SendToBack();
            cleaningUserControl1.SendToBack();
            restaurantUserControl1.SendToBack();
            reservationUserControl1.SendToBack();
            settingsUserControl1.SendToBack();
            employeesUserControl1.SendToBack();

        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnActivity.Height;
            SidePanel.Top = btnActivity.Top;
            activityUserControl1.BringToFront();

        }


        private void btnCleaning_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCleaning.Height;
            SidePanel.Top = btnCleaning.Top;
            cleaningUserControl1.BringToFront();
        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnRestaurant.Height;
            SidePanel.Top = btnRestaurant.Top;
            restaurantUserControl1.BringToFront();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnReservation.Height;
            SidePanel.Top = btnReservation.Top;
            reservationUserControl1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEmployee.Height;
            SidePanel.Top = btnEmployee.Top;
            employeesUserControl1.BringToFront();

        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSetting.Height;
            SidePanel.Top = btnSetting.Top;
            settingsUserControl1.BringToFront();

        }


        private void btnlogout_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Do you want to Exit !!", "Session Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                time.Stop();
                Application.Exit();
            }
            //btnActivity.BringToFront();
        }

        private void labeluser_Click(object sender, EventArgs e)
        {

        }

        private void time_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("dd-MMMM-yyyy hh:mm:ss tt");
        }
    }
}
