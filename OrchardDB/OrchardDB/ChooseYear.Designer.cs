namespace OrchardDB
{
    partial class ChooseYear
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
            this.label1 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.YearlyReportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Year";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(84, 80);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(100, 20);
            this.Year.TabIndex = 1;
            this.Year.Text = "YYYY";
            // 
            // YearlyReportBtn
            // 
            this.YearlyReportBtn.Location = new System.Drawing.Point(200, 149);
            this.YearlyReportBtn.Name = "YearlyReportBtn";
            this.YearlyReportBtn.Size = new System.Drawing.Size(119, 23);
            this.YearlyReportBtn.TabIndex = 2;
            this.YearlyReportBtn.Text = "View Yearly Report";
            this.YearlyReportBtn.UseVisualStyleBackColor = true;
            this.YearlyReportBtn.Click += new System.EventHandler(this.YearlyReportBtn_Click);
            // 
            // ChooseYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 195);
            this.Controls.Add(this.YearlyReportBtn);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label1);
            this.Name = "ChooseYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseYear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Button YearlyReportBtn;
    }
}