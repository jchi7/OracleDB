namespace OrchardDB
{
    partial class AddFieldForm
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
            this.Save_Field_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save_Field_Button
            // 
            this.Save_Field_Button.Location = new System.Drawing.Point(116, 227);
            this.Save_Field_Button.Name = "Save_Field_Button";
            this.Save_Field_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Field_Button.TabIndex = 0;
            this.Save_Field_Button.Text = "Save";
            this.Save_Field_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(197, 227);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // AddFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Field_Button);
            this.Name = "AddFieldForm";
            this.Text = "AddFieldForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_Field_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}