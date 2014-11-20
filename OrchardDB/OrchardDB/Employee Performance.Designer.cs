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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportData = new OrchardDB.ReportData();
            this.JCMA_PICKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JCMA_PICKSTableAdapter = new OrchardDB.ReportDataTableAdapters.JCMA_PICKSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JCMA_PICKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet12";
            reportDataSource1.Value = this.JCMA_PICKSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OrchardDB.EmployeePerformance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(52, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1045, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportData
            // 
            this.ReportData.DataSetName = "ReportData";
            this.ReportData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JCMA_PICKSBindingSource
            // 
            this.JCMA_PICKSBindingSource.DataMember = "JCMA_PICKS";
            this.JCMA_PICKSBindingSource.DataSource = this.ReportData;
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
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JCMA_PICKSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JCMA_PICKSBindingSource;
        private ReportData ReportData;
        private ReportDataTableAdapters.JCMA_PICKSTableAdapter JCMA_PICKSTableAdapter;
    }
}