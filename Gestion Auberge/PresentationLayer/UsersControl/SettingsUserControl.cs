using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer.UsersControl
{
    public partial class SettingsUserControl : UserControl
    {

        public SettingsUserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog = hostel;Integrated Security=True");
        private void pictureBoxFemale_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFemale.Image = new Bitmap(open.FileName);
                pictureBoxFemale.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxFemale.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            Image img = pictureBoxFemale.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into login(img) values(@img)", con);
            cmd.Parameters.AddWithValue("@img", arr);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {
            this.txtconnectedat.Text = "" + DateTimeOffset.Now;
            SqlCommand cmdd = new SqlCommand("select Username from login ", con);
            con.Open();
            cmdd.ExecuteNonQuery();
            con.Close();
            SqlCommand cmd = new SqlCommand("select UserType from login where Username = '" + txtboxusernamesetting.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void txtconnectedat_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxMale_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMale.Image = new Bitmap(open.FileName);
                pictureBoxMale.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxMale.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            Image img = pictureBoxMale.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            SqlCommand cmd = new SqlCommand("insert into login(img) values(@img)", con);
            cmd.Parameters.AddWithValue("@img", arr);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into login(Username,Password,UserType) values ('" + txtboxnewusername.Text + "','" + txtboxnewuserpass.Text + "','" + ComboBoxusertype.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update login(Username,Password,UserType) set  Username = '" + guna2TextBox1.Text + "',Password = '" + guna2TextBox2.Text + "',UserType = '" + guna2ComboBox1.SelectedItem.ToString() + "'  where Username = '" + guna2TextBox1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from login where Username = '" + guna2TextBox1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmdd = new SqlCommand("select Username from login ", con);
            con.Open();
            cmdd.ExecuteNonQuery();
            con.Close();
            SqlCommand cmd = new SqlCommand("select UserType from login where Username = '" + txtboxusernamesetting.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txtboxusernamesetting_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
