using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public enum SideBarLocation
    {
        X=727, Y=100 ,WIDTH = 142, HEIGHT= 435
    }


    public partial class CustomerView : UserControl
    {

        CustomerController controller = new CustomerController();
        ProductController productController1 = new ProductController();
        
        public static CustomerProfile profile = new CustomerProfile();
        public static CustomerBankAccountDetails bankAccountDetails = new CustomerBankAccountDetails();
        public Label cartItems, wishListItems;
        public static Panel productCardConatinerPanel = new Panel();
        public static PictureBox profilePic = new PictureBox();
        
        public string Email { get; set; }
        public string AccountNumber { get; set; }

        public CustomerView()
        {
            InitializeComponent();
            profile.Location = new Point(161, 135);
            bankAccountDetails.Location = new Point(161, 135);
            
            this.Controls.Add(profile);
            this.Controls.Add(bankAccountDetails);
            
            profilePic = this.profileAvatar;
            productCardConatinerPanel = productCardContainer;
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            
            this.sideBar.Height = 0;
            this.sideBar.Location = new Point((int)SideBarLocation.X, (int)SideBarLocation.Y);
            
            cartItems = this.cartItemCounter;
            wishListItems = WishlistItemCounter;
            
            profile.Visible = false;
            bankAccountDetails.Visible = false;
            MainWindow.cart.Visible = false;
        }


        #region Three-Liner
        private void threeLiner_Click(object sender, EventArgs e)
        {

            if (this.sideBar.Height <= 0)
            {
                threeLiner.Width -= 10;
                threeLiner.Height -= 10;

                Animator.Start();
            }
            else if (this.sideBar.Height >= (int)SideBarLocation.HEIGHT)
            {
                threeLiner.Width += 10;
                threeLiner.Height += 10;

                Animator2.Start();
            }
        }

        #endregion

        #region Sidebar animation
        private void Animator_Tick(object sender, EventArgs e)
        {

            this.sideBar.Height += 15;

            if (this.sideBar.Height >= (int)SideBarLocation.HEIGHT)
            {
                Animator.Stop();
            }
        }

        private void Animator2_Tick(object sender, EventArgs e)
        {

            this.sideBar.Height -= 15;
            if (this.sideBar.Height <= 0)
            {
                Animator2.Stop();
            }
        }

        #endregion




        private void profileBtn_Click_1(object sender, EventArgs e)
        {
            controller.LoadCustomerProfile(Email, profile.fName, profile.lName, profile.email, profile.password);
            profile.Visible = true;

            profile.LoggedInCustomer = Email;
            productCardContainer.Visible = false;
            bankAccountDetails.Visible = false;
            MainWindow.cart.Visible = false;
        }

        private void bankAccountBtn_Click_1(object sender, EventArgs e)
        {
            controller.LoadCustomerBankDetails(AccountNumber, bankAccountDetails.accountNumberField, bankAccountDetails.cnicField, bankAccountDetails.balanceField, bankAccountDetails.selectedbankField);
            profile.Visible = false;
            bankAccountDetails.Visible = true;
            productCardConatinerPanel.Visible = false;
            bankAccountDetails.LoggedInCustomer = Email;

            MainWindow.cart.Visible = false;
        }

        #region Logout
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MainWindow.customer.Visible = false;
            MainWindow.logInRegisterWindow.Visible = true;
            MainWindow.cart.Visible = false;
            productCardContainer.Controls.Clear();
            
        }
        #endregion

        #region Visit Wishlist
        private void wishListBtn_Click(object sender, EventArgs e)
        {
            MainWindow.cart.Visible = false;
            MainWindow.customer.Visible = false;
            MainWindow.wishList.Visible = true;
            OrderController mywishList = new OrderController();
            mywishList.LoadWishListItems(Email);
            MainWindow.wishList.ShowWishListItems(mywishList);
        }
        #endregion

        #region Visit Cart Button
        private void amazonCartBtn_Click(object sender, EventArgs e)
        {
            MainWindow.cart.Visible = true;
            MainWindow.customer.Visible = false;
            OrderController myCart = new OrderController();
            myCart.LoadCartItems(Email);
            CartProductCardView.OrderControllerObject = myCart;
            MainWindow.cart.ShowCartItems(myCart);
        }
        #endregion

        private void booksBtn_Click_1(object sender, EventArgs e)
        {
            showProductCards("Books");
        }

        private void mobilesBtn_Click_1(object sender, EventArgs e)
        {
            showProductCards("Mobiles");
        }

        private void camerasBtn_Click_1(object sender, EventArgs e)
        {
            showProductCards("Cameras");
        }

        private void laptopsBtn_Click_1(object sender, EventArgs e)
        {
            showProductCards("Laptops");
        }


        #region Show ProductCards

        public void showProductCards(ProductController productController2)
        {
            this.productController1 = productController2;

            int counter = 1;
            int top = 20, left = 20;

            for (int i = 0; i < productController2.productCardList.Count; i++)
            {

                productController2.productCardList.ElementAt(i).Top = top;
                productController2.productCardList.ElementAt(i).Left = left;
                left += (int)CardBounds.WIDTH + 20;
                this.productCardContainer.Controls.Add(productController2.productCardList.ElementAt(i));
                counter++;
                if (counter % 4 == 0)
                {
                    top += (int)CardBounds.HEIGHT + 20;
                    left = 20;
                    counter = 1;
                }
            }
        }
        #endregion

        #region Show Product cards category wise

        public void showProductCards(string category)
        {

            productCardContainer.Controls.Clear();

            var query = from card in productController1.productCardList where card.Category == category select card;

            int counter = 1;
            int top = 20, left = 20;

            foreach (var card in query)
            {

                card.Top = top;
                card.Left = left;
                left += (int)CardBounds.WIDTH + 20;
                this.productCardContainer.Controls.Add(card);
                counter++;
                if (counter % 4 == 0)
                {
                    top += (int)CardBounds.HEIGHT + 20;
                    left = 20;
                    counter = 1;
                }
            }
        }
        #endregion
    }
}
