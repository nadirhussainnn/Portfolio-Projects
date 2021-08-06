using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlibabaDesktopApp.Model;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public partial class CreateBankAccountView : UserControl
    {
        #region Variables
        
        public string bank="", accountNumber, CNIC;
        Boolean selectedBank = false;
        
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Category { get; set; }
        public Image ProfileImage { get; set; }

        #endregion

        #region Default Constructor
        public CreateBankAccountView()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Load Event
        private void CreateBankAccountView_Load(object sender, EventArgs e)
        {
            this.createBankAccountContainer.Visible = false;
        }
        #endregion

        
        #region Select Bank when Already have account
        private void bankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBank = true;
        }
        #endregion

        #region Create bank account
        private void hereBtn_Click(object sender, EventArgs e)
        {
            this.createBankAccountContainer.Visible = true;
            this.accountNumberBox.Text = "";
            attachBankAccountContainer.Enabled = false;
            selectedBank = false;
        }
        #endregion
       
        #region Bank Selection
        private void bankBoxOnCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBank = true;
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            LoginRegisterView.account.Visible = false;
            LoginRegisterView.vendor.Visible = LoginRegisterView.isVendor == true ? true : false;
            LoginRegisterView.customer.Visible = LoginRegisterView.isCustomer == true ? true : false;

            Validator.CleanUpAll(this.accountNumberBox);
            this.bankComboBox.Text = "Select Bank";
        }

        private void confirmBtn_Click_1(object sender, EventArgs e)
        {
            bank = selectedBank == true ? this.bankComboBox.SelectedItem.ToString() : "";
            accountNumber = this.accountNumberBox.Text;
            if (Validator.IsNotEmpty(bank, accountNumber))
            {
                if (LoginRegisterView.isCustomer)
                {
                    CustomerModel customer = new CustomerModel();

                    customer.FirstName = FirstName;
                    customer.LastName = LastName;
                    customer.Email = Email;
                    customer.Password = Password;
                    customer.AccountNumber = accountNumber;
                    customer.BankName = bank;
                    customer.ProfileImage = ProfileImage;

                    CustomerController customerController = new CustomerController(customer);
                    Boolean bankVerified = customerController.VerifyBankAccount(accountNumber, bank);
                    if (bankVerified)
                    {
                        customerController.CreateCustomerAccount();
                        MessageBox.Show("Your account Created Successfully!\nMake your Shoppings on AMAZON");

                        LoginRegisterView.optionContainerPanel.Visible = true;
                        LoginRegisterView.customer.Visible = false;
                        LoginRegisterView.vendor.Visible = false;
                        LoginRegisterView.account.Visible = false;

                        LoginRegisterView.isCustomer = false;
                        Validator.CleanUpAll(accountNumberBox, cnicBox);

                    }
                    else
                    {
                        MessageBox.Show("Invalid Bank Account Provided");
                    }
                }
                else if (LoginRegisterView.isVendor)
                {

                    VendorModel vendor = new VendorModel();

                    vendor.FirstName = FirstName;
                    vendor.LastName = LastName;
                    vendor.Email = Email;
                    vendor.Password = Password;
                    vendor.AccountNumber = accountNumber;
                    vendor.BankName = bank;
                    vendor.Category = Category;
                    vendor.ProfileImage = ProfileImage;
                    vendor.RequestStatus = "Pending";

                    VendorController vendorController = new VendorController(vendor);
                    CustomerController customerController = new CustomerController();
                    Boolean bankVerified = customerController.VerifyBankAccount(accountNumber, bank);
                    if (bankVerified)
                    {
                        vendorController.CreateVendorAccount();
                        MessageBox.Show("Your Request Submitted for Review\nAdmin Will Let you know via EMAIL");
                        LoginRegisterView.optionContainerPanel.Visible = true;
                        LoginRegisterView.customer.Visible = false;
                        LoginRegisterView.vendor.Visible = false;
                        LoginRegisterView.account.Visible = false;

                        LoginRegisterView.isVendor = false;
                        Validator.CleanUpAll(accountNumberBox, cnicBox);

                    }
                    else
                    {
                        MessageBox.Show("Invalid bank Account Provided");
                    }
                }
            }
            else
            {
                MessageBox.Show("All Fields Required!");
            }

        }

        private void createBtn_Click_1(object sender, EventArgs e)
        {
            bank = selectedBank == true ? this.bankBoxOnCreate.SelectedItem.ToString() : "";
            CNIC = this.cnicBox.Text;
            if (Validator.IsNotEmpty(bank, CNIC))
            {
                if (Validator.ValidateCNIC(CNIC))
                {
                    BankModel model1 = new BankModel();

                    model1.FirstName = FirstName;
                    model1.LastName = LastName;
                    model1.Email = this.Email;
                    model1.CNIC = this.CNIC;
                    model1.Balance = 5000;      //Every New user receives Rs.5000
                    model1.BankName = this.bank;
                    model1.AccountNumber = (Banks.GenerateAccountNumber(this.bank));

                    if (model1.AccountNumber.Length != 0 && LoginRegisterView.isVendor)
                    {
                        BankController bankController = new BankController(model1);
                        Boolean bankAccountCreated = bankController.CreateBankAccount();

                        if (bankAccountCreated)
                        {
                            VendorModel vendor = new VendorModel();

                            vendor.FirstName = FirstName;
                            vendor.LastName = LastName;
                            vendor.Email = Email;
                            vendor.Password = Password;
                            vendor.AccountNumber = model1.AccountNumber;
                            vendor.BankName = bank;
                            vendor.Category = Category;
                            vendor.ProfileImage = ProfileImage;
                            vendor.RequestStatus = "Pending";

                            VendorController vendorController = new VendorController(vendor);
                            Boolean vendorAccountCreated = vendorController.CreateVendorAccount();

                            if (vendorAccountCreated)
                            {
                                MessageBox.Show("Your Request Submitted for Review\nAdmin Will Let you know via EMAIL");
                                LoginRegisterView.customer.Visible = false;
                                LoginRegisterView.vendor.Visible = false;
                                LoginRegisterView.account.Visible = false;

                                LoginRegisterView.optionContainerPanel.Visible = true;
                                LoginRegisterView.isVendor = false;

                                Validator.CleanUpAll(cnicBox);
                                this.bankBoxOnCreate.Text = "Select Bank";

                                attachBankAccountContainer.Enabled = true;
                                createBankAccountContainer.Visible = false;
                            }
                            else
                            {

                                MessageBox.Show("Vendor with this email already exists! Cancel and Try other email");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Error Occured in System! Try again");
                        }
                    }
                    else if (model1.AccountNumber.Length != 0 && LoginRegisterView.isCustomer)
                    {
                        BankController bankController = new BankController(model1);
                        Boolean bankAccountCreated = bankController.CreateBankAccount();

                        if (bankAccountCreated)
                        {
                            CustomerModel customer = new CustomerModel();

                            customer.FirstName = FirstName;
                            customer.LastName = LastName;
                            customer.Email = Email;
                            customer.Password = Password;
                            customer.AccountNumber = model1.AccountNumber;
                            customer.BankName = bank;
                            customer.ProfileImage = ProfileImage;

                            CustomerController customerController = new CustomerController(customer);
                            Boolean customerAccountCreated = customerController.CreateCustomerAccount();

                            if (customerAccountCreated)
                            {
                                MessageBox.Show("Account Created Successfully!\nFollowing are your credentials\nBank Name: " + bank + "\nAccount Number: " + model1.AccountNumber + "\nGift Balance: " + model1.Balance);
                                LoginRegisterView.customer.Visible = false;
                                LoginRegisterView.vendor.Visible = false;
                                LoginRegisterView.account.Visible = false;

                                LoginRegisterView.optionContainerPanel.Visible = true;
                                LoginRegisterView.isCustomer = false;

                                Validator.CleanUpAll(cnicBox);
                                this.bankBoxOnCreate.Text = "Select Bank";

                                attachBankAccountContainer.Enabled = true;
                                createBankAccountContainer.Visible = false;

                            }
                            else
                            {
                                MessageBox.Show("Customer with this email already exists! Cancel and Try other email");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Error Occured in System! Try again");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Couldn't Create Account! Try Again");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid CNIC Provided!");
                }
            }
            else
            {
                MessageBox.Show("All Fields Required!");
            }

        }

        private void cancelAndExitBtn_Click_1(object sender, EventArgs e)
        {
            LoginRegisterView.optionContainerPanel.Visible = true;
            LoginRegisterView.account.Visible = false;
            LoginRegisterView.vendor.Visible = false;
            LoginRegisterView.customer.Visible = false;

            Validator.CleanUpAll(this.cnicBox);
            this.bankComboBox.Text = "Select Bank";
            this.createBankAccountContainer.Visible = false;
            this.attachBankAccountContainer.Enabled = true;

        }
        #endregion

        #region Go to Main menu
        private void cancelAndExitBtn_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
