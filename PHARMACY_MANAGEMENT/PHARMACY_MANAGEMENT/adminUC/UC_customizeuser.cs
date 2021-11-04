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
    public partial class UC_customizeuser : UserControl
    {
        userfunction fn = new userfunction();
        string query;
        DataSet ds;
        string username;
        string currentuser ="";

        public UC_customizeuser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentuser = value; }
        }

        private void UC_customizeuser_Load(object sender, EventArgs e)
        {
            query = " select * from users";
            ds = fn.getdata(query);
            usergridview.DataSource = ds.Tables[0];

        }

        

        private void txtboxsearch_TextChanged(object sender, EventArgs e)
        {
            query = " select * from users where username like '" + txtboxsearch.Text+"%'";
            ds = fn.getdata(query);
            usergridview.DataSource = ds.Tables[0];
        }
        /*int flag = 0; */
        private void usergridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = usergridview.SelectedRows[0].Cells[5].Value.ToString();
                /*flag = 1;*/
            }
            catch
            {

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {

                if (currentuser != username && username != "")
                {
                    query = "delete from users where username ='" + username + "'";
                    fn.setdata(query, "User Successfully Deleted");
                    UC_customizeuser_Load(this, null);
                    username = "";
                }
                else
                {
                    MessageBox.Show("Either You are trying to delete Your own Profile or Profile that Does'nt Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            UC_customizeuser_Load(this, null);
        }
    }
}
