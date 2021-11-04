using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARMACY_MANAGEMENT
{
    public partial class admin : Form
    {
        string user = "";


        public admin()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public admin(string username)
        {
            InitializeComponent();
            usernamelabel.Text = username;
            user = username;
            uC_customizeuser1.ID = ID;
            uC_profile1.ID = ID;
            
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            uC_profile1.Visible = true;
            uC_profile1.BringToFront();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            uC_adduser1.Visible = true;
            uC_adduser1.BringToFront();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            uC_adduser1.Visible = false;
            uC_customizeuser1.Visible = false;
            uC_profile1.Visible = false;
            
        }

        private void btncustomizeuser_Click(object sender, EventArgs e)
        {
            uC_customizeuser1.Visible = true;
            uC_customizeuser1.BringToFront();
        }

    }
}
