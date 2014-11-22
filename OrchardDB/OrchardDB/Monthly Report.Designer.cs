namespace OrchardDB
{
    partial class Monthly_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.JCMA_PICKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportData = new OrchardDB.ReportData();
            this.MonthlyReportForm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.JCMA_PICKSTableAdapter = new OrchardDB.ReportDataTableAdapters.JCMA_PICKSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.JCMA_PICKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).BeginInit();
            this.SuspendLayout();
            // 
            // JCMA_PICKSBindingSource
            // 
            this.JCMA_PICKSBindingSource.DataMember = "JCMA_PICKS";
            this.JCMA_PICKSBindingSource.DataSource = this.ReportData;
            // 
            // ReportData
            // 
            this.ReportData.DataSetName = "ReportData";
            this.ReportData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MonthlyReportForm
            // 
            this.MonthlyReportForm.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.JCMA_PICKSBindingSource;
            this.MonthlyReportForm.LocalReport.DataSources.Add(reportDataSource1);
            this.MonthlyReportForm.LocalReport.ReportEmbeddedResource = "OrchardDB.MonthlyPerformance.rdlc";
            this.MonthlyReportForm.Location = new System.Drawing.Point(0, 0);
            this.MonthlyReportForm.Name = "MonthlyReportForm";
            this.MonthlyReportForm.Size = new System.Drawing.Size(1064, 520);
            this.MonthlyReportForm.TabIndex = 0;
            // 
            // JCMA_PICKSTableAdapter
            // 
            this.JCMA_PICKSTableAdapter.ClearBeforeFill = true;
            // 
            // Monthly_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 520);
            this.Controls.Add(this.MonthlyReportForm);
            this.Name = "Monthly_Report";
            this.Text = "Monthly_Report";
            this.Load += new System.EventHandler(this.Monthly_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JCMA_PICKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer MonthlyReportForm;
        private System.Windows.Forms.BindingSource JCMA_PICKSBindingSource;
        private ReportData ReportData;
        private ReportDataTableAdapters.JCMA_PICKSTableAdapter JCMA_PICKSTableAdapter;
    }
}