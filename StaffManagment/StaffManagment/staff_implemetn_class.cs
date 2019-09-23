using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagment
{
    class staff_implemetn_class
    {


        StaffManagment st = new StaffManagment();

        //database Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3Q3PSFQ;Initial Catalog=School_Managment_System;Integrated Security=True");



        public DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();

        //Insert quary

        public void addstaffdetails(staff staffManagment) {

            String query = "INSERT INTO Staff_Mang_Table(NIC,title,fname,lname,gender,tpno,email,address1,address2,address3,qualification,accountType,password,startdate,profilepic) VALUES (@NIC, @title, @fname, @lname, @gender, @tpno, @email, @address1, @address2, @address3, @qualification, @accountType, @password, @startdate, @profilepic)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {




              //  cmd.CommandType = CommandType.Text;

                staff s1 = new staff();
                cmd.Parameters.AddWithValue("@NIC", s1.NIC);
                cmd.Parameters.AddWithValue("@title", s1.TITLE);
                cmd.Parameters.AddWithValue("@fname", s1.FirstName);
                cmd.Parameters.AddWithValue("@lname", s1.LastName);
                cmd.Parameters.AddWithValue("@gender", s1.GENDER);
                cmd.Parameters.AddWithValue("@tpno", s1.TPNO);
                cmd.Parameters.AddWithValue("@email", s1.EMAIL);
                cmd.Parameters.AddWithValue("@address1", s1.ADDRESS1);
                cmd.Parameters.AddWithValue("@address2", s1.ADDRESS2);
                cmd.Parameters.AddWithValue("@address3", s1.ADDRESS3);
                cmd.Parameters.AddWithValue("@qualification", s1.QUALIFICATION);
                cmd.Parameters.AddWithValue("@accountType", s1.ATYPE);
                cmd.Parameters.AddWithValue("@password", s1.PSW);
                cmd.Parameters.AddWithValue("@startdate", s1.SDATE);
                cmd.Parameters.AddWithValue("@profilepic", s1.IMG);

                Console.WriteLine(s1.ADDRESS1 + s1.FirstName);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            

        }

    }
}
