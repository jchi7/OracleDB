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
    public partial class Employee_Performance : Form
    {
        int empid;
        DateTime start, over;
        public Employee_Performance(int Id,DateTime begin,DateTime end)
        {
            InitializeComponent();
            empid = Id;
            start = begin;
            over = end;
        }
        private ODBEntities testEntities = new ODBEntities(); 
        private void Employee_Performance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportData.JCMA_PICKS' table. You can move, or remove it, as needed.
            //this.JCMA_PICKSTableAdapter.Fill(this.ReportData.JCMA_PICKS);
            testEntities = new ODBEntities();
            List<JCMA_PICKS> test = (from q in testEntities.JCMA_PICKS where q.P_DATE >= @start && q.P_DATE <= @over && q.EMP_ID==@empid  select q).ToList();
            JCMA_PICKSBindingSource.DataSource = test;
            ReportDataSource empPerformance = new ReportDataSource("Picks", JCMA_PICKSBindingSource);
            reportViewer1.LocalReport.DataSources.Add(empPerformance);
            this.reportViewer1.RefreshReport();
        }
    }
}
