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
    public partial class UC_sellmedicine : UserControl
    {
        userfunction fn = new userfunction();
        string query;
        DataSet ds;

        SqlConnection con = new SqlConnection(@"data source = localhost\SQLEXPRESS; database = PHARMACY; integrated security = true");
        SqlCommand cmd;

        public UC_sellmedicine()
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

        private void UC_sellmedicine_Load(object sender, EventArgs e)
        {
            timer1.Start();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            time.Text = DateTime.Now.ToString("HH:mm:ss");


            listBoxmedicines.Items.Clear();

            query = "select medname from meds where expdate>=getdate() and quantity > '0'";
            ds = fn.getdata(query);

            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
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
            UC_sellmedicine_Load(this, null);
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
            if (txtmedid.Text != "" && txtnoofunits.Text !="")
            {
                query = "select quantity from meds where medid ='" + txtmedid.Text + "'";
                ds = fn.getdata(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newquantity = quantity - Int64.Parse(txtnoofunits.Text);

                if(newquantity >= 0)
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
                    fn.setdata(query,"Medicine Added To Cart");

                }
                else
                {
                    MessageBox.Show("OUT OF STOCK /n ONLY " + quantity + " LEFT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearall();
                UC_sellmedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("SELECT MEDICINE FIRST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        float valueamount;
        string valueid;

        protected Int64 noofunit;

        private void btnaddtocart_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add to Cart",btnaddtocart);
        }
        int flag = 0;
        private void sellmedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueamount = float.Parse(sellmedDataGridView.SelectedRows[0].Cells[5].Value.ToString());
                valueid = sellmedDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                noofunit = Int64.Parse(sellmedDataGridView.SelectedRows[0].Cells[4].Value.ToString());
                flag = 1;
            }
            catch(Exception)
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
            fn.setdata(query, "message");

            if (sellmedDataGridView.Rows.Count < 1)
            {
                MessageBox.Show("Add Minimum One Medicine");
            }
            else
            {
                
                
                for(int i=0; i<sellmedDataGridView.Rows.Count - 1;i++)
                {
                    cmd = new SqlCommand(@"insert into sellmed (medid,medname,priceperunit,quantity,totalprice) values('" + sellmedDataGridView.Rows[i].Cells[0].Value + "','" + sellmedDataGridView.Rows[i].Cells[1].Value + "','" + sellmedDataGridView.Rows[i].Cells[3].Value + "','" + sellmedDataGridView.Rows[i].Cells[4].Value + "','" + sellmedDataGridView.Rows[i].Cells[5].Value + "')", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
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

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

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
            graphics.DrawString("Pharmacy name", new Font("Times New Roman", 25),new SolidBrush (Color.Black), startx, starty);
            offset = offset + (int)fontheight;
            graphics.DrawString("Address", new Font("Times New Roman", 20),new SolidBrush (Color.Black),startx, starty+offset);
            offset = offset + (int)fontheight;
            graphics.DrawString("Phnno", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontheight;
            graphics.DrawString("________________________________________________________________________________________________________", Font , new SolidBrush (Color.Black), startx, starty + offset);
            offset = offset + (int)fontheight;
            graphics.DrawString("Patient Name:", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty+offset);
            offset = offset + (int)fontheight;
            graphics.DrawString("Phnno:", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontheight;
            graphics.DrawString("Doctor Name:", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontheight;
            graphics.DrawString("Billno:", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty+offset);
            offset = offset + (int)fontheight;

            graphics.DrawString("Sl No\tMedicine Name\tQty\tPrice/Unit\tTotal", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontheight;
            for(int x=0;x<sellmedDataGridView.Rows.Count; x++)
            {
                graphics.DrawString(sellmedDataGridView.Rows[x].Cells[0].Value + "\t" + sellmedDataGridView.Rows[x].Cells[1].Value + "\t" + sellmedDataGridView.Rows[x].Cells[3].Value + "\t" + sellmedDataGridView.Rows[x].Cells[4].Value + "\t" + sellmedDataGridView.Rows[x].Cells[5].Value, new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + (int)fontheight;
            }
            offset = offset + (int)fontheight;

            /*e.Graphics.DrawString("Patient Name:  " + txtpatientname.Text, new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, 280));
            e.Graphics.DrawString("Phnno:  " + txtphnno.Text, new System.Drawing.Font("Times New Roman", 20, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(450, 290));
            e.Graphics.DrawString("Doctor Name:  " + txtdrname.Text, new Font("Times New Roman", 20, FontStyle.Regular), Brushes.Black, new Point(450, 220));
            e.Graphics.DrawString("Billno:  ", new System.Drawing.Font("Times New Roman", 20, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(10, 220));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(0, 350));
            e.Graphics.DrawString("Slno", new System.Drawing.Font("Times New Roman", 17, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(5, 380));
            e.Graphics.DrawString("Medicine Name", new System.Drawing.Font("Times New Roman", 17, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(70, 380));
            e.Graphics.DrawString("Quantity", new System.Drawing.Font("Times New Roman", 17, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(420, 380));
            e.Graphics.DrawString("Price/Unit", new System.Drawing.Font("Times New Roman", 17, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(550, 380));
            e.Graphics.DrawString("Total", new System.Drawing.Font("Times New Roman", 17, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(690, 380));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(0, 400));
            e.Graphics.DrawString("________________________________________________________________________________________________________", new System.Drawing.Font("Times New Roman", 50, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(0, 975));
            e.Graphics.DrawString("Purchase Time " + DateTime.Now.ToString(), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 1070));
            e.Graphics.DrawString("Thank You,Get Well Soon!", new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(20, 1070));
            */


        }
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (valueid != null && totalamount > 00 && flag == 1)
            {
                try
                {
                    sellmedDataGridView.Rows.RemoveAt(this.sellmedDataGridView.SelectedRows[0].Index);

                }
                catch(Exception E)
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
                UC_sellmedicine_Load(this, null);
                flag = 0;

            }
            else
            {
                MessageBox.Show("Please Select an item to Delete","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
/*private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new System.Drawing.Font("Californian FB", 25, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(120));
            e.Graphics.DrawString(OrderId.Text, new System.Drawing.Font("Cambria", 10, FontStyle.Regular), Brushes.Green, new System.Drawing.Point(70, 50));
            e.Graphics.DrawString(CustId.Text, new System.Drawing.Font("Cambria", 10, FontStyle.Regular), Brushes.Green, new System.Drawing.Point(70, 90));
            e.Graphics.DrawString("Customer Name: " + Orderdgv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Cambria", 20, FontStyle.Regular), Brushes.Green, new Point(70, 210));
            con.Open();
            string squery = "select * from OrdersTbl where Orderid = '" + viewOrders.orderid + "';";

            SqlCommand CMD = new SqlCommand(squery, con);
            SqlDataReader rdr = null;
            string orderdate = "";
            string totalamt = "";
            try
            {
                rdr = CMD.ExecuteReader();
                while (rdr.Read())
                {
                    orderdate = Convert.ToString(rdr.GetDateTime(2));
                    totalamt = Convert.ToString(rdr.GetValue(3));
                }
                rdr.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
            }
            con.Close();
            string id1 = orderdate;
            string id2 = totalamt;
            e.Graphics.DrawString("Order Date: " + id1 , new System.Drawing.Font("Cambria", 10, FontStyle.Regular), Brushes.Green, new System.Drawing.Point(70, 130));
            e.Graphics.DrawString("Order Total Amount: " +id2 , new System.Drawing.Font("Cambria", 10, FontStyle.Regular), Brushes.Green, new System.Drawing.Point(70, 170));
            string[] Arr = { "Sl.No.", "ProductName", "Product Qty.", "PricePerUnit", "TotalPrice" };
            int x = 6;
            int g = 1;
            con.Open();
            string myquery = "select * from OrdersTbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            System.Data.DataTable Table = new System.Data.DataTable();
            da.Fill(Table);
            con.Close();
            foreach (string str in Arr)
            {

                e.Graphics.DrawString(str, new System.Drawing.Font("Californian FB", 8, FontStyle.Underline), Brushes.SandyBrown, new System.Drawing.Point(x, 220));
                if (g == 2)
                {
                    x += 120;
                }
                else
                {
                    x += 60;
                }
                g += 1;
            }
            int j = 235;
            con.Open();
            string query = "select * from Order_prodTbl where orderid = '" + viewOrders.orderid + "'";
            SqlDataAdapter daa = new SqlDataAdapter(query, con);
            System.Data.DataTable Table2 = new System.Data.DataTable();
            daa.Fill(Table2);
            con.Close();
            foreach (DataRow dr in Table2.Rows)
            {
                int i = 20;
                int gap = 1;
                //MessageBox.Show("Got here!");
                j += 30;
                foreach (var item in dr.ItemArray)
                {
                    if (gap == 4)
                    {
                        con.Open();
                        string Query = "select * from ProdTbl where prodid = '" + Convert.ToInt32(item) + "';";

                        SqlCommand Cmd = new SqlCommand(Query, con);
                        SqlDataReader reader = null;
                        string prodname = "";
                        try
                        {
                            reader = Cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                prodname = reader.GetString(1);
                            }
                            reader.Close();
                        }
                        catch (Exception E)
                        {
                            MessageBox.Show(E.Message);
                            con.Close();
                        }
                        con.Close();
                        string id = prodname;
                        e.Graphics.DrawString(id, new System.Drawing.Font("Californian FB", 7, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(i, j));
                        i += 90;
                    }
                    else if (gap >= 3)
                    {
                        e.Graphics.DrawString(item.ToString(), new System.Drawing.Font("Californian FB", 7, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(i, j));

                        i += 60;

                    }
                    //MessageBox.Show("Got here!");

                    gap += 1;
                }

            }
        }

        private void PrintPreview_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void GenerateBarcodes_Click(object sender, EventArgs e)
        {
            /*var processStartInfo = new ProcessStartInfo();
            processStartInfo.WorkingDirectory = Windows.Storage.ApplicationData.Current.LocalFolder.ToString();*/
/*Process process1 = new Process();
process1.StartInfo.FileName = "cmd.exe";
process1.StartInfo.Arguments = "/C Type C:\\Users\\ARS\\Desktop\\sample.txt>\\\\DESKTOP-STNC23L\\Godex G500";
Process proc = Process.Start(process1.StartInfo);
*/