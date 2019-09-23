using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class PayrolPrintlReport : Form
    {
        string EndDate;
        string StartDate;
        int PerDay;
        int WorkingDays;
        string TotalSalary;

        string Gender;
        string NIC;
        string Name;

        public PayrolPrintlReport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(336,63);
        }

        public void PayRollReport(cPayrollReport report) {
            PerDay = report.perday;
            TotalSalary = report.totalSalary;
            WorkingDays = report.workingDays;
            NIC = report.nIC;
            Name = report.name;
            Gender = report.gender;
        }

        private void PayrolPrintlReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("PerDay", Convert.ToString(PerDay)),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalSalary", Convert.ToString(TotalSalary)),
                new Microsoft.Reporting.WinForms.ReportParameter("WorkingDays", Convert.ToString(WorkingDays)),

                new Microsoft.Reporting.WinForms.ReportParameter("EmployeName", Convert.ToString(Name)),
                new Microsoft.Reporting.WinForms.ReportParameter("NICNumber", Convert.ToString(NIC)),
                new Microsoft.Reporting.WinForms.ReportParameter("Gender", Convert.ToString(Gender)),
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        private void btnReportClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {

        }
    }
}
