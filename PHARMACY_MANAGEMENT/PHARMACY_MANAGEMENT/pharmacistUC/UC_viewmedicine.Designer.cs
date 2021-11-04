
namespace PHARMACY_MANAGEMENT.pharmacistUC
{
    partial class UC_viewmedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.meddataview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnexport = new Guna.UI2.WinForms.Guna2Button();
            this.pHARMACYDataSet = new PHARMACY_MANAGEMENT.PHARMACYDataSet();
            this.medsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medsTableAdapter = new PHARMACY_MANAGEMENT.PHARMACYDataSetTableAdapters.medsTableAdapter();
            this.pHARMACYDataSet1 = new PHARMACY_MANAGEMENT.PHARMACYDataSet1();
            this.medsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medsTableAdapter1 = new PHARMACY_MANAGEMENT.PHARMACYDataSet1TableAdapters.medsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.meddataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHARMACYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHARMACYDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(375, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "VIEW MEDICINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "MEDICINE NAME";
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
            this.txtsearch.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.HoverState.Parent = this.txtsearch;
            this.txtsearch.Location = new System.Drawing.Point(448, 107);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtsearch.PlaceholderText = "Search";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(248, 36);
            this.txtsearch.TabIndex = 17;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // meddataview
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.meddataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.meddataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.meddataview.BackgroundColor = System.Drawing.Color.White;
            this.meddataview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meddataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.meddataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.meddataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.meddataview.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.meddataview.DefaultCellStyle = dataGridViewCellStyle6;
            this.meddataview.EnableHeadersVisualStyles = false;
            this.meddataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.meddataview.Location = new System.Drawing.Point(41, 196);
            this.meddataview.Name = "meddataview";
            this.meddataview.RowHeadersVisible = false;
            this.meddataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.meddataview.Size = new System.Drawing.Size(903, 379);
            this.meddataview.TabIndex = 26;
            this.meddataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.meddataview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.meddataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.meddataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.meddataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.meddataview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.meddataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.meddataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.meddataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.meddataview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.meddataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.meddataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.meddataview.ThemeStyle.HeaderStyle.Height = 20;
            this.meddataview.ThemeStyle.ReadOnly = false;
            this.meddataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.meddataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.meddataview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.meddataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.meddataview.ThemeStyle.RowsStyle.Height = 22;
            this.meddataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.meddataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.meddataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meddataview_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BorderRadius = 20;
            this.btndelete.BorderThickness = 1;
            this.btndelete.CheckedState.Parent = this.btndelete;
            this.btndelete.CustomImages.Parent = this.btndelete;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.DisabledState.Parent = this.btndelete;
            this.btndelete.FillColor = System.Drawing.Color.Khaki;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btndelete.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btndelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverState.Parent = this.btndelete;
            this.btndelete.Location = new System.Drawing.Point(764, 632);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(180, 45);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            this.btnrefresh.FillColor = System.Drawing.Color.Khaki;
            this.btnrefresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnrefresh.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnrefresh.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.HoverState.Parent = this.btnrefresh;
            this.btnrefresh.Location = new System.Drawing.Point(483, 632);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ShadowDecoration.Parent = this.btnrefresh;
            this.btnrefresh.Size = new System.Drawing.Size(180, 45);
            this.btnrefresh.TabIndex = 28;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnexport
            // 
            this.btnexport.BorderRadius = 20;
            this.btnexport.BorderThickness = 1;
            this.btnexport.CheckedState.Parent = this.btnexport;
            this.btnexport.CustomImages.Parent = this.btnexport;
            this.btnexport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexport.DisabledState.Parent = this.btnexport;
            this.btnexport.FillColor = System.Drawing.Color.Khaki;
            this.btnexport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnexport.ForeColor = System.Drawing.Color.Black;
            this.btnexport.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnexport.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnexport.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnexport.HoverState.Parent = this.btnexport;
            this.btnexport.Location = new System.Drawing.Point(23, 632);
            this.btnexport.Name = "btnexport";
            this.btnexport.ShadowDecoration.Parent = this.btnexport;
            this.btnexport.Size = new System.Drawing.Size(180, 45);
            this.btnexport.TabIndex = 29;
            this.btnexport.Text = "EXPORT";
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // pHARMACYDataSet
            // 
            this.pHARMACYDataSet.DataSetName = "PHARMACYDataSet";
            this.pHARMACYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medsBindingSource
            // 
            this.medsBindingSource.DataMember = "meds";
            this.medsBindingSource.DataSource = this.pHARMACYDataSet;
            // 
            // medsTableAdapter
            // 
            this.medsTableAdapter.ClearBeforeFill = true;
            // 
            // pHARMACYDataSet1
            // 
            this.pHARMACYDataSet1.DataSetName = "PHARMACYDataSet1";
            this.pHARMACYDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medsBindingSource1
            // 
            this.medsBindingSource1.DataMember = "meds";
            this.medsBindingSource1.DataSource = this.pHARMACYDataSet1;
            // 
            // medsTableAdapter1
            // 
            this.medsTableAdapter1.ClearBeforeFill = true;
            // 
            // UC_viewmedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.meddataview);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "UC_viewmedicine";
            this.Size = new System.Drawing.Size(1010, 720);
            this.Load += new System.EventHandler(this.UC_viewmedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meddataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHARMACYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHARMACYDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2DataGridView meddataview;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.BindingSource medsBindingSource;
        private PHARMACYDataSet pHARMACYDataSet;
        private Guna.UI2.WinForms.Guna2Button btnexport;
        private PHARMACYDataSetTableAdapters.medsTableAdapter medsTableAdapter;
        private System.Windows.Forms.BindingSource medsBindingSource1;
        private PHARMACYDataSet1 pHARMACYDataSet1;
        private PHARMACYDataSet1TableAdapters.medsTableAdapter medsTableAdapter1;
    }
}
