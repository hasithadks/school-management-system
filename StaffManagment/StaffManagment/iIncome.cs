using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    interface iIncome
    {
        void InsertIncomeRecode(cIncome Income);
        void UpdateIncomeRecode(cIncome Income);
        void DeleteIncomeRecode(cIncome Income);
    }
}
