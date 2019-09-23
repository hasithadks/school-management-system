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
using System.IO;
using System.Drawing.Imaging;
using StaffManagment.Model;
using System.Text.RegularExpressions;
using StaffManagment.Messeges;

namespace StaffManagment
{
    public partial class StaffManagment : UserControl
    {
        //database connection


        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;

        //Declare gloable Variables(Set Values to pass to new userform.)
        public static string setfname = "";
        public static string setlname = "";
        public static string setnic = "";
        public static byte[] image;

        private static StaffManagment StaffManagmentInstance_1;

        public static  StaffManagment StaffManagmentInstance
        {
            get
            {
                if(StaffManagmentInstance_1 == null)
                
                    StaffManagmentInstance_1 = new StaffManagment();
                
                return StaffManagmentInstance_1;
            }

        }

        public StaffManagment()
        {
            InitializeComponent();
            display();
        }

       

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            lnametxt.BackColor = Color.White;
        }

        private void atype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StaffManagment_Load(object sender, EventArgs e)
        {

        }

        private void fnametxt_TextChange(object sender, EventArgs e)
        {
            fnametxt.BackColor = Color.White;
        }

        private void tpnotxt_TextChange(object sender, EventArgs e)
        {
            tpnotxt.BackColor = Color.White;
        }

        private void email_Click(object sender, EventArgs e)
        {

        }
        String imagelocation = "";
        

        private void generate_ID_Click(object sender, EventArgs e)
        {
            
            setfname = fnametxt.Text;
            setlname = lnametxt.Text;
            setnic = nictxt.Text;

            MemoryStream ms = new MemoryStream();
            profile_picxtxt.Image.Save(ms, profile_picxtxt.Image.RawFormat);
            image = ms.ToArray();

            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        //Insert Data to the DataBase

        private void Insert_Click(object sender, EventArgs e)
        {

            // ======= Validation ===========

            if (fnametxt.Text == "")
            {
                fnametxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("First name is Requied.", "Validation Error");
                fnametxt.Focus();
                return;
            }
            if (lnametxt.Text == "")
            {
                lnametxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Last name is Requied.", "Validation Error");
                lnametxt.Focus();
                return;
            }
            if (tpnotxt.Text == "")
            {
                tpnotxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Telephone No is Requied.", "Validation Error");
                tpnotxt.Focus();
                return;
            }
           
            else
            {
                Regex regtp = new Regex(@"^\d{10}$");
                if (!regtp.IsMatch(tpnotxt.Text))
                {

                    tpnotxt.BackColor = Color.Red;
                    ErrorDialogBox.ShowDialog("Telephone must containt 10 numbers and NO Alpebetic Letters", "Validation Error");
                    tpnotxt.Focus();
                    return;

                }
            }
            if (emailtxt.Text == "")
            {
                emailtxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Email is Requied.", "Validation Error");
                emailtxt.Focus();
                return;

            }
            else
            {
                Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                   + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                   + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                   + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                   + @"[a-zA-Z]{2,}))$",
                                   RegexOptions.Compiled);
                if (!regEmail.IsMatch(emailtxt.Text))
                {
                    emailtxt.BackColor = Color.Red;
                    ErrorDialogBox.ShowDialog("Please Insert Valid Email Requied.", "Validation Error");
                    emailtxt.Focus();
                    return;
                }


            }
            if (address1txt.Text == "")
            {
                address1txt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Addres line 01 is Requied.", "Validation Error");
                address1txt.Focus();
                return;

            }
            if (address2txt.Text == "")
            {
                address2txt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Addres line 02 is Requied.", "Validation Error");
                address2txt.Focus();
                return;

            }
            if (address3txt.Text == "")
            {
                address3txt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Addres line 03 is Requied.", "Validation Error");
                address3txt.Focus();
                return;

            }
            if (nictxt.Text == "")
            {
                nictxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("NIC is Requied.", "Validation Error");
                nictxt.Focus();
                return;

            }
            else
            {
                Regex regNIC = new Regex(@"^[0-9]{9}[vV]$");
                if (!regNIC.IsMatch(nictxt.Text))
                {

                    nictxt.BackColor = Color.Red;
                    ErrorDialogBox.ShowDialog("NIC must containt 9 numbers and 'V' or 'v' at the last.", "Validation Error");
                    nictxt.Focus();
                    return;

                }

            }
            if (passwordtxt.Text == "")
            {
                passwordtxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Password is Requied.", "Validation Error");
                passwordtxt.Focus();
                return;

            }
            



            //Image

            MemoryStream ms = new MemoryStream();
            profile_picxtxt.Image.Save(ms, profile_picxtxt.Image.RawFormat);
            image = ms.ToArray();

            String temNic = nictxt.Text;

            Boolean ans= checkNIC(temNic);

            if (ans == true)
            {

                ErrorDialogBox.ShowDialog("This Employee Already Registered!!!Pleace Register another Employee.", "Validation Error");
            }
            else
            {

                con.Open();
                cmd = new SqlCommand("INSERT INTO Staff_Mang_Table VALUES('" + nictxt.Text + "','" + titletxt.Text + "','" + fnametxt.Text + "','" + lnametxt.Text + "','" + gendertxt.Text + "','" + tpnotxt.Text + "','" + emailtxt.Text + "','" + address1txt.Text + "','" + address2txt.Text + "','" + address3txt.Text + "','" + qualificationtxt.Text + "','" + atypetxt.Text + "','" + passwordtxt.Text + "','" + sdatetxt.Text + "', @photo)", con);

                cmd.Parameters.Add("@photo", SqlDbType.VarBinary).Value = image;
                cmd.ExecuteNonQuery();
                SuccessfullMessageBox.ShowDialog("Registration Successfully.", "Confirmation Message");
                con.Close();
                display();
            }


        }
        String dbNICget = "";

