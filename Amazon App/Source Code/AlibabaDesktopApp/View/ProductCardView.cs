using System;
using System.Drawing;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;
using AlibabaDesktopApp.Model;

namespace AlibabaDesktopApp.View
{
    
    public partial class ProductCardView : UserControl
    {
        public Label productName, productPrice, productDetails;
        public PictureBox productPicture=new PictureBox();
        
        public int ProductId { get; set; }
        public string Category { get; set; }
        public string ProductOwnerEmail { get; set; }
        public int Price { get; set; }
        public Image ProductImage { get; set; }

        public static string LoggedInCustomerEmail { get; set; }
        public static string LoggedInCustomerAccountNumber { get; set; }

        public ProductCardView()
        {
            InitializeComponent();
            productPicture = this.productPic;
            productName = this.prodName;
            productDetails = this.prodDetails;
            productPrice = this.prodPrice;
        }

        #region Add To Wishlist Btn
        
        private void addtoWishListBtn_Click_1(object sender, EventArgs e)
        {
            MainWindow.customer.wishListItems.Text = Convert.ToInt32(MainWindow.customer.wishListItems.Text) + 1 + "";
            OrderModel order = new OrderModel();

            DateTime d = DateTime.Today;
            String day = d.Day.ToString();
            String month = d.Month.ToString();
            String year = d.Year.ToString();
            String format = day + "/" + month + "/" + year;

            order.ProductId = ProductId;
            order.PlacedBy = LoggedInCustomerEmail;
            order.Status = "WishListed";
            order.DateAddedToCart = format;
            order.DatePurchased = "Not Purchased Yet";
            order.AccountNumber = LoggedInCustomerAccountNumber;
            order.Price = Price;
            order.ProductImage = ProductImage;

            OrderController controller = new OrderController(order);
            Boolean addedToWishList = controller.PlaceOrder();
            if (addedToWishList)
            {
                MessageBox.Show("Product Added To WishList");
            }
            else
            {
                MessageBox.Show("Errro Encounterd! Try again");
            }
        }

        private void addToCartBtn_Click_1(object sender, EventArgs e)
        {
            MainWindow.customer.cartItems.Text = Convert.ToInt32(MainWindow.customer.cartItems.Text) + 1 + "";

            OrderModel order = new OrderModel();

            DateTime d = DateTime.Today;
            String day = d.Day.ToString();
            String month = d.Month.ToString();
            String year = d.Year.ToString();
            String format = day + "/" + month + "/" + year;

            order.ProductId = ProductId;
            order.PlacedBy = LoggedInCustomerEmail;
            order.Status = "AddedToCart";
            order.DateAddedToCart = format;
            order.DatePurchased = "Not Purchased Yet";
            order.AccountNumber = LoggedInCustomerAccountNumber;
            order.Price = Price;
            order.ProductImage = ProductImage;

            OrderController controller = new OrderController(order);
            Boolean addedToCart = controller.PlaceOrder();
            if (addedToCart)
            {
                MessageBox.Show("Product Added To cart");
            }
            else
            {
                MessageBox.Show("Errro Encounterd! Try again");
            }
        }
        #endregion

        #region On form Load 
        private void ProductCardView_Load(object sender, EventArgs e)
        {

        }

        #endregion
        
    }
}