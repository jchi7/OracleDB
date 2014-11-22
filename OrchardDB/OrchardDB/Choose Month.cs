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
    public partial class Choose_Month : Form
    {
        string month;
        DateTime begin,end;
        public Choose_Month()
        {
            InitializeComponent();
        }

        private void MonthDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = MonthDropDown.Text ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ViewMonthReport_Click(object sender, EventArgs e)
        {
            try
            {
                begin = Convert.ToDateTime(month + "/1/" + MonthYearText.Text);
                end = Convert.ToDateTime(month + "/30/" + MonthYearText.Text);
                Monthly_Report Report = new Monthly_Report(begin, end);
                Report.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Check your Format for the Year value (YYYY)");
            }
        }

        private void MonthDropDown_TextChanged(object sender, EventArgs e)
        {
            MonthDropDown.Text = "";
        }
    }
}
