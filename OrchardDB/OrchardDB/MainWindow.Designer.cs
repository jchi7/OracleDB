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
            this.FieldsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lOCATIONTextBox = new System.Windows.Forms.TextBox();
            this.fARM_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.oWNERTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_Farm_Button = new System.Windows.Forms.Button();
            this.MainWindowMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabFarm = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.jCMA_EMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jCMA_EMPLOYEEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lOCATIONLabel = new System.Windows.Forms.Label();
            fARM_NAMELabel = new System.Windows.Forms.Label();
            oWNERLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FIELDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FARMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FIELDSDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.MainWindowMenu.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabFarm.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_EMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_EMPLOYEEDataGridView)).BeginInit();
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
            this.jCMA_FIELDSDataGridView.ContextMenuStrip = this.FieldsMenuStrip;
            this.jCMA_FIELDSDataGridView.DataSource = this.jCMA_FIELDSBindingSource;
            this.jCMA_FIELDSDataGridView.Location = new System.Drawing.Point(0, 0);
            this.jCMA_FIELDSDataGridView.Name = "jCMA_FIELDSDataGridView";
            this.jCMA_FIELDSDataGridView.Size = new System.Drawing.Size(1078, 392);
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
            // FieldsMenuStrip
            // 
            this.FieldsMenuStrip.Name = "contextMenuStrip1";
            this.FieldsMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // lOCATIONTextBox
            // 
            this.lOCATIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jCMA_FARMBindingSource, "LOCATION", true));
            this.lOCATIONTextBox.Location = new System.Drawing.Point(87, 45);
            this.lOCATIONTextBox.Name = "lOCATIONTextBox";
            this.lOCATIONTextBox.Size = new System.Drawing.Size(190, 20);
            this.lOCATIONTextBox.TabIndex = 1;
            // 
            // fARM_NAMEComboBox
            // 
            this.fARM_NAMEComboBox.DataSource = this.jCMA_FARMBindingSource;
            this.fARM_NAMEComboBox.DisplayMember = "FARM_NAME";
            this.fARM_NAMEComboBox.FormattingEnabled = true;
            this.fARM_NAMEComboBox.Location = new System.Drawing.Point(87, 15);
            this.fARM_NAMEComboBox.Name = "fARM_NAMEComboBox";
            this.fARM_NAMEComboBox.Size = new System.Drawing.Size(190, 21);
            this.fARM_NAMEComboBox.TabIndex = 0;
            // 
            // oWNERTextBox
            // 
            this.oWNERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jCMA_FARMBindingSource, "OWNER", true));
            this.oWNERTextBox.Location = new System.Drawing.Point(87, 71);
            this.oWNERTextBox.Name = "oWNERTextBox";
            this.oWNERTextBox.Size = new System.Drawing.Size(190, 20);
            this.oWNERTextBox.TabIndex = 2;
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
            this.groupBox1.Location = new System.Drawing.Point(4, 27);
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
            // MainWindowMenu
            // 
            this.MainWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainWindowMenu.Location = new System.Drawing.Point(0, 0);
            this.MainWindowMenu.Name = "MainWindowMenu";
            this.MainWindowMenu.Size = new System.Drawing.Size(1086, 24);
            this.MainWindowMenu.TabIndex = 9;
            this.MainWindowMenu.Text = "MainWindowMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeeListToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewEmployeeListToolStripMenuItem
            // 
            this.viewEmployeeListToolStripMenuItem.Name = "viewEmployeeListToolStripMenuItem";
            this.viewEmployeeListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.viewEmployeeListToolStripMenuItem.Text = "View Employee List";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFarmToolStripMenuItem,
            this.addFieldToolStripMenuItem,
            this.addBinToolStripMenuItem,
            this.addEmployeeToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // addFarmToolStripMenuItem
            // 
            this.addFarmToolStripMenuItem.Name = "addFarmToolStripMenuItem";
            this.addFarmToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addFarmToolStripMenuItem.Text = "Add Farm";
            this.addFarmToolStripMenuItem.Click += new System.EventHandler(this.addFarmToolStripMenuItem_Click);
            // 
            // addFieldToolStripMenuItem
            // 
            this.addFieldToolStripMenuItem.Name = "addFieldToolStripMenuItem";
            this.addFieldToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addFieldToolStripMenuItem.Text = "Add Field";
            // 
            // addBinToolStripMenuItem
            // 
            this.addBinToolStripMenuItem.Name = "addBinToolStripMenuItem";
            this.addBinToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addBinToolStripMenuItem.Text = "Add Bin";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabFarm);
            this.TabControl.Controls.Add(this.tabEmployee);
            this.TabControl.Location = new System.Drawing.Point(0, 160);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1086, 418);
            this.TabControl.TabIndex = 10;
            // 
            // tabFarm
            // 
            this.tabFarm.Controls.Add(this.jCMA_FIELDSDataGridView);
            this.tabFarm.Location = new System.Drawing.Point(4, 22);
            this.tabFarm.Name = "tabFarm";
            this.tabFarm.Padding = new System.Windows.Forms.Padding(3);
            this.tabFarm.Size = new System.Drawing.Size(1078, 392);
            this.tabFarm.TabIndex = 0;
            this.tabFarm.Text = "Farm";
            this.tabFarm.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.jCMA_EMPLOYEEDataGridView);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1078, 392);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // jCMA_EMPLOYEEBindingSource
            // 
            this.jCMA_EMPLOYEEBindingSource.DataMember = "JCMA_EMPLOYEE";
            this.jCMA_EMPLOYEEBindingSource.DataSource = this.jCMA_FARMBindingSource;
            // 
            // jCMA_EMPLOYEEDataGridView
            // 
            this.jCMA_EMPLOYEEDataGridView.AutoGenerateColumns = false;
            this.jCMA_EMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jCMA_EMPLOYEEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.jCMA_EMPLOYEEDataGridView.DataSource = this.jCMA_EMPLOYEEBindingSource;
            this.jCMA_EMPLOYEEDataGridView.Location = new System.Drawing.Point(0, 0);
            this.jCMA_EMPLOYEEDataGridView.Name = "jCMA_EMPLOYEEDataGridView";
            this.jCMA_EMPLOYEEDataGridView.Size = new System.Drawing.Size(1078, 403);
            this.jCMA_EMPLOYEEDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EMP_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "EMP_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PHONE";
            this.dataGridViewTextBoxColumn8.HeaderText = "PHONE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ADDRESS";
            this.dataGridViewTextBoxColumn9.HeaderText = "ADDRESS";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FARM_NAME";
            this.dataGridViewTextBoxColumn10.HeaderText = "FARM_NAME";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "S_DATE";
            this.dataGridViewTextBoxColumn11.HeaderText = "S_DATE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "E_DATE";
            this.dataGridViewTextBoxColumn12.HeaderText = "E_DATE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "JCMA_FARM";
            this.dataGridViewTextBoxColumn13.HeaderText = "JCMA_FARM";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MainWindowMenu);
            this.MainMenuStrip = this.MainWindowMenu;
            this.Name = "MainWindow";
            this.Text = "Orchard DB";
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FIELDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FARMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_FIELDSDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MainWindowMenu.ResumeLayout(false);
            this.MainWindowMenu.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabFarm.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_EMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCMA_EMPLOYEEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip MainWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip FieldsMenuStrip;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabFarm;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView jCMA_EMPLOYEEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource jCMA_EMPLOYEEBindingSource;
    }
}

