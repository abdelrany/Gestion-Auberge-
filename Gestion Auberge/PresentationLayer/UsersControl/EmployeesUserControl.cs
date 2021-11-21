using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Auberge.PresentationLayer.UsersControl
{
    public partial class EmployeesUserControl : UserControl
    {
        public EmployeesUserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source = .\sqlexpress ; initial catalog = hostel ; integrated security = yes");
        private void Receptiontab_Click(object sender, System.EventArgs e)
        {

        }

        private void saverec_Click(object sender, System.EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employees values ('" + idrec.Text + "','" + fnrec.Text + "','" + lnrec.Text + "','" + genderrec.SelectedItem + "','" + statusrec.SelectedItem + "','" + natiorec.Text + "','" + numrec.Text + "','" + funcrec.SelectedItem + "','" + salaryrec.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            idrec.Clear();
            fnrec.Clear();
            lnrec.Clear();
            genderrec.Text = "";
            natiorec.Clear();
            numrec.Clear();
            funcrec.Text = "";
            salaryrec.Clear();
            statusrec.Text = "";

        }

        private void saveres_Click(object sender, System.EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employees values ('" + idres.Text + "','" + fnres.Text + "','" + lnres.Text + "','" + genderres.SelectedItem + "','" + statusres.SelectedItem + "','" + natiores.Text + "','" + numres.Text + "','" + funcres.SelectedItem + "','" + salaryres.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            idres.Clear();
            fnres.Clear();
            lnres.Clear();
            genderres.Text = "";
            natiores.Clear();
            numres.Clear();
            funcres.Text = "";
            salaryres.Clear();
            statusres.Text = "";
        }

        private void savecle_Click(object sender, System.EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employees values ('" + idcle.Text + "','" + fncle.Text + "','" + lncle.Text + "','" + gendercle.SelectedItem + "','" + statuscle.SelectedItem + "','" + natiocle.Text + "','" + numcle.Text + "','" + funccle.SelectedItem + "','" + salarycle.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            idcle.Clear();
            fncle.Clear();
            lncle.Clear();
            gendercle.Text = "";
            natiocle.Clear();
            numcle.Clear();
            funccle.Text = "";
            salarycle.Clear();
            statuscle.Text = "";
        }

        private void savemai_Click(object sender, System.EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employees values ('" + idmai.Text + "','" + fnmai.Text + "','" + lnmai.Text + "','" + gendermai.SelectedItem + "','" + statusmai.SelectedItem + "','" + natiomai.Text + "','" + nummai.Text + "','" + funcmai.SelectedItem + "','" + salarymai.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            idmai.Clear();
            fnmai.Clear();
            lnmai.Clear();
            gendermai.Text = "";
            natiomai.Clear();
            nummai.Clear();
            funcmai.Text = "";
            salarymai.Clear();
            statusmai.Text = "";
        }

        private void btnsearchemp_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(txtboxfinduser.Text) || string.IsNullOrWhiteSpace(txtboxfinduser.Text))
            {
                txtboxfinduser.Focus();

            }

            else
            {

                SqlCommand cmd1 = new SqlCommand("select count(id) from employees where id = '" + txtboxfinduser.Text + "'", con);
                con.Open();
                int exist = (int)cmd1.ExecuteScalar();
                if (exist != 0)
                {


                    SqlCommand cmd = new SqlCommand("select * from employees where id = '" + txtboxfinduser.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable ta = new DataTable();
                    ta.Load(dr);
                    metroGridemp.DataSource = ta;
                    con.Close();

                }

                else
                {
                    SqlCommand cmd = new SqlCommand("select * from employees ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable ta = new DataTable();
                    ta.Load(dr);
                    metroGridemp.DataSource = ta;
                    con.Close();
                    MessageBox.Show("Id not found please try again ! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxfinduser.Clear();
                    txtboxfinduser.Focus();
                }

                con.Close();

            }

        }

        private void metroTabPage4_Click(object sender, System.EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, System.EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, System.EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, System.EventArgs e)
        {

        }

        private void funcrec_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (funcrec.SelectedIndex == 0)
            {
                salaryrec.Text = "6500";
            }
            if (funcrec.SelectedIndex == 1)
            {
                salaryrec.Text = "6000";
            }
            if (funcrec.SelectedIndex == 2)
            {
                salaryrec.Text = "4500";
            }
            if (funcrec.SelectedIndex == 3)
            {
                salaryrec.Text = "4000";
            }
            if (funcrec.SelectedIndex == 4)
            {
                salaryrec.Text = "4000";
            }
        }

        private void funcres_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (funcres.SelectedIndex == 0)
            {
                salaryres.Text = "7000";
            }
            if (funcres.SelectedIndex == 1)
            {
                salaryres.Text = "5000";
            }
            if (funcres.SelectedIndex == 2)
            {
                salaryres.Text = "4500";
            }
            if (funcres.SelectedIndex == 3)
            {
                salaryres.Text = "4500";
            }
        }

        private void funccle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (funccle.SelectedIndex == 0)
            {
                salarycle.Text = "5000";
            }
            if (funccle.SelectedIndex == 1)
            {
                salarycle.Text = "5000";
            }
            if (funccle.SelectedIndex == 2)
            {
                salarycle.Text = "4500";
            }
            if (funccle.SelectedIndex == 3)
            {
                salarycle.Text = "4500";
            }
        }

        private void funcmai_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (funcmai.SelectedIndex == 0)
            {
                salarymai.Text = "8000";
            }
            if (funcmai.SelectedIndex == 1)
            {
                salarymai.Text = "9000";
            }
            if (funcmai.SelectedIndex == 2)
            {
                salarymai.Text = "4500";
            }
            if (funcmai.SelectedIndex == 3)
            {
                salarymai.Text = "4500";
            }
        }

        private void metroGridemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {

            if (rbupdate.Checked == true)
            {
                if (string.IsNullOrEmpty(txtboxidrud.Text) || string.IsNullOrWhiteSpace(txtboxidrud.Text))
                {
                    txtboxidrud.Focus();
                }

                else if (string.IsNullOrEmpty(cbrud.Text) || string.IsNullOrWhiteSpace(cbrud.Text))
                {
                    cbrud.Focus();
                }





                if (cbrud.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("update employees set  ID = '" + txtboxdatarud.Text + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (cbrud.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("update employees set  FName = '" + txtboxdatarud.Text + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (cbrud.SelectedIndex == 2)
                {
                    SqlCommand cmd = new SqlCommand("update employees set  LName = '" + txtboxdatarud.Text + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (cbrud.SelectedIndex == 3)
                {
                    txtboxdatarud.Visible = false;
                    cbgenderrud.Visible = true;
                    SqlCommand cmd = new SqlCommand("update employees set  Gender = '" + cbgenderrud.SelectedItem.ToString() + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (cbrud.SelectedIndex == 4)
                {
                    SqlCommand cmd = new SqlCommand("update employees set  Status = '" + cbstatusrud.SelectedItem.ToString() + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (cbrud.SelectedIndex == 5)
                {
                    SqlCommand cmd = new SqlCommand("update employees set  Nationality = '" + txtboxdatarud.Text + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (cbrud.SelectedIndex == 6)
                {
                    SqlCommand cmd = new SqlCommand("update employees set  Phone = '" + maskedtxtboxrud.Text + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (cbrud.SelectedIndex == 7)
                {
                    SqlCommand cmd = new SqlCommand("update employees set  [Function] = '" + txtboxfuncrud.Text + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (cbrud.SelectedIndex == 8)
                {
                    SqlCommand cmd = new SqlCommand("update employees set  Salary = '" + txtboxdatarud.Text + "' where id = '" + txtboxidrud.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            else if (rbdelete.Checked == true)
            {

                if (string.IsNullOrEmpty(txtboxidrud.Text) || string.IsNullOrWhiteSpace(txtboxidrud.Text))
                {
                    txtboxidrud.Focus();
                }
                SqlCommand cmd = new SqlCommand("delete from employees where id = '" + txtboxidrud.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }


        }

        private void cbrud_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbrud.SelectedIndex == 0)
            {
                maskedtxtboxrud.Visible = false;
                cbgenderrud.Visible = false;
                txtboxdatarud.Visible = true;
                cbstatusrud.Visible = false;
                txtboxfuncrud.Visible = false;
                lboxfuncrud.Visible = false;
                txtboxfuncrud.Clear();
                lbladdfunc.Visible = false;
                addfunc.Visible = false;
            }
            if (cbrud.SelectedIndex == 1)
            {
                maskedtxtboxrud.Visible = false;
                cbgenderrud.Visible = false;
                txtboxdatarud.Visible = true;
                cbstatusrud.Visible = false;
                txtboxfuncrud.Visible = false;
                lboxfuncrud.Visible = false;
                txtboxfuncrud.Clear();
                lbladdfunc.Visible = false;
                addfunc.Visible = false;
            }
            if (cbrud.SelectedIndex == 2)
            {
                maskedtxtboxrud.Visible = false;
                cbgenderrud.Visible = false;
                txtboxdatarud.Visible = true;
                cbstatusrud.Visible = false;
                txtboxfuncrud.Visible = false;
                lboxfuncrud.Visible = false;
                txtboxfuncrud.Clear();
                lbladdfunc.Visible = false;
                addfunc.Visible = false;
            }

            if (cbrud.SelectedIndex == 3)
            {
                maskedtxtboxrud.Visible = false;
                txtboxdatarud.Visible = false;
                cbgenderrud.Visible = true;
                cbstatusrud.Visible = false;
                txtboxfuncrud.Visible = false;
                cbgenderrud.SelectedIndex = -1;
                lboxfuncrud.Visible = false;
                txtboxfuncrud.Clear();
                lbladdfunc.Visible = false;
                addfunc.Visible = false;
            }
            if (cbrud.SelectedIndex == 4)
            {
                maskedtxtboxrud.Visible = false;
                cbgenderrud.Visible = false;
                txtboxdatarud.Visible = false;
                cbstatusrud.Visible = true;
                txtboxfuncrud.Visible = false;
                cbstatusrud.SelectedIndex = -1;
                lboxfuncrud.Visible = false;
                txtboxfuncrud.Clear();
                lbladdfunc.Visible = false;
                addfunc.Visible = false;
            }
            if (cbrud.SelectedIndex == 5)
            {
                lboxfuncrud.Visible = false;
                maskedtxtboxrud.Visible = false;
                cbgenderrud.Visible = false;
                txtboxdatarud.Visible = true;
                cbstatusrud.Visible = false;
                txtboxfuncrud.Visible = false;
                txtboxfuncrud.Clear();
                lbladdfunc.Visible = false;
                addfunc.Visible = false;
            }

            if (cbrud.SelectedIndex == 6)
            {
                lboxfuncrud.Visible = false;
                maskedtxtboxrud.Visible = true;
                cbgenderrud.Visible = false;
                txtboxdatarud.Visible = false;
                cbstatusrud.Visible = false;
                txtboxfuncrud.Visible = false;
                txtboxfuncrud.Clear();
                lbladdfunc.Visible = false;
                addfunc.Visible = false;
            }
            if (cbrud.SelectedIndex == 7)
            {
                maskedtxtboxrud.Visible = false;
                cbgenderrud.Visible = false;
                txtboxdatarud.Visible = false;
                cbstatusrud.Visible = false;
                txtboxfuncrud.Visible = true;
                lboxfuncrud.SelectedIndex = -1;
                txtboxfuncrud.Clear();
                lboxfuncrud.Visible = true;
                lbladdfunc.Visible = false;
                addfunc.Visible = true;
            }
            if (cbrud.SelectedIndex == 8)
            {
                lboxfuncrud.Visible = false;
                maskedtxtboxrud.Visible = false;
                cbgenderrud.Visible = false;
                txtboxdatarud.Visible = true;
                cbstatusrud.Visible = false;
                txtboxfuncrud.Visible = false;
                txtboxfuncrud.Clear();
                lbladdfunc.Visible = false;
                addfunc.Visible = false;
            }

        }

        private void EmployeesUserControl_Load(object sender, System.EventArgs e)
        {
            txtboxpasstonewpost.Visible = false;
            lbladdfunc.Visible = false;
            addfunc.Visible = false;
            lboxfuncrud.Visible = false;
            maskedtxtboxrud.Visible = false;
            txtboxdatarud.Visible = true;
            cbgenderrud.Visible = false;
            cbstatusrud.Visible = false;
            txtboxfuncrud.Visible = false;

            txtboxfinduser.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employees ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable ta = new DataTable();
            ta.Load(dr);
            metroGridemp.DataSource = ta;
            con.Close();
        }

        private void txtboxfinduser_TextChanged(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(txtboxfinduser.Text) || string.IsNullOrWhiteSpace(txtboxfinduser.Text))
            {
                txtboxfinduser.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from employees ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable ta = new DataTable();
                ta.Load(dr);
                metroGridemp.DataSource = ta;
                con.Close();
            }
        }

        private void guna2Button1_Click_1(object sender, System.EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employees ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable ta = new DataTable();
            ta.Load(dr);
            metroGridemp.DataSource = ta;
            con.Close();
        }

        private void rbdelete_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbdelete.Checked == true)
            {
                txtboxdatarud.Clear();
                cbrud.SelectedIndex = -1;
                cbgenderrud.SelectedIndex = -1;
                cbstatusrud.SelectedIndex = -1;
                txtboxfuncrud.Clear();
                lbladdfunc.Hide();
                addfunc.Hide();
                maskedtxtboxrud.Clear();
                lboxfuncrud.Hide();

            }

        }

        private void cbgenderrud_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void lboxfuncrud_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lboxfuncrud.SelectedItem == null)
            {

            }
            else if (lboxfuncrud.SelectedItem != null)
            {
                txtboxfuncrud.Text = lboxfuncrud.SelectedItem.ToString();
            }
            else
            {
                txtboxfuncrud.Clear();
            }


        }

        private void Linkmore_Click(object sender, System.EventArgs e)
        {

        }

        private void lncle_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtboxfuncrud_TextChanged(object sender, EventArgs e)
        {

        }

        private void addfunc_MouseHover(object sender, EventArgs e)
        {
            lbladdfunc.Visible = true;
        }

        private void addfunc_MouseLeave(object sender, EventArgs e)
        {
            lbladdfunc.Visible = false;
        }

        private void addfunc_Click(object sender, EventArgs e)
        {
            txtboxnewpost.Visible = true;
            txtboxpasstonewpost.Visible = true;
        }

        private void txtboxpasstonewpost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand cmd = new SqlCommand("select count(password) from login where password = '" + txtboxpasstonewpost.Text + "' ", con);
                con.Open();
                int exist = (int)cmd.ExecuteScalar();
                if (exist != 0)
                {
                    txtboxnewpost.Visible = true;
                    txtboxpasstonewpost.Hide();
                    txtboxpasstonewpost.Clear();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxpasstonewpost.Clear();
                    txtboxpasstonewpost.Focus();
                }
            }
        }

        private void txtboxnewpost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxnewpost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lboxfuncrud.Items.Add(txtboxnewpost.Text);
                txtboxnewpost.Clear();
            }
        }

        private void txtboxpasstonewpost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
