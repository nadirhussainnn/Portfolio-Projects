using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlibabaDesktopApp.Model
{
    public class VendorModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string Category { get; set; }
        public string RequestStatus { get; set; }
        public Image ProfileImage { get; set; }
    }
}
