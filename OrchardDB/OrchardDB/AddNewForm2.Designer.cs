namespace OrchardDB
{
    partial class AddNewForm2
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
            this.AddDataGrid = new System.Windows.Forms.DataGridView();
            this.Farm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDataGrid
            // 
            this.AddDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Farm_Name,
            this.Location,
            this.Owner_Name});
            this.AddDataGrid.Location = new System.Drawing.Point(12, 12);
            this.AddDataGrid.Name = "AddDataGrid";
            this.AddDataGrid.Size = new System.Drawing.Size(604, 378);
            this.AddDataGrid.TabIndex = 0;
            // 
            // Farm_Name
            // 
            this.Farm_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Farm_Name.HeaderText = "Farm Name";
            this.Farm_Name.Name = "Farm_Name";
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Owner_Name
            // 
            this.Owner_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Owner_Name.HeaderText = "Owner Name";
            this.Owner_Name.Name = "Owner_Name";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(420, 401);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(86, 23);
            this.Save_button.TabIndex = 1;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(523, 401);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(86, 23);
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // AddNewForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 436);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.AddDataGrid);
            this.Name = "AddNewForm2";
            this.Text = "AddNewForm2";
            ((System.ComponentModel.ISupportInitialize)(this.AddDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AddDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Farm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner_Name;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}