        public Boolean checkNIC(string nic)
        {
            
            con.Open();
            cmd = new SqlCommand("select NIC from Staff_Mang_Table",con);
           // cmd.Parameters.Add("@nic", SqlDbType.VarChar).Value = nic;

            SqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read()) 
            {
                dbNICget = (String)reader[0];

                if (dbNICget == nic)
                {
                    con.Close();
                    return true;
                }
               
      
            }
            con.Close();
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Profile Picture Upload or Brows from the PC

        private void profile_pic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;

                    profile_picxtxt.ImageLocation = imagelocation;



                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Ocured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void display()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT photo as 'Image', NIC as 'NIC', title as 'Title', fname as 'FirstName', lname as 'LastName', gender as 'Gender', tpno as 'Phone No', email as 'Email', address1 as 'Address01', address2 as 'Address02', address3 as 'Address03', accountType as 'Account Type', password as 'Password', startdate as 'Start Date' , qualification as 'Qualifications' from Staff_Mang_Table";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                staff_table_data_grid.RowTemplate.Height = 50;
                staff_table_data_grid.AllowUserToAddRows = false;
                staff_table_data_grid.DataSource = dt;
                DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                imgcol = (DataGridViewImageColumn)staff_table_data_grid.Columns[0];
                imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                staff_table_data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        public void searchStaff(String txt)
        {
            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT photo as 'Image', NIC as 'NIC', title as 'Title', fname + ' ' + lname as 'Name', gender as 'Gender', tpno as 'Phone No', email as 'Email', address1 + ' ' + address2 + ' ' + address3 as 'Address', qualification as 'Qualifications', accountType as 'Account Type', password as 'Password', startdate as 'Start Date' from Staff_Mang_Table where fname like '%" + txt + "%' or lname like '%" + txt + "%' or NIC like '%" + txt + "%' ";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                staff_table_data_grid.RowTemplate.Height = 50;
                staff_table_data_grid.AllowUserToAddRows = false;
                staff_table_data_grid.DataSource = dt;
                DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                imgcol = (DataGridViewImageColumn)staff_table_data_grid.Columns[0];
                imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                staff_table_data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchStaff(searchtxt.Text);
        }

        private void searchtxt_TextChange(object sender, EventArgs e)
        {
            searchStaff(searchtxt.Text);
        }

        private void reset_Click(object sender, EventArgs e)
        {

            clearallData();

        }

        public void clearallData()
        {
            fnametxt.Text = "";
            lnametxt.Text = "";
            tpnotxt.Text = "";
            emailtxt.Text = "";
            address1txt.Text = "";
            address2txt.Text = "";
            address3txt.Text = "";
            nictxt.Text = "";
            passwordtxt.Text = "";
            qualificationtxt.Text = "";
            titletxt.SelectedIndex = -1;
            gendertxt.SelectedIndex = -1;
            atypetxt.SelectedIndex = -1;
            profile_picxtxt.Image = null;



        }

