using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace SchoolManagementSystem
{
    public partial class PayrollUC : UserControl
    {
        string StaffName;
        string StaffNIC;
        string StaffRegisterDate;
        string StaffAge;

        string UserId;
        int StartYear;
        int StartMonth;

        int EndYear;
        int EndMonth;

        int TotalDay;

        string StartDate;
        string EndDate;

        double Salary;

        cPayrollReport cpayrollreport = new cPayrollReport();

        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");

        private static PayrollUC _PayrollInstance;
        public static PayrollUC PayrollInstance
        {
            get
            {
                if (_PayrollInstance == null)
                    _PayrollInstance = new PayrollUC();
                return _PayrollInstance;

            }
        }

        public PayrollUC()
        {
            InitializeComponent();
        }
        public void value()
        {
            UserId = txtUserId.Text;
            StartYear = Convert.ToInt32(StartDropPayYear.Text);
            StartMonth = Convert.ToInt32(StartDropPayMonth.Text);

            EndYear = Convert.ToInt32(EndDropPayYear.Text);
            EndMonth = Convert.ToInt32(EndDropPayMonth.Text);

            startDate();
            endDate();
        }

        public void startDate() {
            StartDate = StartMonth + "/01/" + StartYear;   
        }
        public void endDate() {

            if (EndMonth == 1 || EndMonth == 3 || EndMonth == 5 || EndMonth == 7 || EndMonth == 8 || EndMonth == 10 || EndMonth == 12)
            {
                EndDate = EndMonth + "/01/" + EndYear;
                EndDate = EndMonth + "/31/" + EndYear;
            }

            else if (EndMonth == 2)
            {
                EndDate = EndMonth + "/01/" + EndYear;
                EndDate = EndMonth + "/28/" + EndYear;
            }
            else
            {
                EndDate = EndMonth + "/01/" + EndYear;
                EndDate = EndMonth + "/30/" + EndYear;
            }
            

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("SELECT count(attendanceID) FROM StaffAttendance1 WHERE date BETWEEN @StartDate AND @EndDate AND userID = @IDNumber", con);
            cmd3.Parameters.AddWithValue("@IDNumber", txtUserId.Text);
            cmd3.Parameters.AddWithValue("@StartDate", StartDate);
            cmd3.Parameters.AddWithValue("@EndDate", EndDate);


            con.Open();
            int i = Convert.ToInt32(cmd3.ExecuteScalar());

            txtNWH.Text = Convert.ToString(i);
            cmd3.ExecuteNonQuery();
            con.Close();
        }

        private void PayrollUC_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetDate();
            value();
            txtTimePeriod.Text = StartDate + " to " + EndDate;
            try
            {
                SqlCommand cmd3 = new SqlCommand("SELECT count(attendanceID) FROM StaffAttendance1 WHERE date BETWEEN @StartDate AND @EndDate AND userID = @IDNumber", con);
                cmd3.Parameters.AddWithValue("@IDNumber", txtUserId.Text);
                cmd3.Parameters.AddWithValue("@StartDate", StartDate);
                cmd3.Parameters.AddWithValue("@EndDate", EndDate);


                con.Open();
                TotalDay = Convert.ToInt32(cmd3.ExecuteScalar());

                txtNWH.Text = Convert.ToString(TotalDay);
                cmd3.ExecuteNonQuery();
                con.Close();

                txtTotalSalary.Text = Convert.ToString("Rs. " + TotalDay * Convert.ToInt32(txtPerDay.Text));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }


        }

        public void GetDate()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Staff_Mang_Table WHERE NIC = @NIC", con);
            cmd1.Parameters.AddWithValue("@NIC", txtUserId.Text);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd1.ExecuteReader();

                while (sdr.Read())
                {
                    StaffName = sdr.GetValue(2).ToString();
                    StaffNIC = sdr.GetValue(0).ToString();
                    StaffRegisterDate = sdr.GetValue(13).ToString();
                    StaffAge = Convert.ToString(sdr.GetValue(4).ToString());

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtStaffName.Text = StaffName;
            txtStaffStartDate.Text = StaffRegisterDate;
            txtStaffNIC.Text = StaffNIC;
            txtStaffGender.Text = StaffAge;

        }

        private void btnReportPrint_Click(object sender, EventArgs e)
        {
           // cpayrollreport.endDate = EndDate;
         //   cpayrollreport.startDate = StartDate;
            cpayrollreport.perday = Convert.ToInt32(txtPerDay.Text);
            cpayrollreport.workingDays = TotalDay;
            cpayrollreport.totalSalary = txtTotalSalary.Text;
            cpayrollreport.name = txtStaffName.Text;
            cpayrollreport.gender = txtStaffGender.Text;
            cpayrollreport.nIC = txtStaffNIC.Text;

            PayrolPrintlReport PRR = new PayrolPrintlReport();
            PRR.PayRollReport(cpayrollreport);
         //   cpayrollreport.endDate = EndDate;
         //    cpayrollreport.id = txtUserId.Text;
            PRR.ShowDialog();

        }
    }
}
