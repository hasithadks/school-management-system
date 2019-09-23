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
    public partial class requestleave : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;

        String getNIC2 = Login.setNIC;

        private static requestleave StaffManagmentInstance_10;

        public static requestleave StaffManagmentInstance_6
        {
            get
            {
                if (StaffManagmentInstance_10 == null)

                    StaffManagmentInstance_10 = new requestleave();

                return StaffManagmentInstance_10;
            }

        }

        public requestleave()
        {
            InitializeComponent();
            displayleave();
        }

        private void rfullday_Click(object sender, EventArgs e)
        {

        }

        private void selectnic_Click(object sender, EventArgs e)
        {

        }

        int casual = 0;
        int medical = 0;
        int halfday = 0;
        int shortleave = 0;
        int year = 0;
        //int tempHalf = 0;

        private void nicsubmitbtn2_Click(object sender, EventArgs e)
        {

            

            

            
           

        }

        public void displayleave()
        {
            String getNIC2 = Login.setNIC;
            SqlCommand command = new SqlCommand("Select * from staff_Leaves where NIC = @getNIC2", con);
            command.Parameters.Add("@getNIC2", SqlDbType.VarChar).Value = getNIC2;
            con.Open();


            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                casual = (int)reader[1];
                medical = (int)reader[2];
                shortleave = (int)reader[3];
                halfday = (int)reader[4];
                year = (int)reader[5];
                

            }

            casualLabelTxt.Text = casual.ToString();
            medicalLableTxt.Text = medical.ToString();
            shortleavelabelTxt.Text = shortleave.ToString();
            nohalfdayLable.Text = halfday.ToString();
            yearLable.Text = year.ToString();
            con.Close();

        }

        private void requestlvbtn_Click(object sender, EventArgs e)
        {

            if (reasontxt.Text == "")
            {
                reasontxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Reason is Requied.", "Validation Error");
                reasontxt.Focus();
                return;

            }


            if (typetxt.Text == "Casual_Leave")
            {
                if(casual > 0)
                {
                    
                    
                    con.Open();
                    cmd = new SqlCommand("Insert into staff_Temp_Request_Leaves (NIC, type, reason, date) values(@getNIC2,'" + typetxt.Text + "', '" + reasontxt.Text + "','" + selectDateTxt.Text + "')", con);
                    cmd.Parameters.Add("@getNIC2", SqlDbType.VarChar).Value = getNIC2;
                    cmd.ExecuteNonQuery();
                   
                    con.Close();
                    displayleave();

                    SuccessfullMessageBox.ShowDialog("Casual Leave Request is Applly Successfully !!!", "Confirmation Message");



                }
                else
                {
                    ErrorDialogBox.ShowDialog("Sorry!!! All alocated Casual Leaves Are Used this Month.", "No Leaves");
                    // MessageBox.Show("Sorry!!! All alocated Casual Leaves Are Used.");
                }

            }


            
            else if(typetxt.Text == "HalfDay_Leave")
            {
                if (casual > 0)
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into staff_Temp_Request_Leaves (NIC, type, reason, date) values(@getNIC2,'" + typetxt.Text + "', '" + reasontxt.Text + "','" + selectDateTxt.Text + "')", con);
                    cmd.Parameters.Add("@getNIC2", SqlDbType.VarChar).Value = getNIC2;
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("Leaves Pending!!!");
                    con.Close();
                    displayleave();
                    // MessageBox.Show("Half Day Leave Request is Applly Successfully !!!");
                    SuccessfullMessageBox.ShowDialog("Half Day Leave Request is Applly Successfully !!!", "Confirmation Message");

                }
                else
                {
                    ErrorDialogBox.ShowDialog("Sorry!!! All alocated Half Day Leaves Are Used this Month.", "No Leaves");
                    //MessageBox.Show("Sorry!!! All alocated Half Day Leaves Are Used this Month.");
                }
            }
            else if (typetxt.Text == "Medical_Leave")
            {
                if (medical > 0)
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into staff_Temp_Request_Leaves (NIC, type, reason, date) values(@getNIC2,'" + typetxt.Text + "', '" + reasontxt.Text + "','" + selectDateTxt.Text + "')", con);
                    cmd.Parameters.Add("@getNIC2", SqlDbType.VarChar).Value = getNIC2;
                    cmd.ExecuteNonQuery();
                    
                    con.Close();
                    displayleave();
                    SuccessfullMessageBox.ShowDialog("Medical_Leave Leave Request is Applly Successfully !!!", "Confirmation Message");
                    // MessageBox.Show("Medical Leave Request is Applly Successfully !!!");
                    //  Payment.SuccessDialogBox.ShowDialog("Medical_Leave Request is Applly Successfully !!!", "Successfull Message");
                }
                else
                {
                    ErrorDialogBox.ShowDialog("Sorry!!! All alocated Medical Leaves Are Used this Month.", "No Leaves");
                   // MessageBox.Show("Sorry!!! All alocated Medical Leaves Are Used this Month.");

                }



            }    
            else if(typetxt.Text == "Short_Leave")
            {
                if (shortleave > 0)
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into staff_Temp_Request_Leaves (NIC, type, reason, date) values(@getNIC2,'" + typetxt.Text + "', '" + reasontxt.Text + "','" + selectDateTxt.Text + "')", con);
                    cmd.Parameters.Add("@getNIC2", SqlDbType.VarChar).Value = getNIC2;
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("Leaves Pending!!!");
                    con.Close();
                    displayleave();
                    //Payment.SuccessDialogBox.ShowDialog("shortleaves Request is Applly Successfully !!!", "Successfull Message");
                    // MessageBox.Show("shortleaves Request is Applly Successfully !!!");
                    SuccessfullMessageBox.ShowDialog("shortleaves Leave Request is Applly Successfully !!!", "Confirmation Message");
                }
                else
                {
                    ErrorDialogBox.ShowDialog("Sorry!!! All alocated shortleaves Leaves Are Used this Month.", "No Leaves");
                   // MessageBox.Show("Sorry!!! All alocated Half Day Leaves Are Used this Month.");
                }



            }
            else
            {
                ErrorDialogBox.ShowDialog("Sorry!!! No ", " Invaild Type");
                MessageBox.Show("Invaild type !!!");
            }

            reasontxt.Text = "";
            typetxt.SelectedIndex = -1;
            

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            displayleave();
        }

        private void reasontxt_TextChange(object sender, EventArgs e)
        {
            reasontxt.BackColor = Color.White;
        }

        private void remainleaves_Enter(object sender, EventArgs e)
        {

        }
    }
}
