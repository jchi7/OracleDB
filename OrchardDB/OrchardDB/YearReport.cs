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
    public partial class YearReport : Form
    {
        DateTime BeginYear, EndYear;
        public YearReport(DateTime start_year,DateTime end_year)
        {
            InitializeComponent();
            BeginYear = start_year;
            EndYear = end_year;
        }
        private ODBEntities testEntities = new ODBEntities();
        private void YearReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportData.JCMA_PICKS' table. You can move, or remove it, as needed.
            //this.JCMA_PICKSTableAdapter.Fill(this.ReportData.JCMA_PICKS);
            List<JCMA_PICKS> test = (from q in testEntities.JCMA_PICKS where q.P_DATE >=@BeginYear && q.P_DATE <=@EndYear  select q).ToList();
            JCMA_PICKSBindingSource.DataSource = test;
            ReportDataSource picks = new ReportDataSource("Picks", JCMA_PICKSBindingSource);
            reportViewer1.LocalReport.DataSources.Add(picks);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
