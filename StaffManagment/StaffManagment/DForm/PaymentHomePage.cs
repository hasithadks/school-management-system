using StaffManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class PaymentHomePage : Form
    {
        public PaymentHomePage()
        {
            InitializeComponent();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            btnExpenses.IdleFillColor = Color.FromArgb(47, 57, 72);
            btnPayroll.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnIncome.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnReport.IdleFillColor = Color.FromArgb(63, 67, 75);

            btnExpenses.IdleBorderColor = Color.FromArgb(47, 57, 72);
            btnPayroll.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnIncome.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnReport.IdleBorderColor = Color.FromArgb(63, 67, 75);

            if (!paymentMainPanel.Controls.Contains(ExpensesUC.ExpensesInstance))
            {
                paymentMainPanel.Controls.Add(ExpensesUC.ExpensesInstance);
                ExpensesUC.ExpensesInstance.BringToFront();
            }
            else
                ExpensesUC.ExpensesInstance.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnExpenses.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnPayroll.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnIncome.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnReport.IdleFillColor = Color.FromArgb(47, 57, 72);

            btnExpenses.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnPayroll.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnIncome.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnReport.IdleBorderColor = Color.FromArgb(47, 57, 72);

            if (!paymentMainPanel.Controls.Contains(IncomeExpensesReport.IncomeExpensesReportInstance))
            {
                paymentMainPanel.Controls.Add(IncomeExpensesReport.IncomeExpensesReportInstance);
                IncomeExpensesReport.IncomeExpensesReportInstance.BringToFront();
            }
            else
                IncomeExpensesReport.IncomeExpensesReportInstance.BringToFront();
        }
    

        private void btnIncome_Click(object sender, EventArgs e)
        {
            btnExpenses.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnPayroll.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnIncome.IdleFillColor = Color.FromArgb(47, 57, 72);
            btnReport.IdleFillColor = Color.FromArgb(63, 67, 75);


            btnExpenses.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnPayroll.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnIncome.IdleBorderColor = Color.FromArgb(47, 57, 72);
            btnReport.IdleBorderColor = Color.FromArgb(63, 67, 75);

            if (!paymentMainPanel.Controls.Contains(IncomeUC.IncomePaymentInstance))
            {
                paymentMainPanel.Controls.Add(IncomeUC.IncomePaymentInstance);
                IncomeUC.IncomePaymentInstance.BringToFront();
            }
            else
                IncomeUC.IncomePaymentInstance.BringToFront();
        }

        private void PaymentHomePage_Load(object sender, EventArgs e)
        {
            paymentMainPanel.Controls.Add(ExpensesUC.ExpensesInstance);

            btnExpenses.IdleFillColor = Color.FromArgb(47, 57, 72);
            btnExpenses.IdleBorderColor = Color.FromArgb(47, 57, 72);
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            btnExpenses.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnPayroll.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnIncome.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnReport.IdleFillColor = Color.FromArgb(63, 67, 75);
            btnPayroll.IdleFillColor = Color.FromArgb(47, 57, 72);

            btnExpenses.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnPayroll.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnIncome.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnReport.IdleBorderColor = Color.FromArgb(63, 67, 75);
            btnReport.IdleBorderColor = Color.FromArgb(47, 57, 72);

            if (!paymentMainPanel.Controls.Contains(PayrollUC.PayrollInstance))
            {
                paymentMainPanel.Controls.Add(PayrollUC.PayrollInstance);
                PayrollUC.PayrollInstance.BringToFront();
            }
            else
                PayrollUC.PayrollInstance.BringToFront();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu mMenu = new mainMenu();
            mMenu.Show();
        }

        private void paymentMainPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
