using Microsoft.Reporting.WinForms;
using StaffManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class IEReportPrint : Form
    {
        public string IEReportTitle;
        public string IEReportDate;
        public int IEReportMonth;
        public int IEReportYear;

        public int IEReportIncomeTotal;
        public int IEReportExpensesTotal;

        public IEReportPrint()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(336,63);
        }
        public void IEReport(cIncomeExpensesReport report)
        {
            IEReportYear = report.year;
            IEReportMonth = report.month;
            IEReportIncomeTotal = report.incomeTotal;
            IEReportExpensesTotal = report.expensesTotal;
        }

        private void btnReportMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReportClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void IEReportPrint_Load(object sender, EventArgs e)
        {
            ExpensesData ExData = new ExpensesData();
            IncomeData InData = new IncomeData();
            string cs = @"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter sql1 = new SqlDataAdapter("SELECT expensesUnitName, expensesType, expensesAmount FROM expensesPayment WHERE YEAR (expensesDate) =" + IEReportYear + "and MONTH (expensesDate) =" + IEReportMonth, cn);
            SqlDataAdapter sql2 = new SqlDataAdapter("SELECT incomeUnitName, incomeType, incomeAmount FROM incomePayment WHERE YEAR (incomeDate) =" + IEReportYear + "and MONTH (incomeDate) =" + IEReportMonth, cn);

            sql1.Fill(ExData, ExData.Tables[0].TableName);
            sql2.Fill(InData, InData.Tables[0].TableName);

            ReportDataSource rds1 = new ReportDataSource("Expenses", ExData.Tables[0]);
            ReportDataSource rds2 = new ReportDataSource("Income", InData.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.Refresh();

           
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.Refresh();


            this.reportViewer1.RefreshReport();

            IEReportTitle = "Income Expenses Overview Report";

            if (IEReportMonth == 1 || IEReportMonth == 3 || IEReportMonth == 5 || IEReportMonth == 7 || IEReportMonth == 8 || IEReportMonth == 10 || IEReportMonth == 12)
                IEReportDate = IEReportYear + "/0" + (IEReportMonth - 1) + "/01 to " + IEReportYear + "/" + IEReportMonth + "/31";
            else if (IEReportMonth == 2)
                IEReportDate = IEReportYear + "/0" + (IEReportMonth - 1) + "/01 to " + IEReportYear + "/" + IEReportMonth + "/28";
            else
                IEReportDate = IEReportYear + "/0" + (IEReportMonth - 1) + "/01 to " + IEReportYear + "/" + IEReportMonth + "/30";

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("ReportTotalExpenses", Convert.ToString(IEReportExpensesTotal)),
                new Microsoft.Reporting.WinForms.ReportParameter("ReportTotalIncome", Convert.ToString(IEReportIncomeTotal)),
                new Microsoft.Reporting.WinForms.ReportParameter("ReportDate", IEReportDate),
                new Microsoft.Reporting.WinForms.ReportParameter("ReportTitle", IEReportTitle)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
