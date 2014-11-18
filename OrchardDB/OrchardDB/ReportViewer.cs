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
using Microsoft.Reporting.WinForms;

namespace OrchardDB
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private ODBEntities testEntities;
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            testEntities = new ODBEntities();
            List<JCMA_PICKS> test = (from q in testEntities.JCMA_PICKS select q).ToList();
            JCMA_PICKSBindingSource.DataSource = test;
            ReportDataSource picks =  new ReportDataSource("Picks", JCMA_PICKSBindingSource);
            reportViewer1.LocalReport.DataSources.Add(picks);
            this.reportViewer1.RefreshReport();
        }
    }
}
