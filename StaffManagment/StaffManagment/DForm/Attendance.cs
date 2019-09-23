using StaffManagment;
using StaffManagment.Messeges;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Attendance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        IncomeUC InUC = IncomeUC.IncomePaymentInstance;

        DateTime date = DateTime.Now;
        string DBAttendanceID;
        string DBUserID;
        string DBSwipeInTime;
        string DBSwipeOutTime;
        string DBAttendDate;


        string AttendDate;
        string AttendTime;


        public Attendance()
        {
            InitializeComponent();
            
        }


        private void AttendanceTimer_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString("HH:mm");
            LabelSecond.Text = DateTime.Now.ToString("ss");
            LabelDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            LabelDay.Text = DateTime.Now.ToString("dddd");

            AttendTime = DateTime.Now.ToString("HH:mm:ss");
            AttendDate = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
        public void ResetVariables()
        {
             DBAttendanceID = null;
             DBUserID = null;
             DBSwipeInTime = null;
             DBSwipeOutTime = null;
             DBAttendDate = null;
  
             AttendDate = null;
             AttendTime = null;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            AttendanceTimer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GetDate();

            if(DBUserID == null)
            {
                SqlCommand cmd2 = new SqlCommand("INSERT INTO StaffAttendance1 VALUES(@IDNumber, @AttendDate, @SwipeInTime, null) ", con);
                cmd2.CommandType = CommandType.Text;

                cmd2.Parameters.AddWithValue("@IDNumber", txtUserId.Text);
                cmd2.Parameters.AddWithValue("@AttendDate", AttendDate);
                cmd2.Parameters.AddWithValue("@SwipeInTime", AttendTime);

                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                InUC.Hide();
                SuccessfullMessageBox.ShowDialog("Attendance Insert Successfully", "Successfully Inserted");
                InUC.Show();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("UPDATE StaffAttendance1 SET swipeOutTime = @SwipeOutTime WHERE userID = @IDNumber AND date = @AttendDate", con);

            cmd3.Parameters.AddWithValue("@IDNumber", txtUserId.Text);
            cmd3.Parameters.AddWithValue("@AttendDate", AttendDate);
            cmd3.Parameters.AddWithValue("@SwipeOutTime", AttendTime);
            con.Open();
            cmd3.ExecuteNonQuery();
            con.Close();
        }

        public void GetDate() {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM StaffAttendance1 WHERE userID = @IDNumber AND date = @AttendDate ", con);
            cmd1.Parameters.AddWithValue("@IDNumber", txtUserId.Text);
            cmd1.Parameters.AddWithValue("@AttendDate", AttendDate);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd1.ExecuteReader();

                while (sdr.Read())
                {
                    DBAttendanceID = sdr.GetValue(0).ToString();
                    DBUserID = sdr.GetValue(1).ToString();
                    DBAttendDate = sdr.GetValue(2).ToString();
                    DBSwipeInTime = Convert.ToString(sdr.GetValue(3).ToString());
                    DBSwipeOutTime = sdr.GetValue(4).ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
