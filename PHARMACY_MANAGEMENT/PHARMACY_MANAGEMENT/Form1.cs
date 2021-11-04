using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PHARMACY_MANAGEMENT
{
    public partial class Form1 : Form
    {
        userfunction fn = new userfunction();
        string query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getdata(query);

            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                if (ds.Tables[0].Rows.Count == 0)
                {
                    if (txtusername.Text == "admin" && txtpassword.Text == "admin")
                    {
                        admin ad = new admin();
                        ad.Show();
                        this.Hide();

                    }
                }
                else
                {
                    SqlConnection con = new SqlConnection("data source = localhost\\SQLEXPRESS; database = PHARMACY; integrated security = true");
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from users where username = '" + txtusername.Text + "' and pass='" + txtpassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if(dt.Rows[0][0].ToString()=="1")
                    {
                        query = "select * from users where username = '" + txtusername.Text + "' and pass='" + txtpassword.Text + "'";
                        ds = fn.getdata(query);

                        string userrole = ds.Tables[0].Rows[0][1].ToString();
                        if (userrole == "Administrator")
                        {
                            admin ad = new admin(txtusername.Text);
                            ad.Show();
                            this.Hide();
                        }
                        else
                        {
                            pharmacist ph = new pharmacist();
                            ph.Show();
                            this.Hide();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void hidepass_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                showpass.BringToFront();
                txtpassword.PasswordChar = '*';
            }
        }

        private void showpass_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                hidepass.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }
    }
}