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

        private void Add_Farm_Button_Click(object sender, EventArgs e)
        {
            AddNewForm2 addFarmForm = new AddNewForm2();
            addFarmForm.Show();
        }

        private void addFarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFarmForm addFarmForm = new AddFarmForm();
            addFarmForm.Show();
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
            }
        }

        private void FieldPicksViewMenuItem_Click(object sender, EventArgs e)
        {
            jCMA_FIELDSDataGridView.Columns.Clear();
            jCMA_FIELDSDataGridView.AutoGenerateColumns = true;
            _contextEntities.JCMA_PICKS.Load();
            jCMA_FIELDSDataGridView.DataSource = jCMA_PICKSBindingSource;
            jCMA_FIELDSDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jCMA_FIELDSDataGridView.Columns[5].Visible = false;
            jCMA_FIELDSDataGridView.Columns[6].Visible = false;
            jCMA_FIELDSDataGridView.Columns[7].Visible = false;
            jCMA_FIELDSDataGridView.Refresh();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //int a = _contextEntities.SaveChanges();
            //MessageBox.Show(string.Format("{0} test", a));
            //_contextEntities.JCMA_FIELDS.Load();
            //jCMA_FIELDSDataGridView.Refresh();

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
       
           
    }
}
