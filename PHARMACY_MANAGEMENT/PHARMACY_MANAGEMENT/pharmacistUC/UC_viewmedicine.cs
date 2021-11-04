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
    public partial class UC_viewmedicine : UserControl
    {
        userfunction fn = new userfunction();
        string query;
        DataSet ds;
        string medid;


        public UC_viewmedicine()
        {
            InitializeComponent();
        }

        private void UC_viewmedicine_Load(object sender, EventArgs e)
        {
            query = "select * from meds";
            ds = fn.getdata(query);
            meddataview.DataSource = ds.Tables[0];


        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from meds where medname like '" + txtsearch.Text + "%'";
            ds = fn.getdata(query);
            meddataview.DataSource = ds.Tables[0];

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            UC_viewmedicine_Load(this, null);
        }


        private void meddataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medid = meddataview.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from meds where medid = '" + medid + "'";
                fn.setdata(query, "MEDICINE DELETED SUCCESSFULLY");
                UC_viewmedicine_Load(this, null);
            }
        }
        
        /*private void meddataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medid = meddataview.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch(Exception E)
            {
                MessageBox.Show("Message");
            }
        }*/

        private void btnexport_Click(object sender, EventArgs e)
        {
            if(meddataview.Rows.Count>0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for(int i= 1; i<meddataview.Columns.Count +1; i++)
                {
                     xcelApp.Cells[1, i] = meddataview.Columns[i - 1].HeaderText;
                }
                for(int i=0; i< meddataview.Rows.Count; i++)
                {
                    for (int j = 0; j < meddataview.Columns.Count; j++)
                    {
                        string x = Convert.ToString(meddataview.Rows[i].Cells[j].Value);
         
                        xcelApp.Cells[i + 2, j + 1] = x;
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
