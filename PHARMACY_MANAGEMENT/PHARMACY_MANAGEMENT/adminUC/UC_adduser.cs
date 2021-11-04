using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARMACY_MANAGEMENT.adminUC
{
    public partial class UC_adduser : UserControl
    {
        userfunction fn = new userfunction();
        string query;

        public UC_adduser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtuserrole.SelectedIndex = -1;
            txtfullname.Clear();
            txtphno.Clear();
            txtemailid.Clear();
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string userrole = txtuserrole.Text;
            string fullname = txtfullname.Text;
            Int64 phno = Int64.Parse(txtphno.Text);
            string emailid = txtemailid.Text;
            string username = txtusername.Text;
            string pass = txtpassword.Text;

            try
            {
                query = "insert into users (userrole, fullname, phno, emailid, username, pass) values ('" + userrole + "','" + fullname + "'," + phno + ",'" + emailid + "','" + username + "','" + pass + "')";
                fn.setdata(query, "Sign In Successful");
            }
            catch(Exception)
            {
                MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hidepass_Click_1(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                showpass.BringToFront();
                txtpassword.PasswordChar = '*';
            }
        }

        private void showpass_Click_1(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                hidepass.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
