using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrchardDB
{
    public partial class AddFarmForm : Form
    {
        private ODBEntities _conEntities = new ODBEntities();
        public AddFarmForm()
        {
            InitializeComponent();
        }

        private void Save_Farm_Click(object sender, EventArgs e)
        {
            if (Farm_Name_TextBox.Text.Trim() != string.Empty)
            {
                try
                {
                    _conEntities.INSERT_FARM(Farm_Name_TextBox.Text.Trim(), Location_Textbox.Text.Trim(), Owner_Name_TextBox.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
                //_conEntities.SaveChanges();
                Close();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
