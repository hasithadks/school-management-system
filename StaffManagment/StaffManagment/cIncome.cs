using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class cIncome
    {
        public int IncomeID;
        private string IncomeUnitName;
        private string IncomeType;
        private string IncomeAmount;
        private string IncomeDate;
        private string IncomeDescription;

        public cIncome() { }
        public cIncome(string incomeUnitName, string incomeType, string incomeAmount, string incomeDate, string incomeDescription)
        {
            IncomeUnitName = incomeUnitName;
            IncomeType = incomeType;
            IncomeAmount = incomeAmount;
            IncomeDate = incomeDate;
            IncomeDescription = incomeDescription;
        }


        public cIncome(int incomeID, string incomeUnitName, string incomeType, string incomeAmount, string incomeDate, string incomeDescription)
        {
            IncomeID = incomeID;
            IncomeUnitName = incomeUnitName;
            IncomeType = incomeType;
            IncomeAmount = incomeAmount;
            IncomeDate = incomeDate;
            IncomeDescription = incomeDescription;
        }
        public int incomeID
        {
            set { IncomeID = value; }
            get { return this.IncomeID; }
        }

        public string incomeUnitName
        {
            set { IncomeUnitName = value; }
            get { return this.IncomeUnitName; }
        }

        public string incomeType
        {
            set { IncomeType = value; }
            get { return this.IncomeType; }
        }

        public string incomeAmount
        {
            set { IncomeAmount = value; }
            get { return this.IncomeAmount; }
        }

        public string incomeDate
        {
            set { IncomeDate = value; }
            get { return this.IncomeDate; }
        }

        public string incomeDescription
        {
            set { IncomeDescription = value; }
            get { return this.IncomeDescription; }
        }
    }
}
