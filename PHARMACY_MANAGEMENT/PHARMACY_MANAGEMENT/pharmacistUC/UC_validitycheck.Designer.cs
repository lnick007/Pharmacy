
namespace PHARMACY_MANAGEMENT.pharmacistUC
{
    partial class UC_validitycheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.setlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcheck = new Guna.UI2.WinForms.Guna2ComboBox();
            this.valcheckdataview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.valcheckdataview)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(285, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = " MEDICINE VALIDITY CHECK";
            // 
            // setlabel
            // 
            this.setlabel.AutoSize = true;
            this.setlabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setlabel.Location = new System.Drawing.Point(41, 216);
            this.setlabel.Name = "setlabel";
            this.setlabel.Size = new System.Drawing.Size(84, 31);
            this.setlabel.TabIndex = 10;
            this.setlabel.Text = "label1";
            this.setlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "CHECK";
            // 
            // txtcheck
            // 
            this.txtcheck.BackColor = System.Drawing.Color.Transparent;
            this.txtcheck.BorderColor = System.Drawing.Color.White;
            this.txtcheck.BorderRadius = 20;
            this.txtcheck.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtcheck.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcheck.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcheck.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcheck.FocusedState.Parent = this.txtcheck;
            this.txtcheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcheck.ForeColor = System.Drawing.Color.Black;
            this.txtcheck.HoverState.Parent = this.txtcheck;
            this.txtcheck.ItemHeight = 30;
            this.txtcheck.Items.AddRange(new object[] {
            "",
            "Valid Medicines",
            "Expired Medicines",
            "All Medicines"});
            this.txtcheck.ItemsAppearance.Parent = this.txtcheck;
            this.txtcheck.Location = new System.Drawing.Point(213, 123);
            this.txtcheck.Name = "txtcheck";
            this.txtcheck.ShadowDecoration.Parent = this.txtcheck;
            this.txtcheck.Size = new System.Drawing.Size(315, 36);
            this.txtcheck.TabIndex = 12;
            this.txtcheck.SelectedIndexChanged += new System.EventHandler(this.txtcheck_SelectedIndexChanged);
            // 
            // valcheckdataview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.valcheckdataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.valcheckdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.valcheckdataview.BackgroundColor = System.Drawing.Color.White;
            this.valcheckdataview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valcheckdataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.valcheckdataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.valcheckdataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.valcheckdataview.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.valcheckdataview.DefaultCellStyle = dataGridViewCellStyle3;
            this.valcheckdataview.EnableHeadersVisualStyles = false;
            this.valcheckdataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.valcheckdataview.Location = new System.Drawing.Point(31, 260);
            this.valcheckdataview.Name = "valcheckdataview";
            this.valcheckdataview.ReadOnly = true;
            this.valcheckdataview.RowHeadersVisible = false;
            this.valcheckdataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.valcheckdataview.Size = new System.Drawing.Size(935, 406);
            this.valcheckdataview.TabIndex = 26;
            this.valcheckdataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.valcheckdataview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.valcheckdataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.valcheckdataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.valcheckdataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.valcheckdataview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.valcheckdataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.valcheckdataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.valcheckdataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.valcheckdataview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.valcheckdataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.valcheckdataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.valcheckdataview.ThemeStyle.HeaderStyle.Height = 20;
            this.valcheckdataview.ThemeStyle.ReadOnly = true;
            this.valcheckdataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.valcheckdataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.valcheckdataview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.valcheckdataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.valcheckdataview.ThemeStyle.RowsStyle.Height = 22;
            this.valcheckdataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.valcheckdataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_validitycheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.valcheckdataview);
            this.Controls.Add(this.txtcheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setlabel);
            this.Controls.Add(this.label3);
            this.Name = "UC_validitycheck";
            this.Size = new System.Drawing.Size(1010, 720);
            this.Load += new System.EventHandler(this.UC_validitycheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valcheckdataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label setlabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txtcheck;
        private Guna.UI2.WinForms.Guna2DataGridView valcheckdataview;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
