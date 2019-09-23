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
using System.IO;

namespace StaffManagment
{


    public partial class principle_profile : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        
        int casual = 0;
        int medical = 0;
        int halfday = 0;
        int shortleave = 0;
        int year = 0;
         
        public static int sid = 0;

        //int tempHalf = 0;


        private static principle_profile pricipleInstance;

        public static principle_profile pricipleInstance_11
        {
            get
            {
                if (pricipleInstance == null)

                    pricipleInstance = new principle_profile();

                return pricipleInstance;
            }

        }

        public principle_profile()
        {
            InitializeComponent();
            displayleaveReuest();
        }

        private void chng_password_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }


        public void displayleaveReuest()
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT sid as 'SID', NIC as 'NIC', type as 'Account_Type', reason as 'Reason', date as 'Leave_Date' from staff_Temp_Request_Leaves";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                pendingLeaveDataGrid.RowTemplate.Height = 50;
                pendingLeaveDataGrid.AllowUserToAddRows = false;
                pendingLeaveDataGrid.DataSource = dt;

                pendingLeaveDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }




        }

        private void pendingLeaveDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sid = (int)pendingLeaveDataGrid.SelectedRows[0].Cells[0].Value;
            staffnicLabel.Text = pendingLeaveDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            typeLable.Text = pendingLeaveDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            reasonLable.Text = pendingLeaveDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            dateLable.Text = pendingLeaveDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            SqlCommand command = new SqlCommand("Select * from Staff_Mang_Table where NIC = @getNIC2", con);
            command.Parameters.Add("@getNIC2", SqlDbType.VarChar).Value = staffnicLabel.Text;
            con.Open();

            String fname = "";
            String lname = "";
            Byte[] img = null;



            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                fname = reader[2].ToString();
                lname = reader[3].ToString();
                img = (Byte[])reader[14];



            }

            nameLable.Text = fname + " " + lname;
            MemoryStream ms = new MemoryStream(img);
            
            staffpicPictureBox.Image = Image.FromStream(ms);
            con.Close();


        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {


            if (staffnicLabel.Text == null || typeLable.Text == null)
            {
                ErrorDialogBox.ShowDialog("Please double click one rquest from table First", "Invaild Data");
            }
            else
            {

                String approveby = Login.setNIC;
                con.Open();
                cmd = new SqlCommand("insert into staff_Approve_Leaves values('" + staffnicLabel.Text + "', '" + typeLable.Text + "', '" + reasonLable.Text + "', '" + dateLable.Text + "', @approveby)", con);

                cmd.Parameters.Add("@approveby", SqlDbType.VarChar).Value = approveby;

                cmd.ExecuteNonQuery();
                SuccessfullMessageBox.ShowDialog("Leave Approved", "Confirmation Message");

                con.Close();


                con.Open();
                cmd = new SqlCommand("Delete from staff_Temp_Request_Leaves where sid = @sid", con);
                cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
                cmd.ExecuteNonQuery();
                con.Close();


                displayleaveReuest();

                getLeaves();



                if (typeLable.Text == "Casual_Leave")
                {

                    casual = casual - 1;
                    con.Open();
                    cmd = new SqlCommand("update staff_Leaves set Casual_Leave = @Casual_Leave where NIC = '" + staffnicLabel.Text + "' ", con);
                    cmd.Parameters.Add("@Casual_Leave", SqlDbType.Int).Value = (int)casual;

                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                else if (typeLable.Text == "Medical_Leave")
                {
                    medical = medical - 1;
                    con.Open();
                    cmd = new SqlCommand("update staff_Leaves set Medical_Leave = @Medical_Leave where NIC = '" + staffnicLabel.Text + "' ", con);
                    cmd.Parameters.Add("@Medical_Leave", SqlDbType.Int).Value = (int)medical;

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if (typeLable.Text == "Short_Leave")
                {
                    shortleave = shortleave - 1;
                    con.Open();
                    cmd = new SqlCommand("update staff_Leaves set Short_Leave = @Short_Leave where NIC = '" + staffnicLabel.Text + "' ", con);
                    cmd.Parameters.Add("@Short_Leave", SqlDbType.Int).Value = (int)shortleave;

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if (typeLable.Text == "HalfDay_Leave")
                {
                    halfday = halfday + 1;
                    con.Open();
                    cmd = new SqlCommand("update staff_Leaves set HalfDay_Leave = @HalfDay_Leave where NIC = '" + staffnicLabel.Text + "' ", con);
                    cmd.Parameters.Add("@HalfDay_Leave", SqlDbType.Int).Value = (int)halfday;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    ///////////////////
                    if (halfday % 2 == 0)
                    {
                        casual = casual - 1;
                        con.Open();
                        cmd = new SqlCommand("update staff_Leaves set Casual_Leave = @Casual_Leave where NIC = '" + staffnicLabel.Text + "' ", con);
                        cmd.Parameters.Add("@Casual_Leave", SqlDbType.Int).Value = (int)casual;

                        cmd.ExecuteNonQuery();
                        con.Close();

                    }



                }
            }

            cleareText();
        }

        

        public void getLeaves()
        {
            String sNIC = staffnicLabel.Text;
            con.Open();
            SqlCommand command = new SqlCommand("Select * from staff_Leaves where NIC = @getNIC2", con);
            command.Parameters.Add("@getNIC2", SqlDbType.VarChar).Value = sNIC;
            


            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                casual = (int)reader[1];
                medical = (int)reader[2];
                shortleave = (int)reader[3];
                halfday = (int)reader[4];
                year = (int)reader[5];

            }

            con.Close();


        }

        public void cleareText()
        {
           
            staffnicLabel.Text = "";
            typeLable.Text = "";
            reasonLable.Text = "";
            dateLable.Text = "";
            nameLable.Text = "";
            staffpicPictureBox.Image = null;


        }

        private void refreashbtn_Click(object sender, EventArgs e)
        {
            
            displayleaveReuest();
            cleareText();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (staffnicLabel.Text == null || typeLable.Text == null)
            {
                ErrorDialogBox.ShowDialog("Please double click one rquest from table First", "Invaild Data");
            }
            else { 
                con.Open();
                cmd = new SqlCommand("Delete from staff_Temp_Request_Leaves where sid = @sid", con);
                cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
                cmd.ExecuteNonQuery();
                con.Close();

                SuccessfullMessageBox.ShowDialog("Request Cancle Successfully !!!", "Confirmation Message");
           

                String cancleby = Login.setNIC;
                con.Open();
                cmd = new SqlCommand("insert into staff_cancle_Leaves (NIC, type, reason, date, cancleby)values('" + staffnicLabel.Text + "', '" + typeLable.Text + "', '" + reasonLable.Text + "', '" + dateLable.Text + "', @approveby)", con);

                cmd.Parameters.Add("@approveby", SqlDbType.VarChar).Value = cancleby;

                cmd.ExecuteNonQuery();
            
                con.Close();
                cleareText();
            }
        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

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

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void confirmPassword_txt_TextChange(object sender, EventArgs e)
        {

        }

        private void newPassword_txt_TextChange(object sender, EventArgs e)
        {

        }

        private void currentPassword_txt_TextChange(object sender, EventArgs e)
        {

        }
    }
}
