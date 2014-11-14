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
            _contextEntities = new ODBEntities();
            _contextEntities.JCMA_FARM.Load();
            this.jCMA_FARMBindingSource.DataSource = _contextEntities.JCMA_FARM.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._contextEntities.Dispose();
        }

        private void fARM_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void jCMA_FIELDSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Farm_Button_Click(object sender, EventArgs e)
        {
            AddFarmForm addFarmForm = new AddFarmForm();
            addFarmForm.Show();
        }

        private void addFarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFarmForm addFarmForm = new AddFarmForm();
            addFarmForm.Show();
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
