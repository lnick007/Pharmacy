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
    public partial class sellmedicine : Form
    {
        userfunction fn = new userfunction();
        string query;
        DataSet ds;

        SqlConnection con = new SqlConnection(@"data source = localhost\SQLEXPRESS; database = PHARMACY; integrated security = true");
        SqlCommand cmd;

        public sellmedicine()
        {
            InitializeComponent();
        }

        private void clearall()

        {
            txtmedid.Clear();
            txtmedname.Clear();
            txtexpdate.ResetText();
            txtppu.Clear();
            txtnoofunits.Clear();
        }

        private void sellmedicine_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = localhost\\SQLEXPRESS; database = PHARMACY; integrated security = true";
            query = "select medname from meds";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection = con;
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            AutoCompleteStringCollection autofill = new AutoCompleteStringCollection();
            while (sdr.Read())
            {
                autofill.Add(sdr.GetString(0));
            }
            txtmednamedosage.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmednamedosage.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmednamedosage.AutoCompleteCustomSource = autofill;
            con.Close();

            timer1.Start();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            time.Text = DateTime.Now.ToString("HH:mm:ss");


            listBoxmedicines.Items.Clear();

            query = "select medname from meds where expdate>=getdate() and quantity > '0'";
            ds = fn.getdata(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxmedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Start();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            sellmedicine_Load(this, null);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            listBoxmedicines.Items.Clear();

            query = "select medname from meds where medname like '" + txtsearch.Text + "%' and expdate >= getdate() and quantity >'0'";
            ds = fn.getdata(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxmedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxmedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnoofunits.Clear();
            string name = listBoxmedicines.GetItemText(listBoxmedicines.SelectedItem);
            txtmedname.Text = name;

            query = "select medid,expdate,priceperunit from meds where medname ='" + name + "'";
            ds = fn.getdata(query);
            txtmedid.Text = ds.Tables[0].Rows[0][0].ToString();
            txtexpdate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtppu.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtnoofunits_TextChanged(object sender, EventArgs e)
        {
            if (txtnoofunits.Text != "")
            {
                float unitprice = float.Parse(txtppu.Text);
                Int64 noofunits = Int64.Parse(txtnoofunits.Text);
                float totalamount = unitprice * noofunits;
                txttp.Text = totalamount.ToString();
            }
            else
            {
                txttp.Clear();
            }
        }
        protected int n;
        protected float totalamount = 0;
        protected Int64 quantity, newquantity;

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (txtmedid.Text != "" && txtnoofunits.Text != "")
            {
                query = "select quantity from meds where medid ='" + txtmedid.Text + "'";
                ds = fn.getdata(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newquantity = quantity - Int64.Parse(txtnoofunits.Text);

                if (newquantity >= 0)
                {
                    n = sellmedDataGridView.Rows.Add();
                    sellmedDataGridView.Rows[n].Cells[0].Value = txtmedid.Text;
                    sellmedDataGridView.Rows[n].Cells[1].Value = txtmedname.Text;
                    sellmedDataGridView.Rows[n].Cells[2].Value = txtexpdate.Text;
                    sellmedDataGridView.Rows[n].Cells[3].Value = txtppu.Text;
                    sellmedDataGridView.Rows[n].Cells[4].Value = txtnoofunits.Text;
                    sellmedDataGridView.Rows[n].Cells[5].Value = txttp.Text;

                    totalamount = totalamount + float.Parse(txttp.Text);
                    totallabel.Text = totalamount.ToString();

                    query = "update meds set quantity = '" + newquantity + "' where medid = '" + txtmedid.Text + "'";
                    fn.setdata(query, "Medicine Added To Cart");

                }
                else
                {
                    MessageBox.Show("OUT OF STOCK /n ONLY " + quantity + " LEFT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearall();
                sellmedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("SELECT MEDICINE FIRST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        float valueamount;
        string valueid;

        protected Int64 noofunit;

        int flag = 0;
        private void sellmedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueamount = float.Parse(sellmedDataGridView.SelectedRows[0].Cells[5].Value.ToString());
                valueid = sellmedDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                noofunit = Int64.Parse(sellmedDataGridView.SelectedRows[0].Cells[4].Value.ToString());
                flag = 1;
            }
            catch (Exception)
            {

            }
        }

        float netamount;

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtdiscount.Text != "")
            {
                float discount = float.Parse(txtdiscount.Text);
                float totalamount = float.Parse(totallabel.Text);
                netamount = totalamount - totalamount * (discount / 100);
                txtnetamount.Text = netamount.ToString();

            }
            else
            {
                txtnetamount.Clear();
            }
        }

        

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            
            string consultantname = txtdrname.Text;
            string patientname = txtpatientname.Text;
            Int64 phnno = Int64.Parse(txtphnno.Text);
            float totalprice = float.Parse(totallabel.Text);
            float discount = float.Parse(txtdiscount.Text);
            float netamount = float.Parse(txtnetamount.Text);
            string purchasedate = DateTime.Parse(date.Text).ToString("yyyy-MM-dd");
            string purchasetime = DateTime.Parse(time.Text).ToString("HH:mm:ss");

            query = "insert into patients (consultantname,patientname,phnno,totalprice,discount,netamount,purchasedate,purchasetime) values ('" + consultantname + "','" + patientname + "'," + phnno + ",'" + totalprice + "','" + discount + "','" + netamount + "','" + purchasedate + "','" + purchasetime + "')";
            fn.setdata(query, "Purchase Completed");

            if (sellmedDataGridView.Rows.Count < 1)
            {
                MessageBox.Show("Add Minimum One Medicine");
            }
            else
            {


                for (int i = 0; i < sellmedDataGridView.Rows.Count - 1; i++)
                {
                    cmd = new SqlCommand(@"insert into sellmed (medid,medname,priceperunit,quantity,totalprice) values('" + sellmedDataGridView.Rows[i].Cells[0].Value + "','" + sellmedDataGridView.Rows[i].Cells[1].Value + "','" + sellmedDataGridView.Rows[i].Cells[3].Value + "','" + sellmedDataGridView.Rows[i].Cells[4].Value + "','" + sellmedDataGridView.Rows[i].Cells[5].Value + "')", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    
                }  
            }
            if (MessageBox.Show("Are You Sure you want to print the bill?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();

                }
                sellmedDataGridView.Rows.Clear();

                txtdrname.Clear();
                txtpatientname.Clear();
                txtphnno.Clear();
                txtdiscount.Clear();
                txtnetamount.Clear();
                totallabel.Text = "00";

            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 20);
            float fontheight = font.GetHeight();
            int startx = 190;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("Pharmacy name", new Font("Times New Roman", 25), new SolidBrush(Color.Black), startx, starty);
            offset = offset + (int)fontheight;
            graphics.DrawString("Address", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontheight;
            graphics.DrawString("Phnno", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontheight;
            graphics.DrawString("________________________________________________________________________________________________________", new Font("Times New Roman", 30, FontStyle.Bold), new SolidBrush(Color.Black), new System.Drawing.Point(0, 130));
            offset = offset + (int)fontheight;
            graphics.DrawString("Patient Name:" + txtpatientname.Text, new Font("Times New Roman", 18, FontStyle.Bold), new SolidBrush(Color.Black), 20, 200);
            offset = offset + (int)fontheight;
            graphics.DrawString("Phnno:" + txtphnno.Text, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 20, 250);
            offset = offset + (int)fontheight;
            graphics.DrawString("Doctor Name:" + txtdrname.Text, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 400, 250);
            offset = offset + (int)fontheight;
            graphics.DrawString("Billno:", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 400, 200);

            offset = offset + (int)fontheight;
            graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------", new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold), new SolidBrush(Color.Black), new System.Drawing.Point(0, 330));

            graphics.DrawString("Sl No\t Med Name\tQty\tPrice/Unit\tTotal", font, new SolidBrush(Color.Black), 15, starty + offset);
            graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------", new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold), new SolidBrush(Color.Black), new System.Drawing.Point(0, 290));
            offset = offset + (int)fontheight + 20;
            for (int x = 0; x < sellmedDataGridView.Rows.Count; x++)
            {
                graphics.DrawString(sellmedDataGridView.Rows[x].Cells[0].Value + "  \t" + sellmedDataGridView.Rows[x].Cells[1].Value + "\t\t " + sellmedDataGridView.Rows[x].Cells[4].Value + "   \t" + sellmedDataGridView.Rows[x].Cells[3].Value + " \t\t" + sellmedDataGridView.Rows[x].Cells[5].Value, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 15, starty + offset);
                offset = offset + (int)fontheight + 5;
            }
            offset = offset + (int)fontheight + 5;
            graphics.DrawString("______________________________________________________________________", font, new SolidBrush(Color.Black), 500, starty + offset);
            offset = offset + (int)fontheight + 15;
            graphics.DrawString("Total Amount: " + totallabel.Text, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 500, starty + offset);
            offset = offset + (int)fontheight + 20;
            graphics.DrawString("Discount(%): " + txtdiscount.Text, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 500, starty + offset);
            offset = offset + (int)fontheight + 20;
            graphics.DrawString("NET AMOUNT: Rs" + txtnetamount.Text, new Font("Times New Roman", 20, FontStyle.Bold), new SolidBrush(Color.Black), 500, starty + offset);

            e.Graphics.DrawString("________________________________________________________________________________________________________", new System.Drawing.Font("Times New Roman", 50, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(0, 975));
            e.Graphics.DrawString("Purchase Time " + DateTime.Now.ToString(), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 1070));
            e.Graphics.DrawString("Thank You,Get Well Soon!", new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(20, 1070));

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pharmacist ph = new pharmacist();
            ph.Show();
            this.Hide();
        }

        private void btnadddosage_Click(object sender, EventArgs e)
        {
            if(txtmednamedosage.Text.Trim() == "")
            {
                MessageBox.Show("Input Medname ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtdosage.Text.Trim() == "")
            {
                MessageBox.Show("Input Dosage ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtdosagetime.Text.Trim() == "")
            {
                MessageBox.Show("Input Dosage Time ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] arr = new string[3];
            arr[0] = txtmednamedosage.Text;
            arr[1] = txtdosage.Text;
            arr[2] = txtdosagetime.Text;
            ListViewItem lst = new ListViewItem(arr);
            listViewdosage.Items.Add(lst);

            txtmednamedosage.Text = "";
            txtdosage.Text = "";
            txtdosagetime.Text = "";


        }

        private void btndosageclear_Click(object sender, EventArgs e)
        {
            txtmednamedosage.Clear();
            txtdosage.Clear();
            txtdosagetime.ResetText();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 20);
            float fontheight = font.GetHeight();
            int startx = 190;
            int starty = 40;
            int offset = 60;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("Dosage", new Font("Times New Roman", 25), new SolidBrush(Color.Black), startx, starty);
            offset = offset + (int)fontheight;
            e.Graphics.DrawString("Med Name\tDosage\t\tQuantity of Dosage/Dilution", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 10, starty + offset);
            offset = offset + (int)fontheight + 20;
            for (int x = 0; x < listViewdosage.Items.Count; x++)
            {
                e.Graphics.DrawString(listViewdosage.Items[x].SubItems[0].Text + "\t\t" + listViewdosage.Items[x].SubItems[1].Text + "\t\t" + listViewdosage.Items[x].SubItems[2].Text, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 15, starty + offset);
                offset = offset + (int)fontheight + 5;
            }
            listViewdosage.Items.Clear();
            txtmednamedosage.Clear();
            txtdosage.Clear();
            txtdosagetime.ResetText();
        }

        private void btnprintdosage_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();

            }
        }


        /* private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 20);
            float fontheight = font.GetHeight();
            int startx = 190;
            int starty = 40;
            int offset = 60;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("Dosage", new Font("Times New Roman", 25), new SolidBrush(Color.Black), startx, starty);
            offset = offset + (int)fontheight;
            e.Graphics.DrawString("Med Name\tDosage\t\tQuantity of Dosage/Dilution", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 10, starty + offset);
            offset = offset + (int)fontheight + 20;
            for (int x = 0; x < listViewdosage.Items.Count; x++)
            {
                e.Graphics.DrawString(listViewdosage.Items[x].SubItems[0].Text + "\t\t" + listViewdosage.Items[x].SubItems[1].Text + "\t\t" + listViewdosage.Items[x].SubItems[2].Text, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 15, starty + offset);
                offset = offset + (int)fontheight + 5;
            }
            listViewdosage.Items.Clear();
            txtmednamedosage.Clear();
            txtdosage.Clear();
            txtdosagetime.ResetText();
        }
        private void btnprintdosage_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();

            }
        } */

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (valueid != null && totalamount > 00 && flag == 1)
            {
                try
                {
                    sellmedDataGridView.Rows.RemoveAt(this.sellmedDataGridView.SelectedRows[0].Index);

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    query = " select quantity from meds where medid = '" + valueid + "'";
                    ds = fn.getdata(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity + noofunit;
                    query = " update meds set quantity= '" + newquantity + "'where medid = '" + valueid + "'";
                    fn.setdata(query, "Medicine Removed From Cart");
                    totalamount = totalamount - valueamount;
                    totallabel.Text = "Rs. " + totalamount.ToString();

                }
                sellmedicine_Load(this, null);
                flag = 0;

            }
            else
            {
                MessageBox.Show("Please Select an item to Delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
   
        }
    }

