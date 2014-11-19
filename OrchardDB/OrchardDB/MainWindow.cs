using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OrchardDB
{
    public partial class MainWindow : Form
    {
        //The following variable will be used to send it to the field report. Currently its default is 3
        int field_no = 3;
        private ODBEntities _contextEntities;
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // create a new context of the entity Framework
            // context allow the program to interact with the database
            _contextEntities = new ODBEntities();
            // Load the data from the database into the context
            _contextEntities.JCMA_FARM.Load();
            _contextEntities.JCMA_FIELDS.Load();
            // set the binding source to the binding list of JCMA_FARM
            this.jCMA_FARMBindingSource.DataSource = _contextEntities.JCMA_FARM.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            // Dispose the context entity
            this._contextEntities.Dispose();
        }

        /// <summary>
        /// This event load the add farm form.  This form allows multiple farms insertation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Farm_Button_Click(object sender, EventArgs e)
        {
            AddNewForm2 addFarmForm = new AddNewForm2();
            addFarmForm.Show();
        }

        /// <summary>
        /// This Event load the add Farm form.  This is the single farm add form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addFarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFarmForm addFarmForm = new AddFarmForm();
            addFarmForm.ShowDialog();
            _contextEntities.JCMA_FARM.Load();
            //this.jCMA_FARMBindingSource.DataSource = _contextEntities.JCMA_FARM.Local.ToBindingList();
        }

        private void jCMA_FIELDSDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
                //Cell[0] of any row clicked will be used as the field_no that way when we 
                // call the report we get the correct field_id....
                Int32.TryParse(c.OwningRow.Cells[0].Value.ToString(), out field_no);
            }
        }

        private void FieldPicksViewMenuItem_Click(object sender, EventArgs e)
        {
            jCMA_FIELDSDataGridView.Columns.Clear();
            jCMA_FIELDSDataGridView.AutoGenerateColumns = true;
            _contextEntities.JCMA_PICKS.Load();
            jCMA_FIELDSDataGridView.DataSource = jCMA_PICKSBindingSource;
            jCMA_FIELDSDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[0].ReadOnly = false;
            jCMA_FIELDSDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[5].Visible = false;
            jCMA_FIELDSDataGridView.Columns[6].Visible = false;
            jCMA_FIELDSDataGridView.Columns[7].Visible = false;
            jCMA_FIELDSDataGridView.Refresh();
            FieldPicksViewMenuItem.Enabled = false;
            FieldPicksViewMenuItem.Visible = false;
            goBackToFieldsListToolStripMenuItem.Enabled = true;
            goBackToFieldsListToolStripMenuItem.Visible = true;
        }

        private void Test_Click(object sender, EventArgs e)
        {
            int a = _contextEntities.SaveChanges();
            MessageBox.Show(string.Format("{0} test", a));
            _contextEntities.JCMA_FIELDS.Load();
            jCMA_FIELDSDataGridView.Refresh();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutform= new AboutBox();
            aboutform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewReportOnThisEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewer view = new ReportViewer();
            view.ShowDialog();
        }

        private void goBackToFieldsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jCMA_FIELDSDataGridView.Columns.Clear();
            jCMA_FIELDSDataGridView.AutoGenerateColumns = true;
            _contextEntities.JCMA_FIELDS.Load();
            jCMA_FIELDSDataGridView.DataSource = jCMA_FIELDSBindingSource;
            jCMA_FIELDSDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[0].ReadOnly = true;
            jCMA_FIELDSDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[3].Visible = false;
            jCMA_FIELDSDataGridView.Columns[4].Visible = false;
            FieldPicksViewMenuItem.Enabled = true;
            FieldPicksViewMenuItem.Visible = true;
            goBackToFieldsListToolStripMenuItem.Enabled = false;
            goBackToFieldsListToolStripMenuItem.Visible = false;
        }

        private void jCMA_EMPLOYEEDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
                
            }
        }

        private void viewThisEmployeePicksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jCMA_EMPLOYEEDataGridView.Columns.Clear();
            jCMA_EMPLOYEEDataGridView.AutoGenerateColumns = true;
            _contextEntities.JCMA_PICKS.Where(p=>p.P_DATE >= StartDatePicker.Value).Load();
            
            jCMA_EMPLOYEEDataGridView.DataSource = jCMA_EMPPICKSBindingSource;
            jCMA_EMPLOYEEDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[0].ReadOnly = true;
            jCMA_EMPLOYEEDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[1].ReadOnly = true;
            jCMA_EMPLOYEEDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[2].ReadOnly = true;
            jCMA_EMPLOYEEDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[5].Visible = false;
            jCMA_EMPLOYEEDataGridView.Columns[6].Visible = false;
            jCMA_EMPLOYEEDataGridView.Columns[7].Visible = false;
            jCMA_EMPLOYEEDataGridView.Refresh();
            goBackToEmployeeListToolStripMenuItem.Enabled = true;
            goBackToEmployeeListToolStripMenuItem.Visible = true;
            viewThisEmployeePicksToolStripMenuItem.Enabled = false;
            viewThisEmployeePicksToolStripMenuItem.Visible = false;
        }

        private void goBackToEmployeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jCMA_EMPLOYEEDataGridView.Columns.Clear();
            jCMA_EMPLOYEEDataGridView.AutoGenerateColumns = true;
            _contextEntities.JCMA_EMPLOYEE.Load();
            jCMA_EMPLOYEEDataGridView.DataSource = jCMA_EMPLOYEEBindingSource;
            jCMA_EMPLOYEEDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[0].ReadOnly = true;
            jCMA_EMPLOYEEDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[4].Visible = false;
            jCMA_EMPLOYEEDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_EMPLOYEEDataGridView.Columns[7].Visible = false;
            jCMA_EMPLOYEEDataGridView.Refresh();
            goBackToEmployeeListToolStripMenuItem.Enabled = false;
            goBackToEmployeeListToolStripMenuItem.Visible = false;
            viewThisEmployeePicksToolStripMenuItem.Enabled = true;
            viewThisEmployeePicksToolStripMenuItem.Visible = true;
        }

        private void viewReportOnThisFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FieldReport Field = new FieldReport(field_no);
            Field.ShowDialog();
        }
       
           
    }
}
