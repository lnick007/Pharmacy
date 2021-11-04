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
    public partial class UC_profile : UserControl
    {
        userfunction fn = new userfunction();
        string query;
        DataSet ds;
        public UC_profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { usernamelabel.Text = value; } 
           
            
        }

        private void UC_profile_Enter(object sender, EventArgs e)
        {
            query = "Select * from users where username = '" + usernamelabel.Text + "'";
            ds = fn.getdata(query);
            userrolecombobox.Text = ds.Tables[0].Rows[0][1].ToString();
            txtfullname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtphno.Text = ds.Tables[0].Rows[0][3].ToString();
            txtemailid.Text = ds.Tables[0].Rows[0][4].ToString();
            txtpassword.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            UC_profile_Enter(this, null);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string userrole = userrolecombobox.Text;
            string fullname = txtfullname.Text;
            Int64 phno = Int64.Parse (txtphno.Text);
            string emailid = txtemailid.Text;
            string username = usernamelabel.Text;
            string pass = txtpassword.Text;


            query = "update users set userrole ='" + userrole + "', fullname ='" + fullname + "', phno = " + phno + ", emailid = '" + emailid + "', pass ='" + pass + "' where username ='" + username + "'";
            fn.setdata(query, "Profile Succesfully Updated ");

        }
    }
}
