using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class loding : Form
    {
        private int move;
        public loding()
        {
            InitializeComponent();
        }

        private void loding_Load(object sender, EventArgs e)
        {
            LodingTimer.Start();
        }

        private void LodingTimer_Tick(object sender, EventArgs e)
        {
            lodingSline.Left += 1;

            if (lodingSline.Left > 219)
            {
                lodingSline.Left = 0;
            }
            if (lodingSline.Left < 0)
            {
                move = 2;
            }
        }
    }
}
