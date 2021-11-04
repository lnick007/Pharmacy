
namespace PHARMACY_MANAGEMENT
{
    partial class admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprofile = new Guna.UI2.WinForms.Guna2Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btncustomizeuser = new Guna.UI2.WinForms.Guna2Button();
            this.btnadduser = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_profile1 = new PHARMACY_MANAGEMENT.adminUC.UC_profile();
            this.uC_customizeuser1 = new PHARMACY_MANAGEMENT.adminUC.UC_customizeuser();
            this.uC_adduser1 = new PHARMACY_MANAGEMENT.adminUC.UC_adduser();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btnprofile);
            this.panel1.Controls.Add(this.usernamelabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btncustomizeuser);
            this.panel1.Controls.Add(this.btnadduser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 720);
            this.panel1.TabIndex = 0;
            // 
            // btnprofile
            // 
            this.btnprofile.BorderRadius = 20;
            this.btnprofile.CheckedState.Parent = this.btnprofile;
            this.btnprofile.CustomImages.Parent = this.btnprofile;
            this.btnprofile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprofile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprofile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprofile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprofile.DisabledState.Parent = this.btnprofile;
            this.btnprofile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnprofile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnprofile.ForeColor = System.Drawing.Color.Black;
            this.btnprofile.HoverState.Parent = this.btnprofile;
            this.btnprofile.Location = new System.Drawing.Point(40, 391);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.ShadowDecoration.Parent = this.btnprofile;
            this.btnprofile.Size = new System.Drawing.Size(180, 45);
            this.btnprofile.TabIndex = 6;
            this.btnprofile.Text = "PROFILE";
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.usernamelabel.Location = new System.Drawing.Point(36, 616);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(184, 24);
            this.usernamelabel.TabIndex = 5;
            this.usernamelabel.Text = "username";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMINISTRATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnlogout
            // 
            this.btnlogout.BorderRadius = 20;
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogout.DisabledState.Parent = this.btnlogout;
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlogout.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Location = new System.Drawing.Point(40, 504);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(180, 45);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btncustomizeuser
            // 
            this.btncustomizeuser.BorderRadius = 20;
            this.btncustomizeuser.CheckedState.Parent = this.btncustomizeuser;
            this.btncustomizeuser.CustomImages.Parent = this.btncustomizeuser;
            this.btncustomizeuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncustomizeuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncustomizeuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncustomizeuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncustomizeuser.DisabledState.Parent = this.btncustomizeuser;
            this.btncustomizeuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncustomizeuser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncustomizeuser.ForeColor = System.Drawing.Color.Black;
            this.btncustomizeuser.HoverState.Parent = this.btncustomizeuser;
            this.btncustomizeuser.Location = new System.Drawing.Point(40, 279);
            this.btncustomizeuser.Name = "btncustomizeuser";
            this.btncustomizeuser.ShadowDecoration.Parent = this.btncustomizeuser;
            this.btncustomizeuser.Size = new System.Drawing.Size(180, 45);
            this.btncustomizeuser.TabIndex = 1;
            this.btncustomizeuser.Text = "CUSTOMIZE USER";
            this.btncustomizeuser.Click += new System.EventHandler(this.btncustomizeuser_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BorderRadius = 20;
            this.btnadduser.CheckedState.Parent = this.btnadduser;
            this.btnadduser.CustomImages.Parent = this.btnadduser;
            this.btnadduser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadduser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadduser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadduser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadduser.DisabledState.Parent = this.btnadduser;
            this.btnadduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnadduser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadduser.ForeColor = System.Drawing.Color.Black;
            this.btnadduser.HoverState.Parent = this.btnadduser;
            this.btnadduser.Location = new System.Drawing.Point(40, 166);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.ShadowDecoration.Parent = this.btnadduser;
            this.btnadduser.Size = new System.Drawing.Size(180, 45);
            this.btnadduser.TabIndex = 0;
            this.btnadduser.Text = "ADD USER";
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.uC_profile1);
            this.panel2.Controls.Add(this.uC_customizeuser1);
            this.panel2.Controls.Add(this.uC_adduser1);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 720);
            this.panel2.TabIndex = 1;
            // 
            // uC_profile1
            // 
            this.uC_profile1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.uC_profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_profile1.Name = "uC_profile1";
            this.uC_profile1.Size = new System.Drawing.Size(1010, 720);
            this.uC_profile1.TabIndex = 3;
            // 
            // uC_customizeuser1
            // 
            this.uC_customizeuser1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_customizeuser1.Location = new System.Drawing.Point(0, 0);
            this.uC_customizeuser1.Name = "uC_customizeuser1";
            this.uC_customizeuser1.Size = new System.Drawing.Size(1010, 720);
            this.uC_customizeuser1.TabIndex = 2;
            // 
            // uC_adduser1
            // 
            this.uC_adduser1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uC_adduser1.Location = new System.Drawing.Point(0, 0);
            this.uC_adduser1.Name = "uC_adduser1";
            this.uC_adduser1.Size = new System.Drawing.Size(1010, 720);
            this.uC_adduser1.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1010, 720);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btncustomizeuser;
        private Guna.UI2.WinForms.Guna2Button btnadduser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernamelabel;
        private Guna.UI2.WinForms.Guna2Button btnprofile;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private adminUC.UC_profile uC_profile1;
        private adminUC.UC_customizeuser uC_customizeuser1;
        private adminUC.UC_adduser uC_adduser1;
    }
}