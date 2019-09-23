using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class cIncomeExpensesReport
    {
        private int Year;
        private int Month;

        private int ExpensesTotal;
        private int IncomeTotal;

        public int expensesTotal
        {
             get { return this.ExpensesTotal; }
             set { ExpensesTotal = value; }
        }

        public int incomeTotal
        {
            get { return this.IncomeTotal; }
            set { IncomeTotal = value; }
        }

        public int year
        {
            get { return this.Year; }
            set { Year = value; }
        }

        public int month
        {
            get { return this.Month; }
            set { Month = value; }
        }
    }
}
