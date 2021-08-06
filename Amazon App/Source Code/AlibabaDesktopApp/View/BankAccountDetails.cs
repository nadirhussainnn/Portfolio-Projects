using AlibabaDesktopApp.Controller;
using System;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class BankAccountDetails : UserControl
    {
        public TextBox accountNumberField, cnicField, balanceField;
        public ComboBox bankSelected;

        public VendorController controller = new VendorController();
        public string LoggedInVendorAccountNumber { get; set; }
        public Boolean isBankSelected = false;

        public string LoggedinVendor { get; set; }

        public BankAccountDetails()
        {
            InitializeComponent();
        }

        private void BankAccountDetails_Load(object sender, EventArgs e)
        {
            accountNumberField = accountNumberBox;
            cnicField = cnicBox;
            balanceField = balanceBox;
            bankSelected = bankBox;
        }

        private void bankBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isBankSelected = true;
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            string bank = isBankSelected == true ? bankBox.SelectedItem.ToString() : "";
            if (Validator.IsNotEmpty(bank, accountNumberBox.Text, cnicBox.Text, balanceBox.Text))
            {
                if (Validator.ValidateCNIC(cnicBox.Text.Trim()))
                {
                    CustomerController c = new CustomerController();
                    Boolean isValidBankAccount = c.VerifyBankAccount(accountNumberBox.Text, bank);

                    if (isValidBankAccount)
                    {
                        controller.UpdateVendorBankDetails(LoggedinVendor, accountNumberBox.Text, bank);
                        BankController bankController = new BankController();
                        bankController.UpdateBankBalance(accountNumberBox.Text, Convert.ToInt32(balanceBox.Text));
                        MessageBox.Show("Account Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Provided Bank Account Doesn't Exist!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid CNIC or Balance provided!");
                }
            }
            else
            {
                MessageBox.Show("All Fields Required!");
            }
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            VendorView.OptionContainer.Visible = true;
            VendorView.bankAccountDetails.Visible = false;
        }
    }
}
