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
    class IncomeImpl :iIncome
    {
        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");

        IncomeUC InUC = IncomeUC.IncomePaymentInstance;
        public ExpensesUC Ex = new ExpensesUC();
        public IncomeUC In = new IncomeUC();
        public DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();

        //Delete Recode
        void iIncome.DeleteIncomeRecode(cIncome Income)
        {
            if (Income.IncomeID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM incomePayment WHERE incomeID = @IID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@IID", Income.IncomeID);

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
        void iIncome.InsertIncomeRecode(cIncome Income)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO incomePayment VALUES (@IUName, @IncomeType, @IncomeAmount, @IncomeDate, @IncomeDescription)", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@IUName", Income.incomeUnitName);
            cmd.Parameters.AddWithValue("@IncomeType", Income.incomeType);
            cmd.Parameters.AddWithValue("@IncomeAmount", Income.incomeAmount);
            cmd.Parameters.AddWithValue("@IncomeDate", Income.incomeDate);
            cmd.Parameters.AddWithValue("@IncomeDescription", Income.incomeDescription);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            InUC.Hide();
            SuccessfullMessageBox.ShowDialog("A New Expenses Recode is Insert Successfully", "Successfully Inserted");
            InUC.Show();

        }

        //Update Recode
        void iIncome.UpdateIncomeRecode(cIncome Income)
        {
            if (Income.IncomeID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE incomePayment SET incomeUnitName = @IUName, incomeType = @IncomeType, incomeAmount = @IncomeAmount, incomeDate = @IncomeDate, incomeDescription = @IncomeDescription WHERE incomeID = @IID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@IUName", Income.incomeUnitName);
                cmd.Parameters.AddWithValue("@IncomeType", Income.incomeType);
                cmd.Parameters.AddWithValue("@IncomeAmount", Income.incomeAmount);
                cmd.Parameters.AddWithValue("@IncomeDate", Income.incomeDate);
                cmd.Parameters.AddWithValue("@IncomeDescription", Income.incomeDescription);
                cmd.Parameters.AddWithValue("@IID", Income.IncomeID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                InUC.Hide();
                SuccessfullMessageBox.ShowDialog("A New Expenses Recode is Update  Successfully", "Successfully Inserted");
                InUC.Show();
            }

            else
            {
               // InUC.Hide();
                ErrorDialogBox.ShowDialog("Please Select a Expenses Recode to Update", "Error");
               // InUC.Show();
            }
        }

        //Get Recode
        public void GetAllIncomePaymentRecode()
        {
            Dt.Clear();
            SqlCommand cmd = new SqlCommand("select * from incomePayment", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            Dt.Load(sdr);
            con.Close();

          //  In.IncomeDataGrid.DataSource = Dt;
            //Ex.ExpensesDataGrid.DataSource = Dt;
        }

        public void GetParticularIncomePaymentRecode(cIncomeExpensesReport Report)
        {
            Dt.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM incomePayment WHERE YEAR (incomeDate) = @Year and MONTH (incomeDate) = @Month", con);
            // cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Year", Report.year);
            cmd.Parameters.AddWithValue("@Month", Report.month);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            Dt.Load(sdr);
            con.Close();

        //    Ex.ExpensesDataGrid.DataSource = Dt;
        }
    }
}
