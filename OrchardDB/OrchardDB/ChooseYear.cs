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
    public partial class ChooseYear : Form
    {
        public ChooseYear()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void YearlyReportBtn_Click(object sender, EventArgs e)
        {
            DateTime YearArg1,YearArg2;
            try
            {
                YearArg1 = Convert.ToDateTime("1/1/" + Year.Text);
                YearArg2 = Convert.ToDateTime("12/31/" + Year.Text);
                YearArg2.AddHours(23);
                YearArg2.AddMinutes(59);
                YearArg2.AddSeconds(59);
                YearReport viewYearReport = new YearReport(YearArg1,YearArg2);
                viewYearReport.ShowDialog();
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid Format of year\n");
            }
            
        }
    }
}
