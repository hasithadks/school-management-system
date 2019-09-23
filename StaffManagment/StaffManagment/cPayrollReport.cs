using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class cPayrollReport
    {

        private int Perday;
        private int WorkingDays;
        private string TotalSalary;
        private string Name;
        private string NIC;
        private string Gender;


        public string name
        {
            get { return this.Name; }
            set { Name = value; }
        }
        public string nIC
        {
            get { return this.NIC; }
            set { NIC = value; }
        }

        public string gender
        {
            get { return this.Gender; }
            set { Gender = value; }
        }

        public int perday
        {
            get { return this.Perday; }
            set { Perday = value; }
        }

        public int workingDays
        {
            get { return this.WorkingDays; }
            set { WorkingDays = value; }
        }

        public string totalSalary
        {
            get { return this.TotalSalary; }
            set { TotalSalary = value; }
        }
    }
}
