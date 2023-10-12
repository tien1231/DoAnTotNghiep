
namespace DoAnCShap
{
    partial class Frm_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Report));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LinhKienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PM_BanLinhKienPCDataSet = new DoAnCShap.PM_BanLinhKienPCDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LinhKienTableAdapter = new DoAnCShap.PM_BanLinhKienPCDataSetTableAdapters.LinhKienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LinhKienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PM_BanLinhKienPCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinhKienBindingSource
            // 
            this.LinhKienBindingSource.DataMember = "LinhKien";
            this.LinhKienBindingSource.DataSource = this.PM_BanLinhKienPCDataSet;
            // 
            // PM_BanLinhKienPCDataSet
            // 
            this.PM_BanLinhKienPCDataSet.DataSetName = "PM_BanLinhKienPCDataSet";
            this.PM_BanLinhKienPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(730, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 39);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet5";
            reportDataSource1.Value = this.LinhKienBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "DoAnCShap.TKSPHetHang.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 49);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 701);
            this.reportViewer2.TabIndex = 2;
            // 
            // LinhKienTableAdapter
            // 
            this.LinhKienTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Report";
            this.Load += new System.EventHandler(this.Frm_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinhKienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PM_BanLinhKienPCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource LinhKienBindingSource;
        private PM_BanLinhKienPCDataSet PM_BanLinhKienPCDataSet;
        private PM_BanLinhKienPCDataSetTableAdapters.LinhKienTableAdapter LinhKienTableAdapter;
    }
}