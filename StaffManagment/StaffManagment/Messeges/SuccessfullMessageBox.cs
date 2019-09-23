using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagment.Messeges
{
    public partial class SuccessfullMessageBox : Form
    {
        public SuccessfullMessageBox(string msg, string tMsg)
        {
            InitializeComponent();
            SuccessMsg.Text = msg;
            TitleSuccessMsg.Text = tMsg;
        }

        private void SuccessMsgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuccessMsg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowDialog(string msg, string tMsg)
        {
            SuccessfullMessageBox sdb = new SuccessfullMessageBox(msg, tMsg);
            sdb.ShowDialog();
        }
    }
}
