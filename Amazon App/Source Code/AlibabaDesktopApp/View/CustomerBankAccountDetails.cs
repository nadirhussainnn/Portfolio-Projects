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
    public partial class CustomerBankAccountDetails : UserControl
    {

        CustomerController controller = new CustomerController();
        public TextBox cnicField, accountNumberField, balanceField;
        public ComboBox selectedbankField;
        Boolean isBankSelected = false;

        public string LoggedInCustomer { get; set; }

        public CustomerBankAccountDetails()
        {
            InitializeComponent();
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            CustomerView.bankAccountDetails.Visible = false;
            CustomerView.productCardConatinerPanel.Visible = true;
        }

        private void CustomerBankAccountDetails_Load(object sender, EventArgs e)
        {
            cnicField = cnicBox;
            accountNumberField = accountNumberBox;
            balanceField = balanceBox;
            selectedbankField = bankBox;
        }

        private void updateBtnn_Click(object sender, EventArgs e)
        {
            string bank = isBankSelected == true ? bankBox.SelectedItem.ToString() : "";
            if (Validator.IsNotEmpty(bank, accountNumberBox.Text, balanceBox.Text))
            {
                CustomerController c = new CustomerController();
                Boolean isValidBankAccount = c.VerifyBankAccount(accountNumberBox.Text, bank);

                if (isValidBankAccount)
                {
                    controller.UpdateCustomerBankDetails(LoggedInCustomer, accountNumberBox.Text, bank);
                    controller.UpdateCustomerBankBalance(accountNumberBox.Text, Convert.ToInt32(balanceBox.Text));
                    MessageBox.Show("Account Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Provided Bank Account Doesn't Exist!");
                }
            }
            else
            {
                MessageBox.Show("All Fields Required!");
            }

        }
        private void bankBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isBankSelected = true;
        }
    }
}