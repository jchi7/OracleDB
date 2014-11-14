namespace OrchardDB
{
    partial class AddFarmForm
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
            this.Owner_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Location_Textbox = new System.Windows.Forms.TextBox();
            this.Farm_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Owner_Name_TextBox
            // 
            this.Owner_Name_TextBox.Location = new System.Drawing.Point(116, 112);
            this.Owner_Name_TextBox.Name = "Owner_Name_TextBox";
            this.Owner_Name_TextBox.Size = new System.Drawing.Size(143, 20);
            this.Owner_Name_TextBox.TabIndex = 0;
            // 
            // Location_Textbox
            // 
            this.Location_Textbox.Location = new System.Drawing.Point(116, 76);
            this.Location_Textbox.Name = "Location_Textbox";
            this.Location_Textbox.Size = new System.Drawing.Size(143, 20);
            this.Location_Textbox.TabIndex = 1;
            // 
            // Farm_Name_TextBox
            // 
            this.Farm_Name_TextBox.Location = new System.Drawing.Point(116, 41);
            this.Farm_Name_TextBox.Name = "Farm_Name_TextBox";
            this.Farm_Name_TextBox.Size = new System.Drawing.Size(143, 20);
            this.Farm_Name_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Farm Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Owner Name";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(103, 163);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Farm_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(184, 163);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 7;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // AddFarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Farm_Name_TextBox);
            this.Controls.Add(this.Location_Textbox);
            this.Controls.Add(this.Owner_Name_TextBox);
            this.Name = "AddFarmForm";
            this.Text = "Add New Farm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Owner_Name_TextBox;
        private System.Windows.Forms.TextBox Location_Textbox;
        private System.Windows.Forms.TextBox Farm_Name_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_button;
    }
}