using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, System.EventArgs e)
        {
            webBrowser1.Navigate(txtboxurl.Text);
        }

        private void precedent_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void suivant_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
