using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer
{
    public partial class RestaurantUserControl : UserControl
    {
        public RestaurantUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {

        }

        private void RestaurantUserControl_Load(object sender, System.EventArgs e)
        {
            nud1.Enabled = false;
            nud2.Enabled = false;
            nud3.Enabled = false;
            nud4.Enabled = false;
            nud5.Enabled = false;
            nud6.Enabled = false;
            nud7.Enabled = false;
            nud8.Enabled = false;
            nud9.Enabled = false;
            nud11.Enabled = false;
            nud22.Enabled = false;
            nud55.Enabled = false;
            nud33.Enabled = false;
            guna2NumericUpDown14.Enabled = false;
            guna2NumericUpDown15.Enabled = false;
            guna2NumericUpDown16.Enabled = false;
            guna2NumericUpDown17.Enabled = false;
            guna2NumericUpDown18.Enabled = false;
            guna2NumericUpDown19.Enabled = false;
            guna2NumericUpDown20.Enabled = false;
            guna2NumericUpDown21.Enabled = false;
            guna2NumericUpDown22.Enabled = false;
            guna2NumericUpDown23.Enabled = false;
            guna2NumericUpDown24.Enabled = false;
            guna2NumericUpDown25.Enabled = false;
            guna2NumericUpDown26.Enabled = false;
            guna2NumericUpDown27.Enabled = false;
            guna2NumericUpDown28.Enabled = false;
            guna2NumericUpDown29.Enabled = false;
            guna2NumericUpDown30.Enabled = false;
            guna2NumericUpDown31.Enabled = false;
            guna2NumericUpDown32.Enabled = false;
            guna2NumericUpDown33.Enabled = false;
            guna2NumericUpDown34.Enabled = false;
            guna2NumericUpDown35.Enabled = false;
            guna2NumericUpDown36.Enabled = false;
            guna2NumericUpDown37.Enabled = false;
            guna2NumericUpDown38.Enabled = false;
            guna2NumericUpDown39.Enabled = false;
            guna2NumericUpDown40.Enabled = false;
        }

        private void pictureBoxFruits_Click(object sender, System.EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxVegetable_Click(object sender, System.EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxCondiments_Click(object sender, System.EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SwitchStartinspecting_CheckedChanged(object sender, System.EventArgs e)
        {

            if (SwitchStartinspecting.Checked == true)
            {
                if (string.IsNullOrEmpty(txtboxfname.Text) || string.IsNullOrWhiteSpace(txtboxfname.Text))
                {
                    txtboxfname.Focus();
                    SwitchStartinspecting.Checked = false;

                }

                else if (string.IsNullOrEmpty(txtboxlname.Text) || string.IsNullOrWhiteSpace(txtboxlname.Text))
                {
                    txtboxlname.Focus();
                    SwitchStartinspecting.Checked = false;
                }
                else
                {
                    nud1.Enabled = true;
                    nud2.Enabled = true;
                    nud3.Enabled = true;
                    nud4.Enabled = true;
                    nud5.Enabled = true;
                    nud6.Enabled = true;
                    nud7.Enabled = true;
                    nud8.Enabled = true;
                    nud9.Enabled = true;
                    nud11.Enabled = true;
                    nud22.Enabled = true;
                    nud55.Enabled = true;
                    nud33.Enabled = true;
                    guna2NumericUpDown14.Enabled = true;
                    guna2NumericUpDown15.Enabled = true;
                    guna2NumericUpDown16.Enabled = true;
                    guna2NumericUpDown17.Enabled = true;
                    guna2NumericUpDown18.Enabled = true;
                    guna2NumericUpDown19.Enabled = true;
                    guna2NumericUpDown20.Enabled = true;
                    guna2NumericUpDown21.Enabled = true;
                    guna2NumericUpDown22.Enabled = true;
                    guna2NumericUpDown23.Enabled = true;
                    guna2NumericUpDown24.Enabled = true;
                    guna2NumericUpDown25.Enabled = true;
                    guna2NumericUpDown26.Enabled = true;
                    guna2NumericUpDown27.Enabled = true;
                    guna2NumericUpDown28.Enabled = true;
                    guna2NumericUpDown29.Enabled = true;
                    guna2NumericUpDown30.Enabled = true;
                    guna2NumericUpDown31.Enabled = true;
                    guna2NumericUpDown32.Enabled = true;
                    guna2NumericUpDown33.Enabled = true;
                    guna2NumericUpDown34.Enabled = true;
                    guna2NumericUpDown35.Enabled = true;
                    guna2NumericUpDown36.Enabled = true;
                    guna2NumericUpDown37.Enabled = true;
                    guna2NumericUpDown38.Enabled = true;
                    guna2NumericUpDown39.Enabled = true;
                    guna2NumericUpDown40.Enabled = true;
                }

            }
            else
            {
                nud1.Enabled = false;
                nud2.Enabled = false;
                nud3.Enabled = false;
                nud4.Enabled = false;
                nud5.Enabled = false;
                nud6.Enabled = false;
                nud7.Enabled = false;
                nud8.Enabled = false;
                nud9.Enabled = false;
                nud11.Enabled = false;
                nud22.Enabled = false;
                nud55.Enabled = false;
                nud33.Enabled = false;
                guna2NumericUpDown14.Enabled = false;
                guna2NumericUpDown15.Enabled = false;
                guna2NumericUpDown16.Enabled = false;
                guna2NumericUpDown17.Enabled = false;
                guna2NumericUpDown18.Enabled = false;
                guna2NumericUpDown19.Enabled = false;
                guna2NumericUpDown20.Enabled = false;
                guna2NumericUpDown21.Enabled = false;
                guna2NumericUpDown22.Enabled = false;
                guna2NumericUpDown23.Enabled = false;
                guna2NumericUpDown24.Enabled = false;
                guna2NumericUpDown25.Enabled = false;
                guna2NumericUpDown26.Enabled = false;
                guna2NumericUpDown27.Enabled = false;
                guna2NumericUpDown28.Enabled = false;
                guna2NumericUpDown29.Enabled = false;
                guna2NumericUpDown30.Enabled = false;
                guna2NumericUpDown31.Enabled = false;
                guna2NumericUpDown32.Enabled = false;
                guna2NumericUpDown33.Enabled = false;
                guna2NumericUpDown34.Enabled = false;
                guna2NumericUpDown35.Enabled = false;
                guna2NumericUpDown36.Enabled = false;
                guna2NumericUpDown37.Enabled = false;
                guna2NumericUpDown38.Enabled = false;
                guna2NumericUpDown39.Enabled = false;
                guna2NumericUpDown40.Enabled = false;
            }
        }

        private void btnloadrestaurant_Click(object sender, System.EventArgs e)
        {

        }

        private void labelStartinspecting_Click(object sender, System.EventArgs e)
        {

        }
    }
}
