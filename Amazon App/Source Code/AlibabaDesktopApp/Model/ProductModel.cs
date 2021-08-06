using System.Drawing;

namespace AlibabaDesktopApp.Model
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Image ProductImage { get; set; }
        public string Category { get; set; }
        public string VendorEmail { get; set; }
        public string DateAdded { get; set; }

    }
}
