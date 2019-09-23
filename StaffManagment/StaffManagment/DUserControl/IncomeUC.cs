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

    public partial class IncomeUC : UserControl
    {

       cIncome IncomeID = new cIncome();

        private static IncomeUC _IncomePaymentInstance;
        public static IncomeUC IncomePaymentInstance
        {
            get
            {
                if (_IncomePaymentInstance == null)
                    _IncomePaymentInstance = new IncomeUC();
                return _IncomePaymentInstance;

            }
        }
        public IncomeUC()
        {
            InitializeComponent();
        }
        public void ReadRecode()
        {
            IncomeImpl InImpl = new IncomeImpl();

            IncomeDataGrid.DataSource = null;
            InImpl.GetAllIncomePaymentRecode();
            IncomeDataGrid.DataSource = InImpl.Dt;
        }

        //Validate 
        public bool IsEmpty()
        {
            if ((dropIncomeUnitName.Text == string.Empty || dropIncomeType.Text == string.Empty || txtIncomeAmount.Text == string.Empty || txtIncomeDate.Text == string.Empty || txtIncomeDescription.Text == string.Empty))
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
            if ((!Regex.Match(dropIncomeUnitName.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success))
            {
                this.Hide();
                ErrorDialogBox.ShowDialog("Company Name is not matched", "Failed");
                this.Show();
                dropIncomeUnitName.Focus();
                return false;
            }
            else if ((!Regex.Match(txtIncomeAmount.Text, @"^([0-9]+)$").Success))
            {
                this.Hide();
                ErrorDialogBox.ShowDialog("Amount is not matched", "Failed");
                this.Show();
                txtIncomeAmount.Focus();
                return false;
            }
            else if ((!Regex.Match(txtIncomeDescription.Text, @"^([0-9A-Za-z @&*%()/\\]+)$").Success))
            {
                this.Hide();
                ErrorDialogBox.ShowDialog("Description is not matched", "Failed");
                this.Show();
                txtIncomeDescription.Focus();
                return false;
            }
            return true;
        }

        public void ResetIncomeRecode()
        {
            dropIncomeUnitName.ResetText();
            dropIncomeType.ResetText();
            txtIncomeAmount.ResetText();
            txtIncomeDate.ResetText();
            txtIncomeDescription.ResetText();
        }

        public void Demo()
        {
            dropIncomeUnitName.Text = "Library";
            dropIncomeType.Text = "Membership fee";
            txtIncomeAmount.Text = Convert.ToString(8000.00);
            txtIncomeDate.Text = "9/23/2000";
            txtIncomeDescription.Text = "Membership fee";
        }
        private void btnIncomeInsert_Click(object sender, EventArgs e)
        {
            if (IsEmpty() && IsValid())
            {
                cIncome cIn = new cIncome(dropIncomeUnitName.Text, dropIncomeType.Text, txtIncomeAmount.Text, txtIncomeDate.Text, txtIncomeDescription.Text);

                iIncome iIn = new IncomeImpl();

                iIn.InsertIncomeRecode(cIn);
                ReadRecode();
                ResetIncomeRecode();
            }
        }

        private void btnIncomeUpdate_Click(object sender, EventArgs e)
        {
            if (IsEmpty() && IsValid())
            {
                cIncome cIn = new cIncome(IncomeID.IncomeID, dropIncomeUnitName.Text, dropIncomeType.Text, txtIncomeAmount.Text, txtIncomeDate.Text, txtIncomeDescription.Text);

                
                iIncome iIn = new IncomeImpl();

                iIn.UpdateIncomeRecode(cIn);
                ReadRecode();
                ResetIncomeRecode();
            }
        }

        private void btnIncomeDelete_Click(object sender, EventArgs e)
        {
            iExpenses iEx = new ExpensesImpl();

            iIncome iIn = new IncomeImpl();
            iIn.DeleteIncomeRecode(IncomeID);
            ReadRecode();
            ResetIncomeRecode();
        }

        private void IncomeUC_Load(object sender, EventArgs e)
        {
            ReadRecode();
        }

        private void IncomeDataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IncomeID.IncomeID = Convert.ToInt32(IncomeDataGrid.SelectedRows[0].Cells[0].Value);
            dropIncomeUnitName.Text = IncomeDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            dropIncomeType.Text = IncomeDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            txtIncomeAmount.Text = IncomeDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            txtIncomeDate.Text = IncomeDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            txtIncomeDescription.Text = IncomeDataGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            Demo();
        }
    }
}