using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using StaffManagment;

namespace SchoolManagementSystem
{
    public partial class ExpensesUC : UserControl
    {
        cExpenses ExpensesID = new cExpenses();

        private static ExpensesUC _ExpensesInstance;
        public static ExpensesUC ExpensesInstance
        {
            get
            {
                if (_ExpensesInstance == null)
                    _ExpensesInstance = new ExpensesUC();
                return _ExpensesInstance;

            }
        }
        public ExpensesUC()
        {
            InitializeComponent();
        }

        private void btnExpensesInsert_Click(object sender, EventArgs e)
        {
            if (IsEmpty() && IsValid())
            {
                cExpenses cEx = new cExpenses(dropExpensesUnitName.Text, dropExpensesType.Text, txtExpensesAmount.Text, txtExpensesDate.Text, txtExpensesDescription.Text);

                iExpenses iEx = new ExpensesImpl();

                iEx.InsertExpensesRecode(cEx);
                ReadRecode();
                ResetExpensesRecode();
            }
        }

        private void btnExpensesUpdate_Click(object sender, EventArgs e)
        {
            if (IsEmpty() && IsValid())
            {
                cExpenses cEx = new cExpenses(ExpensesID.expensesID, dropExpensesUnitName.Text, dropExpensesType.Text, txtExpensesAmount.Text, txtExpensesDate.Text, txtExpensesDescription.Text);

                iExpenses iEx = new ExpensesImpl();

                iEx.UpdateExpensesRecode(cEx);
                ReadRecode();
                ResetExpensesRecode();
            }
        }

        private void btnExpensesDelete_Click(object sender, EventArgs e)
        {
            iExpenses iEx = new ExpensesImpl();

            iEx.DeleteExpensesRecode(ExpensesID);
            ReadRecode();
            ResetExpensesRecode();
        }

        private void btnExpensesReset_Click(object sender, EventArgs e)
        {
            ResetExpensesRecode();
        }

        //Reset Textbox
        public void ResetExpensesRecode()
        {
            dropExpensesUnitName.ResetText();
            dropExpensesType.ResetText();
            txtExpensesAmount.ResetText();
            txtExpensesDate.ResetText();
            txtExpensesDescription.ResetText();
        }

        public void Demo()
        {
            dropExpensesUnitName.Text = "Library";
            dropExpensesType.Text = "Buy new Items";
            txtExpensesAmount.Text = Convert.ToString(45000.00);
            txtExpensesDate.Text = "9/23/2000";
            txtExpensesDescription.Text = "Buy New Books";
        }

        //Display Recode
        public void ReadRecode()
        {
            ExpensesImpl ExImpl = new ExpensesImpl();

            ExpensesDataGrid.DataSource = null;
            ExImpl.GetAllExpensesPaymentRecode();
            ExpensesDataGrid.DataSource = ExImpl.Dt;
        }

        //Validate 
        public bool IsEmpty()
        {
            if ((dropExpensesUnitName.Text == string.Empty || dropExpensesType.Text == string.Empty || txtExpensesAmount.Text == string.Empty || txtExpensesDate.Text == string.Empty || txtExpensesDescription.Text == string.Empty))
            {
                this.Hide();
                ErrorDialogBox.ShowDialog("All Repair Informations are Required", "Failed");
                this.Show();
                return false;
            }
            return true;
        }

        public bool IsValid()
        {
            if ((!Regex.Match(dropExpensesUnitName.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success))
            {
                this.Hide();
                ErrorDialogBox.ShowDialog("Company Name is not matched", "Failed");
                this.Show();
                dropExpensesUnitName.Focus();
                return false;
            }
            else if ((!Regex.Match(txtExpensesAmount.Text, @"^([0-9]+)$").Success))
            {
                this.Hide();
                ErrorDialogBox.ShowDialog("Amount is not matched", "Failed");
                this.Show();
                txtExpensesAmount.Focus();
                return false;
            }
            else if ((!Regex.Match(txtExpensesDescription.Text, @"^([0-9A-Za-z @&*%()/\\]+)$").Success))
            {
                this.Hide();
                ErrorDialogBox.ShowDialog("Description is not matched", "Failed");
                this.Show();
                txtExpensesDescription.Focus();
                return false;
            }
            return true;
        }

        private void ExpensesUC_Load(object sender, EventArgs e)
        {
            ReadRecode();
        }


        private void ExpensesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExpensesID.expensesID = Convert.ToInt32(ExpensesDataGrid.SelectedRows[0].Cells[0].Value);
            dropExpensesUnitName.Text = ExpensesDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            dropExpensesType.Text = ExpensesDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            txtExpensesAmount.Text = ExpensesDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            txtExpensesDate.Text = ExpensesDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            txtExpensesDescription.Text = ExpensesDataGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            Demo();
        }
    }
}
