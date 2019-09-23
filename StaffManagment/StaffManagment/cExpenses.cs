using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class cExpenses
    {
        public int ExpensesID;
        private string ExpensesUnitName;
        private string ExpensesType;
        private string ExpensesAmount;
        private string ExpensesDate;
        private string ExpensesDescription;

        public cExpenses() { }
        public cExpenses(string expensesUnitName, string expensesType, string expensesAmount, string expensesDate, string expensesDescription)
        {
            ExpensesUnitName = expensesUnitName;
            ExpensesType = expensesType;
            ExpensesAmount = expensesAmount;
            ExpensesDate = expensesDate;
            ExpensesDescription = expensesDescription;
        }


        public cExpenses(int expensesID, string expensesUnitName, string expensesType, string expensesAmount, string expensesDate, string expensesDescription)
        {
            ExpensesID = expensesID;
            ExpensesUnitName = expensesUnitName;
            ExpensesType = expensesType;
            ExpensesAmount = expensesAmount;
            ExpensesDate = expensesDate;
            ExpensesDescription = expensesDescription;
        }
        public int expensesID
        {
            set { ExpensesID = value; }
            get { return this.ExpensesID; }
        }

        public string expensesUnitName
        {
            set { ExpensesUnitName = value; }
            get { return this.ExpensesUnitName; }
        }

        public string expensesType
        {
            set { ExpensesType = value; }
            get { return this.ExpensesType; }
        }

        public string expensesAmount
        {
            set { ExpensesAmount = value; }
            get { return this.ExpensesAmount; }
        }

        public string expensesDate
        {
            set { ExpensesDate = value; }
            get { return this.ExpensesDate; }
        }

        public string expensesDescription
        {
            set { ExpensesDescription = value; }
            get { return this.ExpensesDescription; }
        }
    }
}