        private void staff_table_data_grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            titletxt.Text = staff_table_data_grid.SelectedRows[0].Cells[2].Value.ToString();
            gendertxt.Text = staff_table_data_grid.SelectedRows[0].Cells[5].Value.ToString();
            fnametxt.Text = staff_table_data_grid.SelectedRows[0].Cells[3].Value.ToString();
            lnametxt.Text = staff_table_data_grid.SelectedRows[0].Cells[4].Value.ToString();
            tpnotxt.Text = staff_table_data_grid.SelectedRows[0].Cells[6].Value.ToString();
            emailtxt.Text = staff_table_data_grid.SelectedRows[0].Cells[7].Value.ToString();
            address1txt.Text = staff_table_data_grid.SelectedRows[0].Cells[8].Value.ToString();
            address2txt.Text = staff_table_data_grid.SelectedRows[0].Cells[9].Value.ToString();
            address3txt.Text = staff_table_data_grid.SelectedRows[0].Cells[10].Value.ToString();
            nictxt.Text = staff_table_data_grid.SelectedRows[0].Cells[1].Value.ToString();
            atypetxt.Text = staff_table_data_grid.SelectedRows[0].Cells[11].Value.ToString();
            passwordtxt.Text = staff_table_data_grid.SelectedRows[0].Cells[12].Value.ToString();
            sdatetxt.Text = staff_table_data_grid.SelectedRows[0].Cells[13].Value.ToString();
            qualificationtxt.Text = staff_table_data_grid.SelectedRows[0].Cells[14].Value.ToString();

            
            Byte[] img = (Byte[])staff_table_data_grid.CurrentRow.Cells[0].Value;
            MemoryStream ms = new MemoryStream(img);
            profile_picxtxt.Image = Image.FromStream(ms);
        }

        private void update_Click(object sender, EventArgs e)
        {
            
           
                updateData();
            

        }

        public void updateData()
        {

            // ======= Validation ===========

            if (fnametxt.Text == "")
            {
                fnametxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("First name is Requied.", "Validation Error");
                fnametxt.Focus();
                return;
            }
            if (lnametxt.Text == "")
            {
                lnametxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Last name is Requied.", "Validation Error");
                lnametxt.Focus();
                return;
            }
            if (tpnotxt.Text == "")
            {
                tpnotxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Telephone No is Requied.", "Validation Error");
                tpnotxt.Focus();
                return;
            }

            else
            {
                Regex regtp = new Regex(@"^\d{10}$");
                if (!regtp.IsMatch(tpnotxt.Text))
                {

                    tpnotxt.BackColor = Color.Red;
                    ErrorDialogBox.ShowDialog("Telephone must containt 10 numbers and NO Alpebetic Letters", "Validation Error");
                    tpnotxt.Focus();
                    return;

                }
            }
            if (emailtxt.Text == "")
            {
                emailtxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Email is Requied.", "Validation Error");
                emailtxt.Focus();
                return;

            }
            else
            {
                Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                   + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                   + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                   + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                   + @"[a-zA-Z]{2,}))$",
                                   RegexOptions.Compiled);
                if (!regEmail.IsMatch(emailtxt.Text))
                {
                    emailtxt.BackColor = Color.Red;
                    ErrorDialogBox.ShowDialog("Please Insert Valid Email Requied.", "Validation Error");
                    emailtxt.Focus();
                    return;
                }


            }
            if (address1txt.Text == "")
            {
                address1txt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Addres line 01 is Requied.", "Validation Error");
                address1txt.Focus();
                return;

            }
            if (address2txt.Text == "")
            {
                address2txt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Addres line 02 is Requied.", "Validation Error");
                address2txt.Focus();
                return;

            }
            if (address3txt.Text == "")
            {
                address3txt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Addres line 03 is Requied.", "Validation Error");
                address3txt.Focus();
                return;

            }
            if (nictxt.Text == "")
            {
                nictxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("NIC is Requied.", "Validation Error");
                nictxt.Focus();
                return;

            }
            else
            {
                Regex regNIC = new Regex(@"^[0-9]{9}[vV]$");
                if (!regNIC.IsMatch(nictxt.Text))
                {

                    nictxt.BackColor = Color.Red;
                    ErrorDialogBox.ShowDialog("NIC must containt 9 numbers and 'V' or 'v' at the last.", "Validation Error");
                    nictxt.Focus();
                    return;

                }

            }
            if (passwordtxt.Text == "")
            {
                passwordtxt.BackColor = Color.Red;
                ErrorDialogBox.ShowDialog("Password is Requied.", "Validation Error");
                passwordtxt.Focus();
                return;

            }

            String temNic = nictxt.Text;

            Boolean ans = checkNIC(temNic);

            if (ans != true)
            {

                ErrorDialogBox.ShowDialog("Invalid NIC. Please enter Registerd NIC", "Validation Error");
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                profile_picxtxt.Image.Save(ms, profile_picxtxt.Image.RawFormat);
                byte[] image = ms.ToArray();

                con.Open();
                cmd = new SqlCommand("update Staff_Mang_Table set title = '" + titletxt.Text + "', fname = '" + fnametxt.Text + "', lname = '" + lnametxt.Text + "', gender = '" + gendertxt.Text + "',tpno = '" + tpnotxt.Text + "', email = '" + emailtxt.Text + "', address1 = '" + address1txt.Text + "', address2 = '" + address2txt.Text + "', address3 = '" + address3txt.Text + "', qualification = '" + qualificationtxt.Text + "', accountType = '" + atypetxt.Text + "', password = '" + passwordtxt.Text + "', startdate = '" + sdatetxt.Text + "', photo = @photo where NIC = '" + nictxt.Text + "'", con);

                cmd.Parameters.Add("@photo", SqlDbType.VarBinary).Value = image;

                cmd.ExecuteNonQuery();

                SuccessfullMessageBox.ShowDialog("Update Successfully !!!", "Confirmation Message");
                // MessageBox.Show("Update Successfully !!!");
                con.Close();
                display();
                clearallData();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            String temNic = "";
            temNic = nictxt.Text;
            Boolean ans = checkNIC(temNic);

            if (temNic == "") {
               // MessageBox.Show("Pleace Insert NIC!!!");
                ErrorDialogBox.ShowDialog("Pleace Insert NIC!!!", "Validation Error");

            }
            else if (ans != true)
            {
                ErrorDialogBox.ShowDialog("Invalid NIC. Please enter Registerd NIC", "Validation Error");
            }
            else
            {
                
                con.Open();
                cmd = new SqlCommand("Delete from  Staff_Mang_Table where NIC =  '" + nictxt.Text + "'", con);
                cmd.ExecuteNonQuery();
                SuccessfullMessageBox.ShowDialog("Delere Records Successfully!!!", "Confirmation Message");
               // MessageBox.Show("Delere Records Successfully!!!");
                con.Close();
                display();
                clearallData();
            }

        }

        private void emailtxt_TextChange(object sender, EventArgs e)
        {
            emailtxt.BackColor = Color.White;
        }

        private void address1txt_TextChange(object sender, EventArgs e)
        {
            address1txt.BackColor = Color.White;
        }

        private void address2txt_TextChange(object sender, EventArgs e)
        {
            address2txt.BackColor = Color.White;
        }

        private void address3txt_TextChange(object sender, EventArgs e)
        {
            address3txt.BackColor = Color.White;
        }

        private void nictxt_TextChange(object sender, EventArgs e)
        {
            nictxt.BackColor = Color.White;
        }

        private void passwordtxt_TextChange(object sender, EventArgs e)
        {
            passwordtxt.BackColor = Color.White;
        }

        private void system_Click(object sender, EventArgs e)
        {

        }

        internal class principle_profile
        {
            public principle_profile()
            {
            }
        }

        private void demobtn_Click(object sender, EventArgs e)
        {


            fnametxt.Text = "Sameera";
            lnametxt.Text = "Premarathne";
            tpnotxt.Text = "0714458631";
            emailtxt.Text = "sameera@gmail.com";
            address1txt.Text = "No 45";
            address2txt.Text = "Galwala Junction";
            address3txt.Text = "Makola";
            nictxt.Text = "824671206V";
            passwordtxt.Text = "abc@123";
            qualificationtxt.Text = "MBBS";
            titletxt.SelectedIndex = 0;
            gendertxt.SelectedIndex = 0;
            atypetxt.SelectedIndex = 1;
           



        }
    }
}
