using SchoolManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagment
{
    public partial class staff_profile : Form
    {

        private static staff_profile StaffProfileInstance_1;

        public static staff_profile StaffManagmentInstance
        {
            get
            {
                if (StaffProfileInstance_1 == null)

                    StaffProfileInstance_1 = new staff_profile();

                return StaffProfileInstance_1;
            }

        }

        public staff_profile()
        {
            InitializeComponent();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            
            string nic = Login.setNIC;

            if(nic == "777888999V")
            {

                if (!staff_profile_panel.Controls.Contains(principle_profile.pricipleInstance_11))
                {
                    staff_profile_panel.Controls.Add(principle_profile.pricipleInstance_11);
                    principle_profile.pricipleInstance_11.BringToFront();
                }
                else
                {
                    principle_profile.pricipleInstance_11.BringToFront();
                }



            }
            else { 

                if (!staff_profile_panel.Controls.Contains(staffprofile.StaffManagmentInstance_4))
                {
                    staff_profile_panel.Controls.Add(staffprofile.StaffManagmentInstance_4);
                staffprofile.StaffManagmentInstance_4.BringToFront();
                }
                else
                {
                staffprofile.StaffManagmentInstance_4.BringToFront();
                }
            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonminimizesd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void requestLeave_Click(object sender, EventArgs e)
        {
            if (!staff_profile_panel.Controls.Contains(requestleave.StaffManagmentInstance_6))
            {
                staff_profile_panel.Controls.Add(requestleave.StaffManagmentInstance_6);
                requestleave.StaffManagmentInstance_6.BringToFront();
            }
            else
            {
                requestleave.StaffManagmentInstance_6.BringToFront();
            }


        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();



        }

        private void staff_profile_Load(object sender, EventArgs e)
        {
            staff_profile_panel.Controls.Add(requestleave.StaffManagmentInstance_6);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu mMenu = new mainMenu();
            mMenu.Show();
        }
    }
}
