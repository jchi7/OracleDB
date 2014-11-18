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
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        private ODBEntities testEntities = new ODBEntities();
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            testEntities = new ODBEntities();
            List<JCMA_PICKS> test = (from q in testEntities.JCMA_PICKS where q.P_DATE >= new DateTime(2014, 01, 01) && q.P_DATE <= new DateTime(2014, 12, 26) &&
                                         q.EMP_ID == 1 select q).ToList();
            jCMA_PICKSBindingSource.DataSource = test;
            ReportDataSource picks = new ReportDataSource("Picks", jCMA_PICKSBindingSource);
            reportViewer1.LocalReport.DataSources.Add(picks);
            this.reportViewer1.RefreshReport();
        }
    }
}
