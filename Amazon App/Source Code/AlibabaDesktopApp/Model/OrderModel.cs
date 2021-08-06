using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaDesktopApp.Model
{
    public class OrderModel
    {
        public int ProductId { get; set; }
        public string PlacedBy { get; set; }
        public string AccountNumber { get; set; }
        public string Status { get; set; }
        public string DateAddedToCart { get; set; }
        public string DatePurchased { get; set; }
        public int Price { get; set; }
        public Image ProductImage { get; set; }
    }
}
