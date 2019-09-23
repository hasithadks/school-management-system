using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagment
{
    class staff
    {

        private string fName;
        private string Nic;
        private string lName;
        private string Title;
        private string Gender;
        private string Tpno;
        private string Email;
        private string address1;
        private string address2;
        private string address3;
        private string Qulification;
        private string AType;
        private string Password;
        private string sDate;
        private string Image;
        private string imagelocation;

        public staff() { }
        public staff(String fname, String nic, String lname, String title, String gender, String tno, String email, String add1, String add2, String add3, String qlf, String atype, String psw, String sdate , String img)
        {
            this.fName = fname;
            this.Nic = nic;
            this.lName = lname;
            this.Title = title;
            this.Gender = gender;
            this.Tpno = tno;
            this.Email = email;
            this.address1 = add1;
            this.address2 = add2;
            this.address3 = add3;
            this.Qulification = qlf;
            this.AType = atype;
            this.Password = psw;
            this.sDate = sdate;
            this.Image = img;
        }

        public String FirstName
        {

            get { return fName; }
            set { fName = value; }
        }
        public String LastName
        {

            get { return lName; }
            set { lName = value; }
        }
        public String NIC
        {

            get { return Nic; }
            set { Nic = value; }
        }
        public String TITLE
        {

            get { return Title; }
            set { Title = value; }
        }
        public String GENDER
        {

            get { return Gender; }
            set { Gender = value; }
        }
        public String TPNO
        {

            get { return Tpno; }
            set { Tpno = value; }
        }
        public String EMAIL
        {

            get { return Email; }
            set { Email = value; }
        }
        public String ADDRESS1
        {

            get { return address1; }
            set { address1 = value; }
        }
        public String ADDRESS2
        {

            get { return address2; }
            set { address2 = value; }
        }
        public String ADDRESS3
        {

            get { return address3; }
            set { address3 = value; }
        }
        public String QUALIFICATION
        {

            get { return Qulification; }
            set { Qulification = value; }
        }
        public String ATYPE
        {

            get { return AType; }
            set { AType = value; }
        }
        public String PSW
        {

            get { return Password; }
            set { Password = value; }
        }
        public String SDATE
        {

            get { return sDate; }
            set { sDate = value; }
        }
        public String IMG
        {

            get { return Image; }
            set { Image = value; }
        }



    }
}
