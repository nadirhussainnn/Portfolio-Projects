using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public partial class CartProductCardView : UserControl
    {

        public Label addedDate, productPrice;
        public PictureBox productPicture = new PictureBox();

        public  int ProductId { get; set; }
        
        public static string LoggedInCustomer { get; set; }
        public static string LoggedInCustomerAccount { get; set; }
        public static OrderController OrderControllerObject { get; set; }
       
        public CartProductCardView()
        {
            InitializeComponent();

            productPicture = this.productPic;
            addedDate = dateAddedLabel;
            productPrice = priceLabel;
        }

        private void CartProductCardView_Load(object sender, EventArgs e)
        {
        }

        private void purchaseBtn_Click_1(object sender, EventArgs e)
        {
            BankController bank = new BankController();

            int balance = bank.CheckAccountBalance(LoggedInCustomerAccount);
            int price = Convert.ToInt32(this.productPrice.Text.Substring(("Price Rs. ").Length, (this.productPrice.Text).Length - ("Price Rs. ").Length));

            if (balance > price)
            {

                MainWindow.customer.cartItems.Text = Convert.ToInt32(MainWindow.customer.cartItems.Text) - 1 + "";
                OrderController controller = new OrderController();

                int response = controller.AddToPurchaseList(ProductId, price, balance, LoggedInCustomer, LoggedInCustomerAccount);
                if (response > 0)
                {
                    CartItemsView.itemContainer.Controls.Remove(this);
                    MessageBox.Show("Great!\nYou made a purchase on Amazon\nRecent Balance is " + (balance - price));

                    //Add balance to vendor account and delete the bought product from database
                    ProductController productController = new ProductController();
                    string vendorEmail = productController.GetVendorEmail(ProductId);
                    VendorController vendorController = new VendorController();
                    string VendorAccountNumber = vendorController.GetVendorAccountNumber(vendorEmail);
                    int availableBalance = bank.CheckAccountBalance(VendorAccountNumber);
                    bank.UpdateBankBalance(VendorAccountNumber, availableBalance + price);
                    productController.DeleteProduct(ProductId);

                    SalesController sales = new SalesController();
                    sales.AddToSales(vendorEmail, price);

                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
            else
            {
                MessageBox.Show("Low Balance in Account!");
            }

        }

        private void removeFromcartBtn_Click_1(object sender, EventArgs e)
        {
            MainWindow.customer.cartItems.Text = Convert.ToInt32(MainWindow.customer.cartItems.Text) - 1 + "";

            OrderController controller = new OrderController();

            int response = controller.RemoveFromCart(ProductId, LoggedInCustomer);
            if (response > 0)
            {
                CartItemsView.itemContainer.Controls.Remove(this);
                return;
            }
            else
            {
                MessageBox.Show("Error Occured");

            }
        }
    }
}
