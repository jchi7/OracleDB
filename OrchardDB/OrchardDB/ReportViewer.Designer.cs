namespace OrchardDB
{
    partial class ReportViewer
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
            this.UpdateReport = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jCMA_PICKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportData = new OrchardDB.ReportData();
            this.JCMA_PICKSTableAdapter = new OrchardDB.ReportDataTableAdapters.JCMA_PICKSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_PICKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Picks";
            reportDataSource1.Value = this.jCMA_PICKSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OrchardDB.EmployeePicks.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1306, 628);
            this.reportViewer1.TabIndex = 0;
            // 
            // UpdateReport
            // 
            this.UpdateReport.Location = new System.Drawing.Point(470, 29);
            this.UpdateReport.Name = "UpdateReport";
            this.UpdateReport.Size = new System.Drawing.Size(110, 23);
            this.UpdateReport.TabIndex = 1;
            this.UpdateReport.Text = "Update Report";
            this.UpdateReport.UseVisualStyleBackColor = true;
            this.UpdateReport.Click += new System.EventHandler(this.UpdateReport_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(357, 31);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 20);
            this.Search.TabIndex = 2;
            this.Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID:";
            // 
            // jCMA_PICKSBindingSource
            // 
            this.jCMA_PICKSBindingSource.DataSource = typeof(OrchardDB.JCMA_PICKS);
            // 
            // ReportData
            // 
            this.ReportData.DataSetName = "ReportData";
            this.ReportData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JCMA_PICKSTableAdapter
            // 
            this.JCMA_PICKSTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.UpdateReport);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_PICKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource jCMA_PICKSBindingSource;
        private System.Windows.Forms.Button UpdateReport;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private ReportData ReportData;
        private ReportDataTableAdapters.JCMA_PICKSTableAdapter JCMA_PICKSTableAdapter;
    }
}