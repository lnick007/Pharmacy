using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARMACY_MANAGEMENT.pharmacistUC
{
    public partial class UC_addmedicine : UserControl
    {
        userfunction fn = new userfunction();
        string query;
        public UC_addmedicine()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmedicineid.Clear();
            txtmedicinename.Clear();
            txtcompanyname.Clear();
            txtmfgdate.ResetText();
            txtexpdate.ResetText();
            txtquantity.Clear();
            txtpriceperunit.Clear();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtmedicineid.Text != "" && txtmedicinename.Text != "" && txtcompanyname.Text != "" && txtquantity.Text != "" && txtpriceperunit.Text != "")
            {
                string medid = txtmedicineid.Text;
                string medname = txtmedicinename.Text;
                string compname = txtcompanyname.Text;
                string mfgdate = DateTime.Parse(txtmfgdate.Text).ToString("yyyy-MM-dd");
                string expdate = DateTime.Parse(txtexpdate.Text).ToString("yyyy-MM-dd");
                Int64 quantity = Int64.Parse(txtquantity.Text);
                float priceperunit = float.Parse(txtpriceperunit.Text);

                query = "insert into meds (medid,medname,compname,mfgdate,expdate,quantity,priceperunit) values ('" + medid + "','" + medname + "','" + compname + "','" + mfgdate + "','" + expdate + "'," + quantity + "," + priceperunit + ")";
                fn.setdata(query, "Medicine Added Successfully");
            }
            else
            {
                MessageBox.Show("Please enter all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void generatebarcode_Click_1(object sender, EventArgs e)
        {
            string prn1 = @"
^Q20,3
^W50
^H8
^P1
^S4
^AD
^C1
^R0
~Q+0
^O0
^D0
^E18
~R255
^L
Dy2-me-dd
Th:m:s
AD,21,2,1,1,0,0E,";
            string medname = txtmedicinename.Text;
            string prn2 = @"
AD,21,35,1,1,0,0E,";
            string compname = txtcompanyname.Text;
            string prn3 = @"
B050,16,90,3,7,34,0,1,1,";
            string medid = txtmedicineid.Text;
            string mfgdate = txtmfgdate.Text;
            string barcode = (medid).PadLeft(11, '0');
            string prn4 = @"
AD,237,6,1,1,0,0E,";
            string prn5 = @"
AD,236,41,1,1,0,0E,";
            string expdate = txtexpdate.Text;
            string prn6 = @"
E";

            string finalprn = prn1 + medname + prn2 + compname + prn3 + barcode + prn4 + mfgdate + prn5 + expdate + prn6;

            StreamWriter sw = new StreamWriter("C:\\Users\\ARS\\Documents\\PHARMACY_MANAGEMENT\\barcode.txt");
            sw.Write(finalprn);
            sw.Close();
            



            Process process1 = new Process();
            process1.StartInfo.FileName = "cmd.exe";
            process1.StartInfo.Arguments = "/C Type C:\\Users\\ARS\\Documents\\PHARMACY_MANAGEMENT\\barcode.txt>\\\\DESKTOP\\Godex";
            Process proc = Process.Start(process1.StartInfo);
        }
    }
}
