using StaffManagment;
using StaffManagment.Messeges;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class ExpensesImpl : iExpenses
    {
        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");

        IncomeUC InUC = IncomeUC.IncomePaymentInstance;
        public ExpensesUC Ex = new ExpensesUC();
        public DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();

        //Delete Recode
        void iExpenses.DeleteExpensesRecode(cExpenses Expenses)
        {
            if (Expenses.expensesID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM expensesPayment WHERE expensesID = @EID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@EID", Expenses.expensesID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                InUC.Hide();
                SuccessfullMessageBox.ShowDialog("Expenses Recode is Delete Successfully", "Successfully Deleted");
                InUC.Show();
            }
            else
            {
                InUC.Hide();
                ErrorDialogBox.ShowDialog("Please Select a Expenses Recode to Delete", "Error");
                InUC.Show();
            }
        }

        //Insert Recode
        void iExpenses.InsertExpensesRecode(cExpenses Expenses)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO expensesPayment VALUES (@EUName, @ExpensesType, @ExpensesAmount, @ExpensesDate, @ExpensesDescription)", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@EUName", Expenses.expensesUnitName);
            cmd.Parameters.AddWithValue("@ExpensesType", Expenses.expensesType);
            cmd.Parameters.AddWithValue("@ExpensesAmount", Expenses.expensesAmount);
            cmd.Parameters.AddWithValue("@ExpensesDate", Expenses.expensesDate);
            cmd.Parameters.AddWithValue("@ExpensesDescription", Expenses.expensesDescription);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            InUC.Hide();
            SuccessfullMessageBox.ShowDialog("A New Expenses Recode is Insert Successfully", "Successfully Inserted");
            InUC.Show();
        }

        //Update Recode
        void iExpenses.UpdateExpensesRecode(cExpenses Expenses)
        {
            if (Expenses.expensesID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE expensesPayment SET expensesUnitName = @EUName, expensesType = @ExpensesType, expensesAmount = @ExpensesAmount, expensesDate = @ExpensesDate, expensesDescription = @ExpensesDescription WHERE expensesID = @EID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@EUName", Expenses.expensesUnitName);
                cmd.Parameters.AddWithValue("@ExpensesType", Expenses.expensesType);
                cmd.Parameters.AddWithValue("@ExpensesAmount", Expenses.expensesAmount);
                cmd.Parameters.AddWithValue("@ExpensesDate", Expenses.expensesDate);
                cmd.Parameters.AddWithValue("@ExpensesDescription", Expenses.expensesDescription);
                cmd.Parameters.AddWithValue("@EID", Expenses.expensesID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                InUC.Hide();
                SuccessfullMessageBox.ShowDialog("A New Expenses Recode is Update  Successfully", "Successfully Inserted");
                InUC.Show();
            }

            else
            {
                InUC.Hide();
                ErrorDialogBox.ShowDialog("Please Select a Expenses Recode to Update", "Error");
                InUC.Show();
            }
        }

        //Get Recode
        public void GetAllExpensesPaymentRecode()
        {
            Dt.Clear();
            SqlCommand cmd = new SqlCommand("select * from expensesPayment", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            Dt.Load(sdr);
            con.Close();

          
        }

        public void GetParticularExpensesPaymentRecode(cIncomeExpensesReport Report)
        {

            Dt.Clear();
            SqlCommand cmd = new SqlCommand("SELECT* FROM expensesPayment WHERE YEAR(expensesDate) = @Year and MONTH(expensesDate) = @Month", con);
            // cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Year", Report.year);
            cmd.Parameters.AddWithValue("@Month", Report.month);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            Dt.Load(sdr);
            con.Close();

            //Ex.ExpensesDataGrid.DataSource = Dt;
        }
    }
}
