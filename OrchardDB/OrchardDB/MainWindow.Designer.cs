namespace OrchardDB
{
    partial class MainWindow
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
            System.Windows.Forms.Label lOCATIONLabel;
            System.Windows.Forms.Label fARM_NAMELabel;
            System.Windows.Forms.Label oWNERLabel;
            this.jCMA_FIELDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jCMA_FARMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jCMA_FIELDSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATIONTextBox = new System.Windows.Forms.TextBox();
            this.fARM_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.oWNERTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_Farm_Button = new System.Windows.Forms.Button();
            lOCATIONLabel = new System.Windows.Forms.Label();
            fARM_NAMELabel = new System.Windows.Forms.Label();
            oWNERLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FIELDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FARMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FIELDSDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOCATIONLabel
            // 
            lOCATIONLabel.AutoSize = true;
            lOCATIONLabel.Location = new System.Drawing.Point(17, 45);
            lOCATIONLabel.Name = "lOCATIONLabel";
            lOCATIONLabel.Size = new System.Drawing.Size(64, 13);
            lOCATIONLabel.TabIndex = 4;
            lOCATIONLabel.Text = "LOCATION:";
            // 
            // fARM_NAMELabel
            // 
            fARM_NAMELabel.AutoSize = true;
            fARM_NAMELabel.Location = new System.Drawing.Point(7, 18);
            fARM_NAMELabel.Name = "fARM_NAMELabel";
            fARM_NAMELabel.Size = new System.Drawing.Size(74, 13);
            fARM_NAMELabel.TabIndex = 5;
            fARM_NAMELabel.Text = "FARM NAME:";
            // 
            // oWNERLabel
            // 
            oWNERLabel.AutoSize = true;
            oWNERLabel.Location = new System.Drawing.Point(29, 74);
            oWNERLabel.Name = "oWNERLabel";
            oWNERLabel.Size = new System.Drawing.Size(52, 13);
            oWNERLabel.TabIndex = 6;
            oWNERLabel.Text = "OWNER:";
            // 
            // jCMA_FIELDSBindingSource
            // 
            this.jCMA_FIELDSBindingSource.DataMember = "JCMA_FIELDS";
            this.jCMA_FIELDSBindingSource.DataSource = this.jCMA_FARMBindingSource;
            // 
            // jCMA_FARMBindingSource
            // 
            this.jCMA_FARMBindingSource.DataSource = typeof(OrchardDB.JCMA_FARM);
            // 
            // jCMA_FIELDSDataGridView
            // 
            this.jCMA_FIELDSDataGridView.AutoGenerateColumns = false;
            this.jCMA_FIELDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jCMA_FIELDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.jCMA_FIELDSDataGridView.DataSource = this.jCMA_FIELDSBindingSource;
            this.jCMA_FIELDSDataGridView.Location = new System.Drawing.Point(12, 161);
            this.jCMA_FIELDSDataGridView.Name = "jCMA_FIELDSDataGridView";
            this.jCMA_FIELDSDataGridView.Size = new System.Drawing.Size(1062, 373);
            this.jCMA_FIELDSDataGridView.TabIndex = 3;
            this.jCMA_FIELDSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jCMA_FIELDSDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FIELD_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FIELD_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FARM_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "FARM_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CROP";
            this.dataGridViewTextBoxColumn3.HeaderText = "CROP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VARIETY";
            this.dataGridViewTextBoxColumn4.HeaderText = "VARIETY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "JCMA_FARM";
            this.dataGridViewTextBoxColumn5.HeaderText = "JCMA_FARM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // lOCATIONTextBox
            // 
            this.lOCATIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jCMA_FARMBindingSource, "LOCATION", true));
            this.lOCATIONTextBox.Location = new System.Drawing.Point(87, 45);
            this.lOCATIONTextBox.Name = "lOCATIONTextBox";
            this.lOCATIONTextBox.Size = new System.Drawing.Size(190, 20);
            this.lOCATIONTextBox.TabIndex = 5;
            // 
            // fARM_NAMEComboBox
            // 
            this.fARM_NAMEComboBox.DataSource = this.jCMA_FARMBindingSource;
            this.fARM_NAMEComboBox.DisplayMember = "FARM_NAME";
            this.fARM_NAMEComboBox.FormattingEnabled = true;
            this.fARM_NAMEComboBox.Location = new System.Drawing.Point(87, 15);
            this.fARM_NAMEComboBox.Name = "fARM_NAMEComboBox";
            this.fARM_NAMEComboBox.Size = new System.Drawing.Size(190, 21);
            this.fARM_NAMEComboBox.TabIndex = 6;
            // 
            // oWNERTextBox
            // 
            this.oWNERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jCMA_FARMBindingSource, "OWNER", true));
            this.oWNERTextBox.Location = new System.Drawing.Point(87, 71);
            this.oWNERTextBox.Name = "oWNERTextBox";
            this.oWNERTextBox.Size = new System.Drawing.Size(190, 20);
            this.oWNERTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_Farm_Button);
            this.groupBox1.Controls.Add(this.lOCATIONTextBox);
            this.groupBox1.Controls.Add(oWNERLabel);
            this.groupBox1.Controls.Add(lOCATIONLabel);
            this.groupBox1.Controls.Add(this.oWNERTextBox);
            this.groupBox1.Controls.Add(this.fARM_NAMEComboBox);
            this.groupBox1.Controls.Add(fARM_NAMELabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Add_Farm_Button
            // 
            this.Add_Farm_Button.Location = new System.Drawing.Point(87, 97);
            this.Add_Farm_Button.Name = "Add_Farm_Button";
            this.Add_Farm_Button.Size = new System.Drawing.Size(190, 23);
            this.Add_Farm_Button.TabIndex = 8;
            this.Add_Farm_Button.Text = "Add New Farm";
            this.Add_Farm_Button.UseVisualStyleBackColor = true;
            this.Add_Farm_Button.Click += new System.EventHandler(this.Add_Farm_Button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jCMA_FIELDSDataGridView);
            this.Name = "MainWindow";
            this.Text = "Orchard DB";
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FIELDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FARMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FIELDSDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource jCMA_FARMBindingSource;
        private System.Windows.Forms.DataGridView jCMA_FIELDSDataGridView;
        private System.Windows.Forms.BindingSource jCMA_FIELDSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox lOCATIONTextBox;
        private System.Windows.Forms.ComboBox fARM_NAMEComboBox;
        private System.Windows.Forms.TextBox oWNERTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_Farm_Button;
    }
}

