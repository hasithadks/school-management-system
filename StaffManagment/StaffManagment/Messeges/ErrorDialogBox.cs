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
    public partial class ErrorDialogBox : Form
    {
        public ErrorDialogBox(string msg, string tMsg)
        {
            InitializeComponent();
            ErrorMsg.Text = msg;
            TitleErrorMsg.Text = tMsg;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ErrorDialogBox_Load(object sender, EventArgs e)
        {
            bunifuTransition1.Show(this);
        }

        public static void ShowDialog(string msg, string tMsg)
        {
            ErrorDialogBox sdb = new ErrorDialogBox(msg,tMsg);
            sdb.ShowDialog();
        }

        private void ErrorMsgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnErrorMsg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
