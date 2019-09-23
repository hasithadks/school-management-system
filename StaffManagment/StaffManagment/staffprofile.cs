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
using StaffManagment.Messeges;

namespace StaffManagment
{
    public partial class staffprofile : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;

        private static staffprofile StaffManagmentInstance_2;

        public static staffprofile StaffManagmentInstance_4
        {

            get
            {
                if (StaffManagmentInstance_2 == null)

                    StaffManagmentInstance_2 = new staffprofile();

                return StaffManagmentInstance_2;
            }

        }



        public staffprofile()
        {
            InitializeComponent();
        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {

            String getNIC = Login.setNIC;

            if (Login.setpassword == currentPassword_txt.Text)
            {

                if (newPassword_txt.Text == confirmPassword_txt.Text)
                {
                    con.Open();
                    cmd = new SqlCommand("update Staff_Mang_Table set password= '" + newPassword_txt.Text + "' where NIC = @getNIC", con);
                    cmd.Parameters.Add("@getNIC", SqlDbType.VarChar).Value = getNIC;
                    cmd.ExecuteNonQuery();
                    SuccessfullMessageBox.ShowDialog("Password Update Successfully !!!", "Confirmation Message");
                    con.Close();

                }
                else
                {
                    ErrorDialogBox.ShowDialog("Confirm Password Does't macth with new Password!!!", "New Password Invaild");
                    newPassword_txt.Text = "";
                    confirmPassword_txt.Text = "";
                }

            }
            else
            {
                ErrorDialogBox.ShowDialog("Current Password does not match.!!!", "Current Password Invaild");
            }



        }


        public void displayRequestLeave()
        {
            try
            {
                String getNIC = Login.setNIC;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT NIC as 'Staff_ID', type as 'Account_Type', reason as 'Reason', date as 'Leave_Date' from staff_Temp_Request_Leaves where NIC = @getNIC";
                cmd.Parameters.Add("@getNIC", SqlDbType.VarChar).Value = getNIC;
                
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewPendingLeaves.RowTemplate.Height = 50;
                dataGridViewPendingLeaves.AllowUserToAddRows = false;
                dataGridViewPendingLeaves.DataSource = dt;

                dataGridViewPendingLeaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }



        }


        public void displayCancletLeave()
        {
            try
            {
                String getNIC = Login.setNIC;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT NIC as 'Staff_ID', type as 'Account_Type', reason as 'Reason', date as 'Leave_Date' from staff_cancle_Leaves where NIC = @getNIC";
                cmd.Parameters.Add("@getNIC", SqlDbType.VarChar).Value = getNIC;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewPendingLeaves.RowTemplate.Height = 50;
                dataGridViewPendingLeaves.AllowUserToAddRows = false;
                dataGridViewPendingLeaves.DataSource = dt;

                dataGridViewPendingLeaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }



        }

        private void requestbtn_Click(object sender, EventArgs e)
        {
            displayRequestLeave();
        }

        private void canclebtn_Click(object sender, EventArgs e)
        {
            displayCancletLeave();
        }
    }
}
