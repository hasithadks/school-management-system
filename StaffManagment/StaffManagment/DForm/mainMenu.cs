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
using WindowsFormsApp2;
using examMarks;
using Eventmanage;
using TimeTableManagement;

namespace SchoolManagementSystem
{
    public partial class mainMenu : Form
    {

        private static mainMenu maintm;

        public static mainMenu maintt
        {
            get
            {
                if (maintm == null)

                    maintm = new mainMenu();

                return maintm;
            }

        }


        public mainMenu()
        {
            Thread lodingtrd = new Thread(new ThreadStart(lodingform));
            lodingtrd.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            lodingtrd.Abort();
        }



        private void lodingform()
        {
            Application.Run(new loding());
        }
        private void imgAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance att = new Attendance();
            att.Show();
        }

        private void imgPaymentM_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHomePage php = new PaymentHomePage();
            php.Show();
        }

        private void imgPaymentM_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHomePage php = new PaymentHomePage();
            php.Show();
        }

        private void imgAttendance_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
            Attendance att = new Attendance();
            att.Show();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffManagment.Form1 sf = new StaffManagment.Form1();
              sf.Show();
            //   var form2 = Form1.StaffFrom2;
            // this.Closed += (s, args) => this.Close();
            //  form2.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void imgInventory_Click(object sender, EventArgs e)
        {
            WindowsFormsApp2.Form1 inventory = new WindowsFormsApp2.Form1();
            inventory.Show();
        }

        private void imgExamMarks_Click(object sender, EventArgs e)
        {
            examMarks.Teacher teacher = new examMarks.Teacher();
            teacher.Show();
        }

        private void imgEventM_Click(object sender, EventArgs e)
        {
            Eventmanage.eventmanage  events = new Eventmanage.eventmanage();
            events.Show();
        }

        private void bunifuLabel15_Click(object sender, EventArgs e)
        {

        }

        private void imgTimeTableM_Click(object sender, EventArgs e)
        {
            TimeTableManagement.TimeTableHomePage time = new TimeTableManagement.TimeTableHomePage();
            time.Show();
        }
    }
}
