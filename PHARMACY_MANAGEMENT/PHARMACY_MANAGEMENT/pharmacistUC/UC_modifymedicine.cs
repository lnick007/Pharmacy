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

namespace PHARMACY_MANAGEMENT.pharmacistUC
{
    public partial class UC_modifymedicine : UserControl
    {
        userfunction fn = new userfunction();
        string query;
        DataSet ds;
        public UC_modifymedicine()
        {
            InitializeComponent();
        }


        

        private void btnreset_Click(object sender, EventArgs e)
        {
            btnsearch_Click_1(this, null);
           
        }
        Int64 totalquantity;

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtmedid.Text != "" && txtmedname.Text != "" && txtcompname.Text != "" && txtquantity.Text != "" && txtppu.Text != "")
            {
                string medname = txtmedname.Text;
                string compname = txtcompname.Text;
                string mfgdate = DateTime.Parse(txtmfgdate.Text).ToString("yyyy-MM-dd");
                string expdate = DateTime.Parse(txtexpdate.Text).ToString("yyyy-MM-dd");
                Int64 quantity = Int64.Parse(txtquantity.Text);
                Int64 addquantity = Int64.Parse(qtyupdown.Text);
                float ppu = float.Parse(txtppu.Text);

                totalquantity = quantity + addquantity;

                query = "update meds set medname= '" + medname + "',compname ='" + compname + "',mfgdate ='" + mfgdate + "',expdate ='" + expdate + "',quantity =" + totalquantity + ",priceperunit=" + ppu + " where medid = '" + txtmedid.Text + "'";
                fn.setdata(query, "MEDICINE DETAILS UPDATED");
            }
            else
            {
                MessageBox.Show("Please enter all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              
        }

        private void UC_modifymedicine_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = localhost\\SQLEXPRESS; database = PHARMACY; integrated security = true";
            query = "select medname from meds";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Connection = con;
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            AutoCompleteStringCollection autofill = new AutoCompleteStringCollection();
            while(sdr.Read())
            {
                autofill.Add(sdr.GetString(0));
            }
            txtmedname.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmedname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmedname.AutoCompleteCustomSource = autofill;
            con.Close();
            
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            if (txtmedname.Text != "")

            {
                query = "select * from meds where medname ='" + txtmedname.Text + "'";
                ds = fn.getdata(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtmedid.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtcompname.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtmfgdate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtexpdate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtquantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtppu.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine exists with name '" + txtmedname.Text + "'", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                txtmedid.Clear();
                txtmedname.Clear();
                txtcompname.Clear();
                txtmfgdate.ResetText();
                txtexpdate.ResetText();
                txtquantity.Clear();
                txtppu.Clear();
                if (qtyupdown.Text != "0")
                {
                    qtyupdown.Text = "0";
                }
            }
        }

        private void txtmedname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
