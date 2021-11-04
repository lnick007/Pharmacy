
namespace PHARMACY_MANAGEMENT.adminUC
{
    partial class UC_adduser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_adduser));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtphno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemailid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuserrole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.btnsignin = new Guna.UI2.WinForms.Guna2Button();
            this.hidepass = new Guna.UI2.WinForms.Guna2Button();
            this.showpass = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(292, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADD USER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "USER ROLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "USERNAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "FULL NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "PH NO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "EMAIL ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "PASSWORD";
            // 
            // txtfullname
            // 
            this.txtfullname.BorderColor = System.Drawing.Color.Black;
            this.txtfullname.BorderRadius = 20;
            this.txtfullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfullname.DefaultText = "";
            this.txtfullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfullname.DisabledState.Parent = this.txtfullname;
            this.txtfullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfullname.FocusedState.Parent = this.txtfullname;
            this.txtfullname.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtfullname.ForeColor = System.Drawing.Color.Black;
            this.txtfullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfullname.HoverState.Parent = this.txtfullname;
            this.txtfullname.Location = new System.Drawing.Point(33, 280);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.PasswordChar = '\0';
            this.txtfullname.PlaceholderText = "";
            this.txtfullname.SelectedText = "";
            this.txtfullname.ShadowDecoration.Parent = this.txtfullname;
            this.txtfullname.Size = new System.Drawing.Size(228, 36);
            this.txtfullname.TabIndex = 15;
            this.txtfullname.TextChanged += new System.EventHandler(this.txtfullname_TextChanged);
            // 
            // txtphno
            // 
            this.txtphno.BorderColor = System.Drawing.Color.Black;
            this.txtphno.BorderRadius = 20;
            this.txtphno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphno.DefaultText = "";
            this.txtphno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphno.DisabledState.Parent = this.txtphno;
            this.txtphno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphno.FocusedState.Parent = this.txtphno;
            this.txtphno.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtphno.ForeColor = System.Drawing.Color.Black;
            this.txtphno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphno.HoverState.Parent = this.txtphno;
            this.txtphno.Location = new System.Drawing.Point(33, 441);
            this.txtphno.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtphno.Name = "txtphno";
            this.txtphno.PasswordChar = '\0';
            this.txtphno.PlaceholderText = "";
            this.txtphno.SelectedText = "";
            this.txtphno.ShadowDecoration.Parent = this.txtphno;
            this.txtphno.Size = new System.Drawing.Size(228, 36);
            this.txtphno.TabIndex = 16;
            // 
            // txtemailid
            // 
            this.txtemailid.BorderColor = System.Drawing.Color.Black;
            this.txtemailid.BorderRadius = 20;
            this.txtemailid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemailid.DefaultText = "";
            this.txtemailid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemailid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemailid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemailid.DisabledState.Parent = this.txtemailid;
            this.txtemailid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemailid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemailid.FocusedState.Parent = this.txtemailid;
            this.txtemailid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.ForeColor = System.Drawing.Color.Black;
            this.txtemailid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemailid.HoverState.Parent = this.txtemailid;
            this.txtemailid.Location = new System.Drawing.Point(33, 588);
            this.txtemailid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.PasswordChar = '\0';
            this.txtemailid.PlaceholderText = "";
            this.txtemailid.SelectedText = "";
            this.txtemailid.ShadowDecoration.Parent = this.txtemailid;
            this.txtemailid.Size = new System.Drawing.Size(228, 36);
            this.txtemailid.TabIndex = 17;
            // 
            // txtusername
            // 
            this.txtusername.BorderColor = System.Drawing.Color.Black;
            this.txtusername.BorderRadius = 20;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.Parent = this.txtusername;
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedState.Parent = this.txtusername;
            this.txtusername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.HoverState.Parent = this.txtusername;
            this.txtusername.Location = new System.Drawing.Point(466, 280);
            this.txtusername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderText = "";
            this.txtusername.SelectedText = "";
            this.txtusername.ShadowDecoration.Parent = this.txtusername;
            this.txtusername.Size = new System.Drawing.Size(222, 36);
            this.txtusername.TabIndex = 18;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderColor = System.Drawing.Color.Black;
            this.txtpassword.BorderRadius = 20;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.Parent = this.txtpassword;
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedState.Parent = this.txtpassword;
            this.txtpassword.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.HoverState.Parent = this.txtpassword;
            this.txtpassword.Location = new System.Drawing.Point(466, 441);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.SelectedText = "";
            this.txtpassword.ShadowDecoration.Parent = this.txtpassword;
            this.txtpassword.Size = new System.Drawing.Size(222, 36);
            this.txtpassword.TabIndex = 19;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtuserrole
            // 
            this.txtuserrole.BackColor = System.Drawing.Color.Transparent;
            this.txtuserrole.BorderColor = System.Drawing.Color.Black;
            this.txtuserrole.BorderRadius = 20;
            this.txtuserrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtuserrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtuserrole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuserrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuserrole.FocusedState.Parent = this.txtuserrole;
            this.txtuserrole.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtuserrole.ForeColor = System.Drawing.Color.Black;
            this.txtuserrole.HoverState.Parent = this.txtuserrole;
            this.txtuserrole.ItemHeight = 30;
            this.txtuserrole.Items.AddRange(new object[] {
            "",
            "Administrator",
            "Pharmacist"});
            this.txtuserrole.ItemsAppearance.Parent = this.txtuserrole;
            this.txtuserrole.Location = new System.Drawing.Point(33, 133);
            this.txtuserrole.Name = "txtuserrole";
            this.txtuserrole.ShadowDecoration.Parent = this.txtuserrole;
            this.txtuserrole.Size = new System.Drawing.Size(228, 36);
            this.txtuserrole.StartIndex = 0;
            this.txtuserrole.TabIndex = 21;
            // 
            // btnreset
            // 
            this.btnreset.BorderRadius = 20;
            this.btnreset.BorderThickness = 1;
            this.btnreset.CheckedState.Parent = this.btnreset;
            this.btnreset.CustomImages.Parent = this.btnreset;
            this.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreset.DisabledState.Parent = this.btnreset;
            this.btnreset.FillColor = System.Drawing.Color.DimGray;
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Black;
            this.btnreset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnreset.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnreset.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnreset.HoverState.Parent = this.btnreset;
            this.btnreset.Location = new System.Drawing.Point(748, 631);
            this.btnreset.Name = "btnreset";
            this.btnreset.ShadowDecoration.Parent = this.btnreset;
            this.btnreset.Size = new System.Drawing.Size(171, 50);
            this.btnreset.TabIndex = 22;
            this.btnreset.Text = "RESET";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsignin
            // 
            this.btnsignin.BorderRadius = 20;
            this.btnsignin.BorderThickness = 1;
            this.btnsignin.CheckedState.Parent = this.btnsignin;
            this.btnsignin.CustomImages.Parent = this.btnsignin;
            this.btnsignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsignin.DisabledState.Parent = this.btnsignin;
            this.btnsignin.FillColor = System.Drawing.Color.DimGray;
            this.btnsignin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.Black;
            this.btnsignin.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnsignin.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnsignin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnsignin.HoverState.Parent = this.btnsignin;
            this.btnsignin.Location = new System.Drawing.Point(441, 631);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.ShadowDecoration.Parent = this.btnsignin;
            this.btnsignin.Size = new System.Drawing.Size(180, 50);
            this.btnsignin.TabIndex = 23;
            this.btnsignin.Text = "SIGN IN";
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // hidepass
            // 
            this.hidepass.BorderColor = System.Drawing.Color.Transparent;
            this.hidepass.CheckedState.Parent = this.hidepass;
            this.hidepass.CustomImages.Parent = this.hidepass;
            this.hidepass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hidepass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hidepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hidepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hidepass.DisabledState.Parent = this.hidepass;
            this.hidepass.FillColor = System.Drawing.Color.White;
            this.hidepass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hidepass.ForeColor = System.Drawing.Color.White;
            this.hidepass.HoverState.Parent = this.hidepass;
            this.hidepass.Image = ((System.Drawing.Image)(resources.GetObject("hidepass.Image")));
            this.hidepass.Location = new System.Drawing.Point(647, 443);
            this.hidepass.Name = "hidepass";
            this.hidepass.ShadowDecoration.Parent = this.hidepass;
            this.hidepass.Size = new System.Drawing.Size(29, 29);
            this.hidepass.TabIndex = 24;
            this.hidepass.Click += new System.EventHandler(this.hidepass_Click_1);
            // 
            // showpass
            // 
            this.showpass.BorderColor = System.Drawing.Color.Transparent;
            this.showpass.CheckedState.Parent = this.showpass;
            this.showpass.CustomImages.Parent = this.showpass;
            this.showpass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showpass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showpass.DisabledState.Parent = this.showpass;
            this.showpass.FillColor = System.Drawing.Color.White;
            this.showpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showpass.ForeColor = System.Drawing.Color.White;
            this.showpass.HoverState.Parent = this.showpass;
            this.showpass.Image = ((System.Drawing.Image)(resources.GetObject("showpass.Image")));
            this.showpass.Location = new System.Drawing.Point(647, 443);
            this.showpass.Name = "showpass";
            this.showpass.ShadowDecoration.Parent = this.showpass;
            this.showpass.Size = new System.Drawing.Size(29, 29);
            this.showpass.TabIndex = 25;
            this.showpass.Click += new System.EventHandler(this.showpass_Click_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.hidepass);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtuserrole);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.txtphno);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "UC_adduser";
            this.Size = new System.Drawing.Size(1010, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtphno;
        private Guna.UI2.WinForms.Guna2TextBox txtfullname;
        private Guna.UI2.WinForms.Guna2TextBox txtemailid;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2Button btnsignin;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private Guna.UI2.WinForms.Guna2ComboBox txtuserrole;
        private Guna.UI2.WinForms.Guna2Button showpass;
        private Guna.UI2.WinForms.Guna2Button hidepass;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
