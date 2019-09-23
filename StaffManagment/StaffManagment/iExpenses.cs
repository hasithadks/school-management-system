using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    interface iExpenses
    {
        void InsertExpensesRecode(cExpenses Expenses);
        void UpdateExpensesRecode(cExpenses Expenses);
        void DeleteExpensesRecode(cExpenses Expenses);
    }
}
