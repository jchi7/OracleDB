﻿using System;
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
    public partial class FieldReport : Form
    {
        //Set these as global variable in order to use them in FieldReport_Load function.
        int field_id;
        DateTime begin, last;
        public FieldReport(int field_no,DateTime start,DateTime end)
        {
            InitializeComponent();
            field_id = field_no;
            begin = start;
            last = end;
        }
        private ODBEntities entity = new ODBEntities();
        private void FieldReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportData.JCMA_PICKS' table. You can move, or remove it, as needed.
            //this.JCMA_PICKSTableAdapter.Fill(this.ReportData.JCMA_PICKS);
            entity = new ODBEntities();
            List<JCMA_PICKS> field_info=(from q in entity.JCMA_PICKS where q.FIELD_ID==@field_id && q.P_DATE >= @begin && q.P_DATE <= @last select q).ToList();
            JCMA_PICKSBindingSource.DataSource=field_info;
            ReportDataSource field = new ReportDataSource();
            this.reportViewer1.RefreshReport();
        }
    }
}
