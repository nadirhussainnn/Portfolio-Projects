using System;
using System.Drawing;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public enum LocationOnForm
    { 
        X=228,Y=135
    }

    public partial class LoginRegisterView : UserControl
    {
        public String email, password;
        public static Panel optionContainerPanel=new Panel();
        public static Boolean isVendor = false;
        public static Boolean isCustomer = false;

        public static VendorSignUpView vendor = new VendorSignUpView();
        public static CustomerSignUpView customer = new CustomerSignUpView();
        public static CreateBankAccountView account = new CreateBankAccountView();
        
        public LoginRegisterView()
        {
            InitializeComponent();

            optionContainerPanel = this.optionContainer;
            this.Controls.Add(vendor);
            this.Controls.Add(customer);
            this.Controls.Add(account);
        }


        private void LoginRegisterView_Load_1(object sender, EventArgs e)
        {

            this.sideBar.Width = 0;
            vendor.Visible = false;
            customer.Visible = false;
            account.Visible = false;
        }

        #region Three-Liner
        private void threeLiner_Click(object sender, EventArgs e)
        {
            if (this.sideBar.Width <= 0)
            {
                threeLiner.Width -= 10;
                threeLiner.Height -= 10;
                Animator.Start();
            }
            else if (this.sideBar.Width >= 195)
            {
                threeLiner.Width += 10;
                threeLiner.Height += 10;
                Animator2.Start();
            }
        }
        #endregion
        #region Sidebar Animation
        private void Animator_Tick(object sender, EventArgs e)
        {
            this.sideBar.Width += 7;
            
            if (this.sideBar.Width >= 195)
            {
                Animator.Stop();
            }
        }

        private void Animator2_Tick(object sender, EventArgs e)
        {

            this.sideBar.Width -= 8;

            if (this.sideBar.Width <= 0)
            {
                Animator2.Stop();
            }
        }
        #endregion
        #region Exit Button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        
        private void vendorLoginBtn_Click_1(object sender, EventArgs e)
        {
            email = this.emailBox.Text;
            password = this.passwordBox.Text;

            if (Validator.IsNotEmpty(email, password))
            {
                Boolean isValid = Validator.ValidateEmail(email); ;
                if (isValid)
                {
                    VendorController vendorController = new VendorController();
                    string[] details = vendorController.LoginToVendorAccount(email, password);
                    if (details[0].Length > 0)
                    {
                        MainWindow.logInRegisterWindow.Visible = false;
                        MainWindow.admin.Visible = false;
                        MainWindow.customer.Visible = false;
                        MainWindow.vendor.Visible = true;
                        MainWindow.vendor.Email = email;
                        MainWindow.vendor.Category = details[0];
                        MainWindow.vendor.AccountNumber = details[1];

                        vendorController.GetProfilePic(email, VendorView.profilePic);

                        Validator.CleanUpAll(this.emailBox, this.passwordBox);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials! Or Request Not Approved Yet");
                    }
                }
                else
                {
                    MessageBox.Show("InValid Email Address");
                }
            }
            else
            {
                MessageBox.Show("All Fields Required!");
            }
        }

        private void buyerLoginBtn_Click_1(object sender, EventArgs e)
        {

            email = this.emailBox.Text;
            password = this.passwordBox.Text;

            if (Validator.IsNotEmpty(email, password))
            {
                Boolean isValid = Validator.ValidateEmail(email);
                if (isValid)
                {
                    CustomerController customerController = new CustomerController();
                    string account = customerController.LoginToCustomerAccount(email, password);
                    if (account.Length > 0)
                    {
                        MainWindow.logInRegisterWindow.Visible = false;
                        MainWindow.admin.Visible = false;
                        MainWindow.customer.Visible = true;
                        MainWindow.vendor.Visible = false;
                        MainWindow.customer.Email = email;
                        MainWindow.customer.AccountNumber = account;

                        ProductCardView.LoggedInCustomerAccountNumber = account;
                        ProductCardView.LoggedInCustomerEmail = email;
                        WishListItemCardView.LoggedInCustomer = email;
                        CartProductCardView.LoggedInCustomer = email;
                        CartProductCardView.LoggedInCustomerAccount = account;

                        customerController.GetProfilePic(email, CustomerView.profilePic);
                        ProductController productController = new ProductController();
                        productController.LoadAllAvailableProducts();

                        OrderController orderController = new OrderController();

                        MainWindow.customer.cartItems.Text = "" + orderController.GetNumberOfProductsAddedToCart(email);
                        MainWindow.customer.wishListItems.Text = "" + orderController.GetNumberOfProductsAddedToWishList(email);

                        MainWindow.customer.showProductCards(productController);

                        Validator.CleanUpAll(this.emailBox, this.passwordBox);

                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials! Try Again");
                    }
                }
                else
                {
                    MessageBox.Show("InValid Email Address");
                }
            }
            else
            {
                MessageBox.Show("All Fields Required!");
            }
        }

        private void vendorSignUpBtn_Click_1(object sender, EventArgs e)
        {
            isVendor = true;
            vendor.Location = new Point((int)LocationOnForm.X, (int)LocationOnForm.Y);

            vendor.Visible = true;
            customer.Visible = false;
            account.Visible = false;
            optionContainerPanel.Visible = false;

            Validator.CleanUpAll(this.emailBox, this.passwordBox);

        }

        private void buyerSignUpBtn_Click_1(object sender, EventArgs e)
        {
            isCustomer = true;
            customer.Location = new Point((int)LocationOnForm.X, (int)LocationOnForm.Y);
            vendor.Visible = false;
            customer.Visible = true;
            account.Visible = false;
            optionContainerPanel.Visible = false;

            Validator.CleanUpAll(this.emailBox, this.passwordBox);
        }

        private void adminLoginBtn_Click_1(object sender, EventArgs e)
        {
            email = this.emailBox.Text;
            password = this.passwordBox.Text;

            if (Validator.IsNotEmpty(email, password))
            {
                Boolean isValid = Validator.ValidateEmail(email);
                if (isValid)
                {
                    AdminController adminController = new AdminController();
                    Boolean response = adminController.LoginToAdminAccount(email, password);
                    if (response == true)
                    {
                        MainWindow.logInRegisterWindow.Visible = false;
                        MainWindow.admin.Visible = true;
                        MainWindow.admin.Email = email;
                        MainWindow.customer.Visible = false;
                        MainWindow.vendor.Visible = false;
                        AdminController c = new AdminController();
                        c.GetProfilePic(email, AdminView.profilePic);

                        Validator.CleanUpAll(this.emailBox, this.passwordBox);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials! Try Again");
                    }
                }
                else
                {
                    MessageBox.Show("InValid Email Address");
                }
            }
            else
            {
                MessageBox.Show("All Fields Required!");
            }
        }

    }
}
