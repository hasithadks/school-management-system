using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class IncomeExpensesReport : UserControl
    {
        IEReportPrint IER = new IEReportPrint();
        ExpensesImpl ExImpl = new ExpensesImpl();
        IncomeImpl InImpl = new IncomeImpl();
        cIncomeExpensesReport IEReport = new cIncomeExpensesReport();


        private static IncomeExpensesReport _IncomeExpensesReportInstance;
        public static IncomeExpensesReport IncomeExpensesReportInstance
        {
            get
            {
                if (_IncomeExpensesReportInstance == null)
                    _IncomeExpensesReportInstance = new IncomeExpensesReport();
                return _IncomeExpensesReportInstance;

            }
        }
 
        public IncomeExpensesReport()
        {
            InitializeComponent();
        }

        public void ReadRecode()
        {
            ExpensesDataGrid.DataSource = null;
            ExImpl.GetParticularExpensesPaymentRecode(IEReport);
            ExpensesDataGrid.DataSource = ExImpl.Dt;
            IncomeDataGrid.DataSource = InImpl.Dt;
        }


        public void GetExpensesTotal()
        {

            int sum = 0;
            for (int i = 0; i < ExpensesDataGrid.Rows.Count; i++)
            {
                sum += Convert.ToInt32(ExpensesDataGrid.Rows[i].Cells[2].Value);
            }
            try
            {
                double tot = 0.0;
                for (int i = 0; i <= ExpensesDataGrid.RowCount - 1; i++)
                {
                    tot += Convert.ToDouble(ExpensesDataGrid.Rows[i].Cells[2].Value);
                }

                if (tot == 0)
                {

                }
                txtTotalExpenses.Text = tot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void GetIncomeTotal()
        {

            int sum = 0;
            for (int i = 0; i < IncomeDataGrid.Rows.Count; i++)
            {
                sum += Convert.ToInt32(IncomeDataGrid.Rows[i].Cells[2].Value);
            }
            try
            {
                double tot = 0.0;
                for (int i = 0; i <= IncomeDataGrid.RowCount - 1; i++)
                {
                    tot += Convert.ToDouble(IncomeDataGrid.Rows[i].Cells[2].Value);
                }

                if (tot == 0)
                {

                }
                txtTotalIncome.Text = tot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            IEReport.month = Convert.ToInt32(dropPayMonth.Text);
            IEReport.year = Convert.ToInt32(dropPayYear.Text);

            ExImpl.GetParticularExpensesPaymentRecode(IEReport);
            InImpl.GetParticularIncomePaymentRecode(IEReport);
            

            ReadRecode();
            GetExpensesTotal();
            GetIncomeTotal();

            int month = Convert.ToInt32(dropPayMonth.Text);
            labelTitle.Text = "Income Expenses Overview Report";

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                labeldate.Text = dropPayYear.Text + "/0" + (month - 1) + "/01 to " + dropPayYear.Text + "/" + dropPayMonth.Text + "/31";
            else if (month == 2)
                labeldate.Text = dropPayYear.Text + "/0" + (month - 1) + "/01 to " + dropPayYear.Text + "/" + dropPayMonth.Text + "/28";
            else
                labeldate.Text = dropPayYear.Text + "/0" + (month - 1) + "/01 to " + dropPayYear.Text + "/" + dropPayMonth.Text + "/30";
        }

        private void btnReportPrint_Click(object sender, EventArgs e)
        {
            IEReport.month = Convert.ToInt32(dropPayMonth.Text);
            IEReport.year = Convert.ToInt32(dropPayYear.Text);
            IEReport.expensesTotal = Convert.ToInt32(txtTotalExpenses.Text);
            IEReport.incomeTotal = Convert.ToInt32(txtTotalIncome.Text);
            
            
            IER.IEReport(IEReport);
            IER.ShowDialog();
        }
    }
}
