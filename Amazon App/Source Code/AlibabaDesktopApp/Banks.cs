using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaDesktopApp
{
    
    public class Banks
    {
        public static string GenerateAccountNumber(String BankName) {
            
            String code="";
            int random;
            Random rand = new Random();

            if (BankName.Equals("Allied Bank Limited")){
                code = "ABLS";              //Branch Code---4 Digit, Other---9 Digits
                for(int i = 0; i < 9; i++)
                {
                    random = rand.Next(0, 10);
                    code += random;
                }
            }
            else if (BankName.Equals("Bank-Al-Habib"))
            {
                code = "BALS";
                for (int i = 0; i < 13; i++)
                {
                    random = rand.Next(0, 10);
                    code += random;
                }
            }
            else if (BankName.Equals("Muslim Commercial Bank"))
            {
                code = "";
                for (int i = 0; i < 16; i++)
                {
                    random = rand.Next(0, 10);
                    code += random;
                }
            }
            else if (BankName.Equals("National Bank of Pakistan"))
            {
                code = "NBPS";
                for (int i = 0; i < 8; i++)
                {
                    random = rand.Next(0, 10);
                    code += random;
                }
            }
            else if (BankName.Equals("United Bank Limited"))
            {
                code = "UBLS";
                for (int i = 0; i < 8; i++)
                {
                    random = rand.Next(0, 10);
                    code += random;
                }
            }

            String query = "SELECT * FROM Banks WHERE AccountNumber='"+code+"'";
        return code;
        }
    }
}
