
namespace PHARMACY_MANAGEMENT.pharmacistUC
{
    partial class UC_addmedicine
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtquantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmfgdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtexpdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtpriceperunit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcompanyname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmedicinename = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmedicineid = new Guna.UI2.WinForms.Guna2TextBox();
            this.generatebarcode = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(285, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADD MEDICINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "MEDICINE ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "MEDICINE NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "COMPANY NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "DATE OF MANUFACTURE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "DATE OF EXPIRY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "QUANTITY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(647, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "PRICE PER UNIT";
            // 
            // txtquantity
            // 
            this.txtquantity.BorderColor = System.Drawing.Color.Black;
            this.txtquantity.BorderRadius = 20;
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantity.DefaultText = "";
            this.txtquantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtquantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtquantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtquantity.DisabledState.Parent = this.txtquantity;
            this.txtquantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtquantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquantity.FocusedState.Parent = this.txtquantity;
            this.txtquantity.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtquantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtquantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquantity.HoverState.Parent = this.txtquantity;
            this.txtquantity.Location = new System.Drawing.Point(637, 292);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtquantity.PlaceholderText = "";
            this.txtquantity.SelectedText = "";
            this.txtquantity.ShadowDecoration.Parent = this.txtquantity;
            this.txtquantity.Size = new System.Drawing.Size(254, 36);
            this.txtquantity.TabIndex = 19;
            // 
            // txtmfgdate
            // 
            this.txtmfgdate.BorderRadius = 20;
            this.txtmfgdate.BorderThickness = 1;
            this.txtmfgdate.CheckedState.Parent = this.txtmfgdate;
            this.txtmfgdate.FillColor = System.Drawing.Color.White;
            this.txtmfgdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmfgdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtmfgdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtmfgdate.HoverState.Parent = this.txtmfgdate;
            this.txtmfgdate.Location = new System.Drawing.Point(62, 550);
            this.txtmfgdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtmfgdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtmfgdate.Name = "txtmfgdate";
            this.txtmfgdate.ShadowDecoration.Parent = this.txtmfgdate;
            this.txtmfgdate.Size = new System.Drawing.Size(254, 36);
            this.txtmfgdate.TabIndex = 22;
            this.txtmfgdate.Value = new System.DateTime(2021, 9, 13, 12, 5, 51, 653);
            // 
            // txtexpdate
            // 
            this.txtexpdate.BorderRadius = 20;
            this.txtexpdate.BorderThickness = 1;
            this.txtexpdate.CheckedState.Parent = this.txtexpdate;
            this.txtexpdate.FillColor = System.Drawing.Color.White;
            this.txtexpdate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtexpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtexpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtexpdate.HoverState.Parent = this.txtexpdate;
            this.txtexpdate.Location = new System.Drawing.Point(637, 178);
            this.txtexpdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtexpdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtexpdate.Name = "txtexpdate";
            this.txtexpdate.ShadowDecoration.Parent = this.txtexpdate;
            this.txtexpdate.Size = new System.Drawing.Size(254, 36);
            this.txtexpdate.TabIndex = 23;
            this.txtexpdate.Value = new System.DateTime(2021, 9, 13, 12, 5, 51, 653);
            // 
            // btnadd
            // 
            this.btnadd.BorderRadius = 16;
            this.btnadd.BorderThickness = 1;
            this.btnadd.CheckedState.Parent = this.btnadd;
            this.btnadd.CustomImages.Parent = this.btnadd;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.DisabledState.Parent = this.btnadd;
            this.btnadd.FillColor = System.Drawing.Color.Khaki;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnadd.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnadd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.Parent = this.btnadd;
            this.btnadd.Location = new System.Drawing.Point(637, 561);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.Parent = this.btnadd;
            this.btnadd.Size = new System.Drawing.Size(137, 38);
            this.btnadd.TabIndex = 24;
            this.btnadd.Text = "ADD";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.BorderRadius = 16;
            this.btnclear.BorderThickness = 1;
            this.btnclear.CheckedState.Parent = this.btnclear;
            this.btnclear.CustomImages.Parent = this.btnclear;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.DisabledState.Parent = this.btnclear;
            this.btnclear.FillColor = System.Drawing.Color.Khaki;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnclear.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnclear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnclear.HoverState.Parent = this.btnclear;
            this.btnclear.Location = new System.Drawing.Point(805, 561);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.Parent = this.btnclear;
            this.btnclear.Size = new System.Drawing.Size(137, 38);
            this.btnclear.TabIndex = 25;
            this.btnclear.Text = "CLEAR";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtpriceperunit
            // 
            this.txtpriceperunit.BorderColor = System.Drawing.Color.Black;
            this.txtpriceperunit.BorderRadius = 20;
            this.txtpriceperunit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpriceperunit.DefaultText = "";
            this.txtpriceperunit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpriceperunit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpriceperunit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpriceperunit.DisabledState.Parent = this.txtpriceperunit;
            this.txtpriceperunit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpriceperunit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpriceperunit.FocusedState.Parent = this.txtpriceperunit;
            this.txtpriceperunit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtpriceperunit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpriceperunit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpriceperunit.HoverState.Parent = this.txtpriceperunit;
            this.txtpriceperunit.Location = new System.Drawing.Point(637, 423);
            this.txtpriceperunit.Margin = new System.Windows.Forms.Padding(5);
            this.txtpriceperunit.Name = "txtpriceperunit";
            this.txtpriceperunit.PasswordChar = '\0';
            this.txtpriceperunit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtpriceperunit.PlaceholderText = "";
            this.txtpriceperunit.SelectedText = "";
            this.txtpriceperunit.ShadowDecoration.Parent = this.txtpriceperunit;
            this.txtpriceperunit.Size = new System.Drawing.Size(254, 36);
            this.txtpriceperunit.TabIndex = 20;
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.BorderColor = System.Drawing.Color.Black;
            this.txtcompanyname.BorderRadius = 20;
            this.txtcompanyname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcompanyname.DefaultText = "";
            this.txtcompanyname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcompanyname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcompanyname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcompanyname.DisabledState.Parent = this.txtcompanyname;
            this.txtcompanyname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcompanyname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcompanyname.FocusedState.Parent = this.txtcompanyname;
            this.txtcompanyname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtcompanyname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcompanyname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcompanyname.HoverState.Parent = this.txtcompanyname;
            this.txtcompanyname.Location = new System.Drawing.Point(62, 423);
            this.txtcompanyname.Margin = new System.Windows.Forms.Padding(5);
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.PasswordChar = '\0';
            this.txtcompanyname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtcompanyname.PlaceholderText = "";
            this.txtcompanyname.SelectedText = "";
            this.txtcompanyname.ShadowDecoration.Parent = this.txtcompanyname;
            this.txtcompanyname.Size = new System.Drawing.Size(254, 36);
            this.txtcompanyname.TabIndex = 18;
            // 
            // txtmedicinename
            // 
            this.txtmedicinename.BorderColor = System.Drawing.Color.Black;
            this.txtmedicinename.BorderRadius = 20;
            this.txtmedicinename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmedicinename.DefaultText = "";
            this.txtmedicinename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmedicinename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmedicinename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedicinename.DisabledState.Parent = this.txtmedicinename;
            this.txtmedicinename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedicinename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedicinename.FocusedState.Parent = this.txtmedicinename;
            this.txtmedicinename.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtmedicinename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtmedicinename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedicinename.HoverState.Parent = this.txtmedicinename;
            this.txtmedicinename.Location = new System.Drawing.Point(62, 292);
            this.txtmedicinename.Margin = new System.Windows.Forms.Padding(5);
            this.txtmedicinename.Name = "txtmedicinename";
            this.txtmedicinename.PasswordChar = '\0';
            this.txtmedicinename.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtmedicinename.PlaceholderText = "";
            this.txtmedicinename.SelectedText = "";
            this.txtmedicinename.ShadowDecoration.Parent = this.txtmedicinename;
            this.txtmedicinename.Size = new System.Drawing.Size(254, 36);
            this.txtmedicinename.TabIndex = 17;
            // 
            // txtmedicineid
            // 
            this.txtmedicineid.BorderColor = System.Drawing.Color.Black;
            this.txtmedicineid.BorderRadius = 20;
            this.txtmedicineid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmedicineid.DefaultText = "";
            this.txtmedicineid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmedicineid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmedicineid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedicineid.DisabledState.Parent = this.txtmedicineid;
            this.txtmedicineid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedicineid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedicineid.FocusedState.Parent = this.txtmedicineid;
            this.txtmedicineid.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtmedicineid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtmedicineid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedicineid.HoverState.Parent = this.txtmedicineid;
            this.txtmedicineid.Location = new System.Drawing.Point(62, 180);
            this.txtmedicineid.Margin = new System.Windows.Forms.Padding(5);
            this.txtmedicineid.Name = "txtmedicineid";
            this.txtmedicineid.PasswordChar = '\0';
            this.txtmedicineid.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtmedicineid.PlaceholderText = "";
            this.txtmedicineid.SelectedText = "";
            this.txtmedicineid.ShadowDecoration.Parent = this.txtmedicineid;
            this.txtmedicineid.Size = new System.Drawing.Size(254, 36);
            this.txtmedicineid.TabIndex = 16;
            // 
            // generatebarcode
            // 
            this.generatebarcode.BorderRadius = 16;
            this.generatebarcode.BorderThickness = 1;
            this.generatebarcode.CheckedState.Parent = this.generatebarcode;
            this.generatebarcode.CustomImages.Parent = this.generatebarcode;
            this.generatebarcode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatebarcode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatebarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatebarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatebarcode.DisabledState.Parent = this.generatebarcode;
            this.generatebarcode.FillColor = System.Drawing.Color.Khaki;
            this.generatebarcode.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebarcode.ForeColor = System.Drawing.Color.Black;
            this.generatebarcode.HoverState.BorderColor = System.Drawing.Color.Black;
            this.generatebarcode.HoverState.FillColor = System.Drawing.Color.Gray;
            this.generatebarcode.HoverState.ForeColor = System.Drawing.Color.White;
            this.generatebarcode.HoverState.Parent = this.generatebarcode;
            this.generatebarcode.Location = new System.Drawing.Point(439, 625);
            this.generatebarcode.Name = "generatebarcode";
            this.generatebarcode.ShadowDecoration.Parent = this.generatebarcode;
            this.generatebarcode.Size = new System.Drawing.Size(137, 38);
            this.generatebarcode.TabIndex = 26;
            this.generatebarcode.Text = "Generate Barcode";
            this.generatebarcode.Click += new System.EventHandler(this.generatebarcode_Click_1);
            // 
            // UC_addmedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.Controls.Add(this.generatebarcode);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtexpdate);
            this.Controls.Add(this.txtmfgdate);
            this.Controls.Add(this.txtpriceperunit);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtcompanyname);
            this.Controls.Add(this.txtmedicinename);
            this.Controls.Add(this.txtmedicineid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "UC_addmedicine";
            this.Size = new System.Drawing.Size(1010, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtquantity;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtmfgdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtexpdate;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtpriceperunit;
        private Guna.UI2.WinForms.Guna2TextBox txtcompanyname;
        private Guna.UI2.WinForms.Guna2TextBox txtmedicinename;
        private Guna.UI2.WinForms.Guna2TextBox txtmedicineid;
        private Guna.UI2.WinForms.Guna2Button generatebarcode;
    }
}
