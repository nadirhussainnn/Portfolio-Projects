using AlibabaDesktopApp.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class VendorView : UserControl
    {
        #region Variables, properties and global objects

        public static PictureBox profilePic = new PictureBox();
        public static VendorProfile profile = new VendorProfile();
        public static BankAccountDetails bankAccountDetails = new BankAccountDetails();
        
        public static AddProductView addProductControl = new AddProductView();
        public static RemoveProductView removeProductControl = new RemoveProductView();
        public static EditProductView editProductControl = new EditProductView();
        public static CheckMonthlySalesView checkMonthlySalesControl = new CheckMonthlySalesView();
        public static CheckStockView checkStockControl = new CheckStockView();
        public static ContactAdminView contactAdmin = new ContactAdminView();

        public static Panel OptionContainer = new Panel();

        public string Email { get; set; }
        public string AccountNumber { get; set; }
        public string Category { get; set; }

        #endregion

        #region Default Constructor

        public VendorView()
        {
            InitializeComponent();

            profile.Location = new Point(228,135);
            bankAccountDetails.Location = new Point(228, 135);

            addProductControl.Location = new Point(228,135);
            removeProductControl.Location = new Point(170, 135);
            editProductControl.Location = new Point(170, 135);
            checkMonthlySalesControl.Location = new Point(170, 135);
            checkStockControl.Location = new Point(170, 135);
            contactAdmin.Location = new Point(170,135);

            this.Controls.Add(profile);
            this.Controls.Add(bankAccountDetails);

            this.Controls.Add(addProductControl);
            this.Controls.Add(removeProductControl);
            this.Controls.Add(editProductControl);
            this.Controls.Add(checkMonthlySalesControl);
            this.Controls.Add(checkStockControl);
            this.Controls.Add(contactAdmin);

            OptionContainer = optionContainer;
            profilePic = this.profileAvatar;

        }
        #endregion

        #region LoadEvent

        private void VendorView_Load(object sender, EventArgs e)
        {
            this.sideBar.Width = 0;
            this.optionContainer.Location = new Point(151, this.optionContainer.Location.Y);

            profilePic.Visible = false;

            profile.Visible = false;
            bankAccountDetails.Visible = false;

            addProductControl.Visible = false;
            removeProductControl.Visible = false;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = false;
            contactAdmin.Visible = false;
        }
        #endregion

        #region Three-Liner
        private void threeLiner_Click(object sender, EventArgs e)
        {
            if (this.sideBar.Width <= 0)
            {
                threeLiner.Width -= 10;
                threeLiner.Height -= 10;
                Animator.Start();
            }
            else if (this.sideBar.Width >= 151)
            {
                threeLiner.Width += 10;
                threeLiner.Height += 10;
                Animator2.Start();
            }
        }
        #endregion
        #region SideBarAnimation
        private void Animator_Tick(object sender, EventArgs e)
        {
            this.sideBar.Width += 2;
            this.optionContainer.Location = new Point(optionContainer.Location.X + 1, this.optionContainer.Location.Y);

            if (this.sideBar.Width >= 151)
            {
                profilePic.Visible = true;
                Animator.Stop();
            }
        }
        private void Animator2_Tick(object sender, EventArgs e)
        {
            this.sideBar.Width -= 2;
            this.optionContainer.Location = new Point(optionContainer.Location.X - 1, this.optionContainer.Location.Y);

            if (this.sideBar.Width <= 0)
            {
                profilePic.Visible = false;
                Animator2.Stop();
            }
        }
        #endregion

        #region Logout Button
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            profile.Visible = false;
            bankAccountDetails.Visible = false;
            LoginRegisterView.vendor.Visible = false;
            MainWindow.logInRegisterWindow.Visible = true;

            this.optionContainer.Location = new Point(151, this.optionContainer.Location.Y);
            
            OptionContainer.Visible = true;
            sideBar.Width = 0;
            threeLiner.Width += 10;
            threeLiner.Height += 10;

            addProductControl.Visible = false;
            removeProductControl.Visible = false;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = false;
            contactAdmin.Visible = false;
        }
        #endregion

        #region CheckStock

        private void checkStockBtn_Click(object sender, EventArgs e)
        {

            OptionContainer.Visible = false;
            profile.Visible = false;
            bankAccountDetails.Visible = false;
            addProductControl.Visible = false;
            removeProductControl.Visible = false;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = true;
            contactAdmin.Visible = false;

            checkStockControl.productListBox.Items.Clear();
            checkStockControl.LoggedInVendorAccountNumber = AccountNumber;
            checkStockControl.LoggedInVendorEmail = Email;

            ProductController productController = new ProductController();
            productController.GetAllProductsOfVendor(Email, checkStockControl.productListBox);

        }
        #endregion

        #region Check Monthly Sales

        private void checkMonthlySalesBtn_Click(object sender, EventArgs e)
        {
            OptionContainer.Visible = false;
            profile.Visible = false;
            
            bankAccountDetails.Visible = false;
            addProductControl.Visible = false;
            removeProductControl.Visible = false;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = true;
            checkStockControl.Visible = false;
            contactAdmin.Visible = false;

            SalesController sales = new SalesController();
            sales.PopulateChartWithThisMonthsSales(checkMonthlySalesControl.salesChart,Email);

        }
        #endregion

        
        #region Add Product To Stock
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            OptionContainer.Visible = false;
            profile.Visible = false;
            bankAccountDetails.Visible = false;
            addProductControl.Visible = true;
            removeProductControl.Visible = false;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = false;
            contactAdmin.Visible = false;

            addProductControl.Email = Email;
            addProductControl.Category = Category;
            addProductControl.AccountNumber = AccountNumber;
        }
        #endregion

        #region Remove Product

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            OptionContainer.Visible = false;
            profile.Visible = false;
            bankAccountDetails.Visible = false;
            addProductControl.Visible = false;
            removeProductControl.Visible = true;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = false;
            contactAdmin.Visible = false;

            removeProductControl.productListBox.Items.Clear();
            removeProductControl.LoggedInVendorAccountNumber = AccountNumber;
            removeProductControl.LoggedInVendorEmail = Email;

            ProductController productController = new ProductController();
            productController.GetAllProductsOfVendor(Email, removeProductControl.productListBox);

        }
        #endregion

        #region Edit Product

        private void editProductBtn_Click(object sender, EventArgs e)
        {
            OptionContainer.Visible = false;
            profile.Visible = false;
            bankAccountDetails.Visible = false;
            
            addProductControl.Visible = false;
            removeProductControl.Visible = false;
            editProductControl.Visible = true;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = false;
            contactAdmin.Visible = false;

            editProductControl.productListBox.Items.Clear();
            editProductControl.LoggedInvendorAccountNumber = AccountNumber;
            editProductControl.LoggedInVendorEmail = Email;
            editProductControl.Category = Category;
            ProductController productController = new ProductController();
            productController.GetAllProductsOfVendor(Email,editProductControl.productListBox);                
        }
        #endregion

        #region Exit Button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void contactAdminBtn_Click(object sender, EventArgs e)
        {
            OptionContainer.Visible = false;
            profile.Visible = false;
            bankAccountDetails.Visible = false;

            addProductControl.Visible = false;
            removeProductControl.Visible = false;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = false;
            contactAdmin.Visible = true;

            AdminController v = new AdminController();
            v.LoadEmailsOfAllAdmins(contactAdmin.admins);

        }

        private void profileBtn_Click_1(object sender, EventArgs e)
        {
            VendorController controller = new VendorController();
            controller.LoadVendorProfile(Email, profile.fName, profile.lName, profile.email, profile.password, profile.category);
            profile.Visible = true;

            profile.LoggedInVendor = Email;
            OptionContainer.Visible = false;

            addProductControl.Visible = false;
            removeProductControl.Visible = false;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = false;
            contactAdmin.Visible = false;
        }

        private void bankAccountBtn_Click_1(object sender, EventArgs e)
        {
            VendorController controller = new VendorController();
            controller.LoadVendorBankDetails(AccountNumber, bankAccountDetails.accountNumberField, bankAccountDetails.cnicField, bankAccountDetails.balanceField, bankAccountDetails.bankSelected);

            profile.Visible = false;
            bankAccountDetails.Visible = true;
            OptionContainer.Visible = false;
            bankAccountDetails.LoggedinVendor = Email;

            addProductControl.Visible = false;
            removeProductControl.Visible = false;
            editProductControl.Visible = false;
            checkMonthlySalesControl.Visible = false;
            checkStockControl.Visible = false;
            contactAdmin.Visible = false;
        }
    }
}
