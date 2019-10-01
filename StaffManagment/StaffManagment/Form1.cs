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
    public partial class Form1 : Form
    {

        private static Form1 StaffFrom;

        public static Form1 StaffFrom2
        {
            get
            {
                if (StaffFrom == null)

                    StaffFrom = new Form1();

                return StaffFrom;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void managestaff_Click(object sender, EventArgs e)
        {

            if (!staff_main_pannel.Controls.Contains(StaffManagment.StaffManagmentInstance))
            {
                staff_main_pannel.Controls.Add(StaffManagment.StaffManagmentInstance);
                StaffManagment.StaffManagmentInstance.BringToFront();
            }
            else
            {
                StaffManagment.StaffManagmentInstance.BringToFront();
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

        private void staff_main_pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnormalize_Click(object sender, EventArgs e)
        {

        }

        private void generateID_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu mMenu = new mainMenu();
            mMenu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            staff_main_pannel.Controls.Add(StaffManagment.StaffManagmentInstance);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
