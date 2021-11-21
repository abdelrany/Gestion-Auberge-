using System.Windows.Forms;

namespace Gestion_Auberge
{
    public partial class CleaningUserControl : UserControl
    {
        public CleaningUserControl()
        {
            InitializeComponent();
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
                    guna2NumericUpDown1.Enabled = true;
                    guna2NumericUpDown2.Enabled = true;
                    guna2NumericUpDown3.Enabled = true;
                    guna2NumericUpDown4.Enabled = true;
                    guna2NumericUpDown5.Enabled = true;
                    guna2NumericUpDown36.Enabled = true;
                    guna2NumericUpDown37.Enabled = true;
                    guna2NumericUpDown38.Enabled = true;
                    guna2NumericUpDown39.Enabled = true;
                    guna2NumericUpDown40.Enabled = true;
                }

            }
            else
            {
                guna2NumericUpDown1.Enabled = false;
                guna2NumericUpDown2.Enabled = false;
                guna2NumericUpDown3.Enabled = false;
                guna2NumericUpDown4.Enabled = false;
                guna2NumericUpDown5.Enabled = false;
                guna2NumericUpDown36.Enabled = false;
                guna2NumericUpDown37.Enabled = false;
                guna2NumericUpDown38.Enabled = false;
                guna2NumericUpDown39.Enabled = false;
                guna2NumericUpDown40.Enabled = false;
            }
        }
    }
}
