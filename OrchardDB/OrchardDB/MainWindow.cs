using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace OrchardDB
{
    public partial class MainWindow : Form
    {
        //The following variable will be used to send it to the field report. Currently its default is 3
        private int field_no = 3;

        private int empId;
        private DateTime _sDate = DateTime.Now.Date - new TimeSpan(7, 0, 0, 0);
        private DateTime _eDate = DateTime.Now.Date;
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
            _contextEntities.JCMA_PICKS.Load();
            // set the binding source to the binding list of JCMA_FARM
            this.jCMA_FARMBindingSource.DataSource = _contextEntities.JCMA_FARM.Local.ToBindingList();
            StartDatePicker.Value = _sDate;
            EndDatePicker.Value = _eDate;
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
            jCMA_FIELDSDataGridView.DataSource =
                (from p in _contextEntities.JCMA_PICKS
                 where
                     p.P_DATE >= StartDatePicker.Value.Date && p.P_DATE <= EndDatePicker.Value.Date &&
                     p.FIELD_ID == field_no
                 select p
                ).ToList();
            //jCMA_FIELDSDataGridView.DataSource = picksListSource.ToList();
            if (jCMA_FIELDSDataGridView.DataSource == null)
            {
                jCMA_FIELDSDataGridView.DataSource = jCMA_PICKSBindingSource;
            }
            if (jCMA_FIELDSDataGridView.ColumnCount != 0)
            {
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
            }
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
            AboutBox aboutform = new AboutBox();
            aboutform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewReportOnThisEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewer view = new ReportViewer(StartDatePicker.Value.Date, EndDatePicker.Value.Date);
            view.ShowDialog();
        }

        private void goBackToFieldsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jCMA_FIELDSDataGridView.Columns.Clear();
            jCMA_FIELDSDataGridView.AutoGenerateColumns = true;
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
                //This will get us the emp Id just the same exact way the other one gets us our field id.
                Int32.TryParse(c.OwningRow.Cells[0].Value.ToString(), out empId);
            }
        }

        private void viewThisEmployeePicksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jCMA_EMPLOYEEDataGridView.Columns.Clear();
            jCMA_EMPLOYEEDataGridView.AutoGenerateColumns = true;
            _contextEntities.JCMA_PICKS.Load();
            jCMA_EMPLOYEEDataGridView.DataSource =
                (from p in _contextEntities.JCMA_PICKS
                 where
                 p.P_DATE >= StartDatePicker.Value.Date && p.P_DATE <= EndDatePicker.Value.Date &&
                 p.EMP_ID == empId
                 select p
                 ).ToList();
            //jCMA_EMPLOYEEDataGridView.DataSource = empPickListSource.ToList();
            if (jCMA_EMPLOYEEDataGridView.DataSource == null)
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
            FieldReport Field = new FieldReport(field_no, StartDatePicker.Value.Date, EndDatePicker.Value.Date);
            Field.ShowDialog();
        }

        private void viewEmployeePerformanceOnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime start, end;
            start = StartDatePicker.Value;
            end = EndDatePicker.Value;
            end=end.AddHours(23);
            end=end.AddMinutes(59);
            end=end.AddSeconds(59);
            Employee_Performance Emp = new Employee_Performance(empId, start, end);
            Emp.ShowDialog();
        }

        private void RefreshedPicks()
        {
            if (goBackToFieldsListToolStripMenuItem.Enabled && Int32.TryParse(fIELD_IDComboBox.Text, out field_no))
            {
                jCMA_FIELDSDataGridView.DataSource =
                    (from p in _contextEntities.JCMA_PICKS
                     where
                         p.P_DATE >= StartDatePicker.Value.Date && p.P_DATE <= EndDatePicker.Value.Date &&
                         p.FIELD_ID == field_no
                     select p
                    ).ToList();
                jCMA_FIELDSDataGridView.Refresh();
            }
            else if (goBackToEmployeeListToolStripMenuItem.Enabled)
            {
                jCMA_EMPLOYEEDataGridView.DataSource =
                   (from p in _contextEntities.JCMA_PICKS
                    where
                        p.P_DATE >= StartDatePicker.Value.Date && p.P_DATE <= EndDatePicker.Value.Date &&
                        p.EMP_ID == empId
                    select p
                       ).ToList();
                jCMA_EMPLOYEEDataGridView.Refresh();
            }
        }

        private void fIELD_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshedPicks();
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshedPicks();
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshedPicks();
        }
    }
}