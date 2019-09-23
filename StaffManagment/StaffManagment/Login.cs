using SchoolManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StaffManagment
{
    public partial class Login : Form
    {
        private static Login _instance;
        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;

        public static String setpassword = "";
        public static String setNIC = "";

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Login();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        public Login()
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
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            String atype = null;
            atype = atypelogin.Text.ToString();

            if (atypelogin.Text == "Admin")
            {
                String username = "Admin";
                String password = "Admin";

                if (usernametxt.Text == username && loginpasswordtxt.Text == password)
                {

                    this.Hide();
                 //   Form1 sf = new Form1();
                  //  sf.Show();
                 //   var form2 = Form1.StaffFrom2;
                   // this.Closed += (s, args) => this.Close();
                  //  form2.Show();

                    SchoolManagementSystem.mainMenu nm = new SchoolManagementSystem.mainMenu();
                    nm.Show();
                 //   var form3 = SchoolManagementSystem.mainMenu.maintt;
                 //   form3.Show();

                }
                else
                {
                    ErrorDialogBox.ShowDialog("UserName and Password Does not Match, Pleace Re Enter!!!", "Invaild UserName Or Password");
                    con.Close();
                    return;
                }




            }
            else if (atype == "Staff")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Staff_Mang_Table where NIC = '" + usernametxt.Text + "' AND password = '" + loginpasswordtxt.Text + "'", con);
                SqlDataAdapter checkDa = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();
                DataSet ds = new DataSet();

                int i = 0;
                while (reader.Read()) {
                    i++;
                }


                if (i > 0)
                {


                    this.Hide();
                    staff_profile f = new staff_profile();
                    f.Show();
                    var form1 = staffprofile.StaffManagmentInstance_4;
                  //  this.Closed += (s, args) => this.Close();
                    form1.Show();

                }
                else
                {

                    ErrorDialogBox.ShowDialog("UserName and Password Does not Match, Pleace Re Enter!!!", "Invaild UserName Or Password");
                    con.Close();
                    return;
                }


            }
            else if (atypelogin.Text == "Student") 
            {





            }
            else if(atypelogin.Text == "")
            {

                ErrorDialogBox.ShowDialog("Please Select UserType!!!", "Invaild User");

                con.Close();
                return;
            }


            setpassword = loginpasswordtxt.Text;
            setNIC = usernametxt.Text;

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonminimizesd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
