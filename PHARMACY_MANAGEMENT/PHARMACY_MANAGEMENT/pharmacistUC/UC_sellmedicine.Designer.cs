
namespace PHARMACY_MANAGEMENT.pharmacistUC
{
    partial class UC_sellmedicine
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_sellmedicine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBoxmedicines = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnaddtocart = new Guna.UI2.WinForms.Guna2Button();
            this.txtmedid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmedname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtppu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnoofunits = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttp = new Guna.UI2.WinForms.Guna2TextBox();
            this.sellmedDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnpurchase = new Guna.UI2.WinForms.Guna2Button();
            this.totallabel = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txtexpdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnprint = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtphnno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdrname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpatientname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnremove = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnetamount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellmedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(381, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "SELL MEDICINE";
            // 
            // txtsearch
            // 
            this.txtsearch.BorderRadius = 20;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.Parent = this.txtsearch;
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.FocusedState.Parent = this.txtsearch;
            this.txtsearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.HoverState.Parent = this.txtsearch;
            this.txtsearch.Location = new System.Drawing.Point(20, 81);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtsearch.PlaceholderText = "Search";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(183, 36);
            this.txtsearch.TabIndex = 18;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // listBoxmedicines
            // 
            this.listBoxmedicines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxmedicines.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxmedicines.FormattingEnabled = true;
            this.listBoxmedicines.ItemHeight = 23;
            this.listBoxmedicines.Location = new System.Drawing.Point(20, 127);
            this.listBoxmedicines.Name = "listBoxmedicines";
            this.listBoxmedicines.Size = new System.Drawing.Size(183, 188);
            this.listBoxmedicines.TabIndex = 19;
            this.listBoxmedicines.SelectedIndexChanged += new System.EventHandler(this.listBoxmedicines_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Medicine ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Medicine Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Expiry Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Price/Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(749, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(741, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total Amount";
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnaddtocart.BorderRadius = 20;
            this.btnaddtocart.BorderThickness = 1;
            this.btnaddtocart.CheckedState.Parent = this.btnaddtocart;
            this.btnaddtocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddtocart.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnaddtocart.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.btnaddtocart.CustomImages.Parent = this.btnaddtocart;
            this.btnaddtocart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddtocart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddtocart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddtocart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddtocart.DisabledState.Parent = this.btnaddtocart;
            this.btnaddtocart.FillColor = System.Drawing.Color.White;
            this.btnaddtocart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnaddtocart.ForeColor = System.Drawing.Color.Black;
            this.btnaddtocart.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnaddtocart.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnaddtocart.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnaddtocart.HoverState.Parent = this.btnaddtocart;
            this.btnaddtocart.Image = ((System.Drawing.Image)(resources.GetObject("btnaddtocart.Image")));
            this.btnaddtocart.ImageSize = new System.Drawing.Size(50, 50);
            this.btnaddtocart.Location = new System.Drawing.Point(774, 349);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.ShadowDecoration.Parent = this.btnaddtocart;
            this.btnaddtocart.Size = new System.Drawing.Size(66, 64);
            this.btnaddtocart.TabIndex = 26;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            this.btnaddtocart.MouseHover += new System.EventHandler(this.btnaddtocart_MouseHover);
            // 
            // txtmedid
            // 
            this.txtmedid.BorderRadius = 20;
            this.txtmedid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmedid.DefaultText = "";
            this.txtmedid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmedid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmedid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedid.DisabledState.Parent = this.txtmedid;
            this.txtmedid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedid.FocusedState.Parent = this.txtmedid;
            this.txtmedid.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtmedid.ForeColor = System.Drawing.Color.Black;
            this.txtmedid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedid.HoverState.Parent = this.txtmedid;
            this.txtmedid.Location = new System.Drawing.Point(528, 108);
            this.txtmedid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmedid.Name = "txtmedid";
            this.txtmedid.PasswordChar = '\0';
            this.txtmedid.PlaceholderText = "";
            this.txtmedid.ReadOnly = true;
            this.txtmedid.SelectedText = "";
            this.txtmedid.ShadowDecoration.Parent = this.txtmedid;
            this.txtmedid.Size = new System.Drawing.Size(164, 36);
            this.txtmedid.TabIndex = 27;
            // 
            // txtmedname
            // 
            this.txtmedname.BorderRadius = 20;
            this.txtmedname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmedname.DefaultText = "";
            this.txtmedname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmedname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmedname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedname.DisabledState.Parent = this.txtmedname;
            this.txtmedname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedname.FocusedState.Parent = this.txtmedname;
            this.txtmedname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedname.ForeColor = System.Drawing.Color.Black;
            this.txtmedname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedname.HoverState.Parent = this.txtmedname;
            this.txtmedname.Location = new System.Drawing.Point(528, 189);
            this.txtmedname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmedname.Name = "txtmedname";
            this.txtmedname.PasswordChar = '\0';
            this.txtmedname.PlaceholderText = "";
            this.txtmedname.ReadOnly = true;
            this.txtmedname.SelectedText = "";
            this.txtmedname.ShadowDecoration.Parent = this.txtmedname;
            this.txtmedname.Size = new System.Drawing.Size(164, 36);
            this.txtmedname.TabIndex = 28;
            // 
            // txtppu
            // 
            this.txtppu.BorderRadius = 20;
            this.txtppu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtppu.DefaultText = "";
            this.txtppu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtppu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtppu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtppu.DisabledState.Parent = this.txtppu;
            this.txtppu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtppu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtppu.FocusedState.Parent = this.txtppu;
            this.txtppu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtppu.ForeColor = System.Drawing.Color.Black;
            this.txtppu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtppu.HoverState.Parent = this.txtppu;
            this.txtppu.Location = new System.Drawing.Point(730, 108);
            this.txtppu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtppu.Name = "txtppu";
            this.txtppu.PasswordChar = '\0';
            this.txtppu.PlaceholderText = "";
            this.txtppu.ReadOnly = true;
            this.txtppu.SelectedText = "";
            this.txtppu.ShadowDecoration.Parent = this.txtppu;
            this.txtppu.Size = new System.Drawing.Size(182, 36);
            this.txtppu.TabIndex = 30;
            // 
            // txtnoofunits
            // 
            this.txtnoofunits.BorderRadius = 20;
            this.txtnoofunits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnoofunits.DefaultText = "";
            this.txtnoofunits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnoofunits.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnoofunits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnoofunits.DisabledState.Parent = this.txtnoofunits;
            this.txtnoofunits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnoofunits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnoofunits.FocusedState.Parent = this.txtnoofunits;
            this.txtnoofunits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoofunits.ForeColor = System.Drawing.Color.Black;
            this.txtnoofunits.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnoofunits.HoverState.Parent = this.txtnoofunits;
            this.txtnoofunits.Location = new System.Drawing.Point(730, 189);
            this.txtnoofunits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnoofunits.Name = "txtnoofunits";
            this.txtnoofunits.PasswordChar = '\0';
            this.txtnoofunits.PlaceholderText = "";
            this.txtnoofunits.SelectedText = "";
            this.txtnoofunits.ShadowDecoration.Parent = this.txtnoofunits;
            this.txtnoofunits.Size = new System.Drawing.Size(182, 36);
            this.txtnoofunits.TabIndex = 31;
            this.txtnoofunits.TextChanged += new System.EventHandler(this.txtnoofunits_TextChanged);
            // 
            // txttp
            // 
            this.txttp.BorderRadius = 20;
            this.txttp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttp.DefaultText = "";
            this.txttp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttp.DisabledState.Parent = this.txttp;
            this.txttp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttp.FocusedState.Parent = this.txttp;
            this.txttp.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txttp.ForeColor = System.Drawing.Color.Black;
            this.txttp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttp.HoverState.Parent = this.txttp;
            this.txttp.Location = new System.Drawing.Point(730, 274);
            this.txttp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttp.Name = "txttp";
            this.txttp.PasswordChar = '\0';
            this.txttp.PlaceholderText = "";
            this.txttp.SelectedText = "";
            this.txttp.ShadowDecoration.Parent = this.txttp;
            this.txttp.Size = new System.Drawing.Size(182, 36);
            this.txttp.TabIndex = 32;
            // 
            // sellmedDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.sellmedDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sellmedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellmedDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sellmedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellmedDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellmedDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellmedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sellmedDataGridView.ColumnHeadersHeight = 20;
            this.sellmedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellmedDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.sellmedDataGridView.EnableHeadersVisualStyles = false;
            this.sellmedDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellmedDataGridView.Location = new System.Drawing.Point(20, 349);
            this.sellmedDataGridView.Name = "sellmedDataGridView";
            this.sellmedDataGridView.ReadOnly = true;
            this.sellmedDataGridView.RowHeadersVisible = false;
            this.sellmedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellmedDataGridView.Size = new System.Drawing.Size(716, 281);
            this.sellmedDataGridView.TabIndex = 33;
            this.sellmedDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sellmedDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sellmedDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sellmedDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sellmedDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sellmedDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.sellmedDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellmedDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sellmedDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sellmedDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellmedDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sellmedDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sellmedDataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.sellmedDataGridView.ThemeStyle.ReadOnly = true;
            this.sellmedDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sellmedDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellmedDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellmedDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellmedDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.sellmedDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellmedDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellmedDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellmedDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MED ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MED NAME";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "EXP DATE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NO of UNITS";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "PRICE PER UNIT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TOTAL PRICE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnpurchase
            // 
            this.btnpurchase.BorderRadius = 20;
            this.btnpurchase.BorderThickness = 1;
            this.btnpurchase.CheckedState.Parent = this.btnpurchase;
            this.btnpurchase.CustomImages.Parent = this.btnpurchase;
            this.btnpurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnpurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnpurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnpurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnpurchase.DisabledState.Parent = this.btnpurchase;
            this.btnpurchase.FillColor = System.Drawing.Color.DimGray;
            this.btnpurchase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnpurchase.ForeColor = System.Drawing.Color.Black;
            this.btnpurchase.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnpurchase.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnpurchase.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnpurchase.HoverState.Parent = this.btnpurchase;
            this.btnpurchase.Location = new System.Drawing.Point(219, 652);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.ShadowDecoration.Parent = this.btnpurchase;
            this.btnpurchase.Size = new System.Drawing.Size(168, 44);
            this.btnpurchase.TabIndex = 35;
            this.btnpurchase.Text = "PURCHASE";
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.BackColor = System.Drawing.Color.Transparent;
            this.totallabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.ForeColor = System.Drawing.Color.Black;
            this.totallabel.Location = new System.Drawing.Point(810, 512);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(80, 26);
            this.totallabel.TabIndex = 36;
            this.totallabel.Text = " Rs. 00";
            this.totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BorderRadius = 20;
            this.btnrefresh.BorderThickness = 1;
            this.btnrefresh.CheckedState.Parent = this.btnrefresh;
            this.btnrefresh.CustomImages.Parent = this.btnrefresh;
            this.btnrefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrefresh.DisabledState.Parent = this.btnrefresh;
            this.btnrefresh.FillColor = System.Drawing.Color.DimGray;
            this.btnrefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnrefresh.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnrefresh.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.HoverState.Parent = this.btnrefresh;
            this.btnrefresh.Location = new System.Drawing.Point(20, 652);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ShadowDecoration.Parent = this.btnrefresh;
            this.btnrefresh.Size = new System.Drawing.Size(98, 44);
            this.btnrefresh.TabIndex = 37;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // txtexpdate
            // 
            this.txtexpdate.BorderRadius = 20;
            this.txtexpdate.CheckedState.Parent = this.txtexpdate;
            this.txtexpdate.FillColor = System.Drawing.Color.White;
            this.txtexpdate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtexpdate.ForeColor = System.Drawing.Color.Black;
            this.txtexpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtexpdate.HoverState.Parent = this.txtexpdate;
            this.txtexpdate.Location = new System.Drawing.Point(528, 274);
            this.txtexpdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtexpdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtexpdate.Name = "txtexpdate";
            this.txtexpdate.ShadowDecoration.Parent = this.txtexpdate;
            this.txtexpdate.Size = new System.Drawing.Size(164, 36);
            this.txtexpdate.TabIndex = 38;
            this.txtexpdate.Value = new System.DateTime(2021, 9, 21, 13, 51, 14, 502);
            // 
            // btnprint
            // 
            this.btnprint.BorderRadius = 20;
            this.btnprint.BorderThickness = 1;
            this.btnprint.CheckedState.Parent = this.btnprint;
            this.btnprint.CustomImages.Parent = this.btnprint;
            this.btnprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprint.DisabledState.Parent = this.btnprint;
            this.btnprint.FillColor = System.Drawing.Color.DimGray;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnprint.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnprint.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnprint.HoverState.Parent = this.btnprint;
            this.btnprint.Location = new System.Drawing.Point(502, 652);
            this.btnprint.Name = "btnprint";
            this.btnprint.ShadowDecoration.Parent = this.btnprint;
            this.btnprint.Size = new System.Drawing.Size(168, 44);
            this.btnprint.TabIndex = 45;
            this.btnprint.Text = " PRINT";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Phn No";
            // 
            // txtphnno
            // 
            this.txtphnno.BorderRadius = 20;
            this.txtphnno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphnno.DefaultText = "";
            this.txtphnno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphnno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphnno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphnno.DisabledState.Parent = this.txtphnno;
            this.txtphnno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphnno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphnno.FocusedState.Parent = this.txtphnno;
            this.txtphnno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphnno.ForeColor = System.Drawing.Color.Black;
            this.txtphnno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphnno.HoverState.Parent = this.txtphnno;
            this.txtphnno.Location = new System.Drawing.Point(235, 274);
            this.txtphnno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtphnno.Name = "txtphnno";
            this.txtphnno.PasswordChar = '\0';
            this.txtphnno.PlaceholderText = "";
            this.txtphnno.SelectedText = "";
            this.txtphnno.ShadowDecoration.Parent = this.txtphnno;
            this.txtphnno.Size = new System.Drawing.Size(257, 36);
            this.txtphnno.TabIndex = 55;
            // 
            // txtdrname
            // 
            this.txtdrname.BorderRadius = 20;
            this.txtdrname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdrname.DefaultText = "";
            this.txtdrname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdrname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdrname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdrname.DisabledState.Parent = this.txtdrname;
            this.txtdrname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdrname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdrname.FocusedState.Parent = this.txtdrname;
            this.txtdrname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdrname.ForeColor = System.Drawing.Color.Black;
            this.txtdrname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdrname.HoverState.Parent = this.txtdrname;
            this.txtdrname.Location = new System.Drawing.Point(235, 108);
            this.txtdrname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdrname.Name = "txtdrname";
            this.txtdrname.PasswordChar = '\0';
            this.txtdrname.PlaceholderText = "";
            this.txtdrname.SelectedText = "";
            this.txtdrname.ShadowDecoration.Parent = this.txtdrname;
            this.txtdrname.Size = new System.Drawing.Size(257, 36);
            this.txtdrname.TabIndex = 54;
            // 
            // txtpatientname
            // 
            this.txtpatientname.BorderRadius = 20;
            this.txtpatientname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpatientname.DefaultText = "";
            this.txtpatientname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpatientname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpatientname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpatientname.DisabledState.Parent = this.txtpatientname;
            this.txtpatientname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpatientname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpatientname.FocusedState.Parent = this.txtpatientname;
            this.txtpatientname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatientname.ForeColor = System.Drawing.Color.Black;
            this.txtpatientname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpatientname.HoverState.Parent = this.txtpatientname;
            this.txtpatientname.Location = new System.Drawing.Point(235, 185);
            this.txtpatientname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.PasswordChar = '\0';
            this.txtpatientname.PlaceholderText = "";
            this.txtpatientname.SelectedText = "";
            this.txtpatientname.ShadowDecoration.Parent = this.txtpatientname;
            this.txtpatientname.Size = new System.Drawing.Size(257, 36);
            this.txtpatientname.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(249, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 21);
            this.label10.TabIndex = 52;
            this.label10.Text = "Consultant Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "Patient Name";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(726, 26);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 21);
            this.date.TabIndex = 57;
            this.date.Text = "Date";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(865, 26);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(47, 21);
            this.time.TabIndex = 58;
            this.time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Transparent;
            this.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnremove.BorderRadius = 20;
            this.btnremove.BorderThickness = 1;
            this.btnremove.CheckedState.Parent = this.btnremove;
            this.btnremove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremove.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnremove.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.btnremove.CustomImages.Parent = this.btnremove;
            this.btnremove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnremove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnremove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnremove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnremove.DisabledState.Parent = this.btnremove;
            this.btnremove.FillColor = System.Drawing.Color.White;
            this.btnremove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnremove.ForeColor = System.Drawing.Color.Black;
            this.btnremove.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnremove.HoverState.FillColor = System.Drawing.Color.White;
            this.btnremove.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnremove.HoverState.Parent = this.btnremove;
            this.btnremove.Image = ((System.Drawing.Image)(resources.GetObject("btnremove.Image")));
            this.btnremove.ImageSize = new System.Drawing.Size(50, 50);
            this.btnremove.Location = new System.Drawing.Point(872, 349);
            this.btnremove.Name = "btnremove";
            this.btnremove.ShadowDecoration.Parent = this.btnremove;
            this.btnremove.Size = new System.Drawing.Size(66, 64);
            this.btnremove.TabIndex = 59;
            this.toolTip2.SetToolTip(this.btnremove, "REMOVE FROM CART\r\n");
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // toolTip2
            // 
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(784, 569);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 60;
            this.label11.Text = "Discount(%)";
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderRadius = 20;
            this.txtdiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiscount.DefaultText = "";
            this.txtdiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiscount.DisabledState.Parent = this.txtdiscount;
            this.txtdiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiscount.FocusedState.Parent = this.txtdiscount;
            this.txtdiscount.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtdiscount.ForeColor = System.Drawing.Color.Black;
            this.txtdiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiscount.HoverState.Parent = this.txtdiscount;
            this.txtdiscount.Location = new System.Drawing.Point(774, 594);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.PasswordChar = '\0';
            this.txtdiscount.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtdiscount.PlaceholderText = "00";
            this.txtdiscount.SelectedText = "";
            this.txtdiscount.ShadowDecoration.Parent = this.txtdiscount;
            this.txtdiscount.Size = new System.Drawing.Size(164, 36);
            this.txtdiscount.TabIndex = 61;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(784, 635);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 21);
            this.label12.TabIndex = 62;
            this.label12.Text = "Net amount";
            // 
            // txtnetamount
            // 
            this.txtnetamount.BorderRadius = 20;
            this.txtnetamount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnetamount.DefaultText = "";
            this.txtnetamount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnetamount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnetamount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnetamount.DisabledState.Parent = this.txtnetamount;
            this.txtnetamount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnetamount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnetamount.FocusedState.Parent = this.txtnetamount;
            this.txtnetamount.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtnetamount.ForeColor = System.Drawing.Color.Black;
            this.txtnetamount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnetamount.HoverState.Parent = this.txtnetamount;
            this.txtnetamount.Location = new System.Drawing.Point(772, 660);
            this.txtnetamount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnetamount.Name = "txtnetamount";
            this.txtnetamount.PasswordChar = '\0';
            this.txtnetamount.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtnetamount.PlaceholderText = "00";
            this.txtnetamount.SelectedText = "";
            this.txtnetamount.ShadowDecoration.Parent = this.txtnetamount;
            this.txtnetamount.Size = new System.Drawing.Size(164, 36);
            this.txtnetamount.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(795, 464);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 64;
            this.label13.Text = "Total Amount";
            // 
            // UC_sellmedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtnetamount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtphnno);
            this.Controls.Add(this.txtdrname);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtexpdate);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.sellmedDataGridView);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.txtnoofunits);
            this.Controls.Add(this.txtppu);
            this.Controls.Add(this.txtmedname);
            this.Controls.Add(this.txtmedid);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxmedicines);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label3);
            this.Name = "UC_sellmedicine";
            this.Size = new System.Drawing.Size(1010, 720);
            this.Load += new System.EventHandler(this.UC_sellmedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellmedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.ListBox listBoxmedicines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnaddtocart;
        private Guna.UI2.WinForms.Guna2TextBox txtmedid;
        private Guna.UI2.WinForms.Guna2TextBox txtmedname;
        private Guna.UI2.WinForms.Guna2TextBox txtppu;
        private Guna.UI2.WinForms.Guna2TextBox txtnoofunits;
        private Guna.UI2.WinForms.Guna2TextBox txttp;
        private Guna.UI2.WinForms.Guna2DataGridView sellmedDataGridView;
        private Guna.UI2.WinForms.Guna2Button btnpurchase;
        private System.Windows.Forms.Label totallabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtexpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnprint;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtphnno;
        private Guna.UI2.WinForms.Guna2TextBox txtdrname;
        private Guna.UI2.WinForms.Guna2TextBox txtpatientname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnremove;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2TextBox txtnetamount;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtdiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}
