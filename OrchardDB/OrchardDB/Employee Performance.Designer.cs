namespace OrchardDB
{
    partial class Employee_Performance
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet12";
            reportDataSource1.Value = this.JCMA_PICKSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OrchardDB.EmployeePerformance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1099, 606);
            this.reportViewer1.TabIndex = 0;
            // 
            // JCMA_PICKSTableAdapter
            // 
            this.JCMA_PICKSTableAdapter.ClearBeforeFill = true;
            // 
            // Employee_Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 606);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Employee_Performance";
            this.Text = "Employee_Performance";
            this.Load += new System.EventHandler(this.Employee_Performance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JCMA_PICKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JCMA_PICKSBindingSource;
        private ReportData ReportData;
        private ReportDataTableAdapters.JCMA_PICKSTableAdapter JCMA_PICKSTableAdapter;
    }
}