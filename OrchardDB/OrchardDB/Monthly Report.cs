using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace OrchardDB
{
    public partial class Monthly_Report : Form
    {
        DateTime start, over;
        public Monthly_Report(DateTime begin,DateTime end)
        {
            InitializeComponent();
            start = begin;
            over = end;
            over.AddHours(23);
            over.AddMinutes(59);
            over.AddSeconds(59);
        }
        private ODBEntities testEntities = new ODBEntities();
        private void Monthly_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportData.JCMA_PICKS' table. You can move, or remove it, as needed.
            List<JCMA_PICKS> test = (from q in testEntities.JCMA_PICKS where q.P_DATE >= @start && q.P_DATE <= @over select q).ToList();
            JCMA_PICKSBindingSource.DataSource = test;
            ReportDataSource picks = new ReportDataSource("Picks", JCMA_PICKSBindingSource);
            MonthlyReportForm.LocalReport.DataSources.Add(picks);
            this.MonthlyReportForm.RefreshReport();
        }
    }
}
