using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagment.Model
{
    class validation
    {

        public static Boolean isEmpty(TextBox box)
        {


            if (string.IsNullOrWhiteSpace(box.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static Boolean validateTp(TextBox tp)
        {
            isEmpty(tp);
            Regex regTp = new Regex(@"^\d{10}$");
            if (!regTp.IsMatch(tp.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Boolean isAlphabatic(TextBox text)
        {
            Regex regText = new Regex(@"^[a-zA-Z ]*$");
            if (!regText.IsMatch(text.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Boolean ValidateEmail(TextBox txtEmail)

        {
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                    + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                    + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                    + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                    + @"[a-zA-Z]{2,}))$",
                                    RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtEmail.Text))
            {

                return false;
            }
            else
            {
                return true;
            }
        }



    }
}
