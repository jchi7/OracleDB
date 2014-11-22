namespace OrchardDB
{
    partial class Choose_Month
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
            this.MonthDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthYearText = new System.Windows.Forms.TextBox();
            this.ViewMonthReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthDropDown
            // 
            this.MonthDropDown.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.MonthDropDown.Location = new System.Drawing.Point(124, 58);
            this.MonthDropDown.MaxDropDownItems = 12;
            this.MonthDropDown.Name = "MonthDropDown";
            this.MonthDropDown.Size = new System.Drawing.Size(121, 21);
            this.MonthDropDown.TabIndex = 0;
            this.MonthDropDown.SelectedIndexChanged += new System.EventHandler(this.MonthDropDown_SelectedIndexChanged);
            this.MonthDropDown.TextChanged += new System.EventHandler(this.MonthDropDown_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose A Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter a Year";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MonthYearText
            // 
            this.MonthYearText.Location = new System.Drawing.Point(124, 99);
            this.MonthYearText.Name = "MonthYearText";
            this.MonthYearText.Size = new System.Drawing.Size(121, 20);
            this.MonthYearText.TabIndex = 3;
            this.MonthYearText.Text = "YYYY";
            // 
            // ViewMonthReport
            // 
            this.ViewMonthReport.Location = new System.Drawing.Point(124, 159);
            this.ViewMonthReport.Name = "ViewMonthReport";
            this.ViewMonthReport.Size = new System.Drawing.Size(121, 23);
            this.ViewMonthReport.TabIndex = 4;
            this.ViewMonthReport.Text = "View Monthly Report";
            this.ViewMonthReport.UseVisualStyleBackColor = true;
            this.ViewMonthReport.Click += new System.EventHandler(this.ViewMonthReport_Click);
            // 
            // Choose_Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 228);
            this.Controls.Add(this.ViewMonthReport);
            this.Controls.Add(this.MonthYearText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonthDropDown);
            this.Name = "Choose_Month";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose_Month";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MonthDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MonthYearText;
        private System.Windows.Forms.Button ViewMonthReport;
    }
}