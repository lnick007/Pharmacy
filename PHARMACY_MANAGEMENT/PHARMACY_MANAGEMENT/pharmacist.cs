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
    public partial class pharmacist : Form
    {
        public pharmacist()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }


        private void pharmacist_Load(object sender, EventArgs e)
        {
            uC_addmedicine1.Visible = false;
            uC_viewmedicine1.Visible = false;
            uC_modifymedicine1.Visible = false;
            uC_validitycheck1.Visible = false;
        }

        private void btnaddmedicine_Click(object sender, EventArgs e)
        {
            uC_addmedicine1.Visible = true;
            uC_addmedicine1.BringToFront();
        }

        private void btnviewmedicine_Click(object sender, EventArgs e)
        {
            uC_viewmedicine1.Visible = true;
            uC_viewmedicine1.BringToFront();
        }

        private void btnmodifymedicine_Click(object sender, EventArgs e)
        {
            uC_modifymedicine1.Visible = true;
            uC_modifymedicine1.BringToFront();
        }

        private void btnvaliditycheck_Click(object sender, EventArgs e)
        {
            uC_validitycheck1.Visible = true;
            uC_validitycheck1.BringToFront();
        }

        private void btnsellmedicine_Click(object sender, EventArgs e)
        {
            sellmedicine sm = new sellmedicine ();
            sm.Show();
            this.Hide();
        }
    }
}
