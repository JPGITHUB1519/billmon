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

namespace presentation.Reports
{
    public partial class PReport : Form
    {
        public DataSet ds;
        public string report_name;

        public PReport()
        {
            InitializeComponent();
        }

        public PReport(string report_name, DataSet ds)
        {
            this.report_name = report_name;
            this.ds = ds;
            InitializeComponent();
        }

        private void PReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = this.report_name;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
