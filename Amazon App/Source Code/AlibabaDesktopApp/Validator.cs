using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AlibabaDesktopApp
{
    public class Validator
    {
        #region ValidateEmail method
        public static Boolean ValidateEmail(String email)
        {
            String pattern = @"^[A-Za-z0-9]+[_.-]*[A-Za-z0-9]+@[A-Za-z0-9]+(.com)$";
            Regex reg = new Regex(pattern);
            Match match = reg.Match(email);

            if (match.Success)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region IsNotEmpty method
        public static Boolean IsNotEmpty(params String[] values)
        {
            foreach(String value in values)
            {
                if (value.Length == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region ValidateCNIN
        public static Boolean ValidateCNIC(String CNIC)
        {
            String pattern = @"^\d{5}-\d{7}-\d{1}$";
            Regex reg = new Regex(pattern);
            Match match = reg.Match(CNIC);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Validate Price and Numeric Data
        public static Boolean IsNumber(String value) {

            
            String pattern = @"^[0-9]+$";
            Regex reg = new Regex(pattern);
            Match match = reg.Match(value.Trim());

            if (match.Success) {
                return true;
            }
            return false;
        }
        #endregion

        #region CleanUpAll Fields
        public static void CleanUpAll(params TextBox[] box) { 
        
            for(int i = 0; i < box.Length; i++)
            {
                box[i].Clear();
            }
        }
        #endregion
    }
}
