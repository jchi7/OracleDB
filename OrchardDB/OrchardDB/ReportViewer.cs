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
        private DateTime _sdate;
        private DateTime _edate;

        public ReportViewer()
        {
            InitializeComponent();
        }

        public ReportViewer(DateTime startDateTime, DateTime endDateTime)
        {
            InitializeComponent();
            _sdate = startDateTime;
            _edate = endDateTime + new TimeSpan(1,0,0,0);
        }

        private ODBEntities testEntities = new ODBEntities();
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            List<JCMA_PICKS> test = (from q in testEntities.JCMA_PICKS where q.P_DATE >= _sdate && q.P_DATE <= _edate select q).ToList();
            jCMA_PICKSBindingSource.DataSource = test;
            ReportDataSource picks = new ReportDataSource("Picks", jCMA_PICKSBindingSource);
            reportViewer1.LocalReport.DataSources.Add(picks);
            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// This event handler will be called every time we click the Update Report button, and will read the integer in the textbox and show the 
        /// information on the employee related to that id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateReport_Click(object sender, EventArgs e)
        {
            int Emp_Id;
            Int32.TryParse(Search.Text,out Emp_Id);
            this.reportViewer1.Clear();
            testEntities = new ODBEntities();
            //TO DO: how should I handle the P_dates? Show all of them? or insert date boxes??
            List<JCMA_PICKS> update = (from q in testEntities.JCMA_PICKS
                                       where q.P_DATE >= _sdate && q.P_DATE <= _edate &&
                                           q.EMP_ID == @Emp_Id select q).ToList();
            jCMA_PICKSBindingSource.DataSource = update;
            ReportDataSource newpicks = new ReportDataSource("Picks", jCMA_PICKSBindingSource);
            reportViewer1.LocalReport.DataSources.Add(newpicks);
            this.reportViewer1.RefreshReport();
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UpdateReport_Click(sender, e);
        }
    }
}
