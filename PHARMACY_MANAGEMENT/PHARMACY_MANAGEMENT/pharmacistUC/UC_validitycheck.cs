using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARMACY_MANAGEMENT.pharmacistUC
{
    public partial class UC_validitycheck : UserControl
    {
        userfunction fn = new userfunction();
        String query;
        DataSet ds;
        public UC_validitycheck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtcheck.SelectedIndex==1)
            {
                query = " select * from meds where expdate>=getdate()";
                ds = fn.getdata(query);
                valcheckdataview.DataSource = ds.Tables[0];
                setlabel.Text = "Valid Medicines";
                setlabel.ForeColor = Color.Black;

            }
            else if(txtcheck.SelectedIndex ==2) 
            {
                query = " select * from meds where expdate<=getdate()";
                ds = fn.getdata(query);
                valcheckdataview.DataSource = ds.Tables[0];
                setlabel.Text = "Expired Medicines";
                setlabel.ForeColor = Color.Red;
            }
            else if (txtcheck.SelectedIndex ==3)
            {
                query = " select * from meds ";
                ds = fn.getdata(query);
                valcheckdataview.DataSource = ds.Tables[0];
                setlabel.Text = "";
                setlabel.ForeColor = Color.Black;
            }

        }

        private void UC_validitycheck_Load(object sender, EventArgs e)
        {
            setlabel.Text = "";
        }
    }
}
