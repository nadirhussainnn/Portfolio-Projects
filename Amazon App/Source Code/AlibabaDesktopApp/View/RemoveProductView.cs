using AlibabaDesktopApp.Controller;
using System;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class RemoveProductView : UserControl
    {

        public ListBox productListBox;
        public string LoggedInVendorEmail { get; set; }
        public string LoggedInVendorAccountNumber { get; set; }

        public RemoveProductView()
        {
            InitializeComponent();
            productListBox = this.productList;
        }

        #region Back To Home
        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            VendorView.removeProductControl.Visible = false;
            VendorView.OptionContainer.Visible = true;
            Validator.CleanUpAll(this.quantityBox, this.priceBox, this.descriptionBox);
            this.productImageBox.Image = null;
        }
        #endregion

        #region SelectedIndexChanged
        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();

            this.quantityBox.Text = "" + productController.GetQuantity(productList.SelectedItem.ToString(), LoggedInVendorEmail);
            this.priceBox.Text = "" + productController.GetPrice(productList.SelectedItem.ToString(), LoggedInVendorEmail);
            this.descriptionBox.Text = productController.GetDescription(productList.SelectedItem.ToString(), LoggedInVendorEmail);
            productController.GetProductImage(productList.SelectedItem.ToString(), LoggedInVendorEmail, productImageBox);

        }
        #endregion

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController pController = new ProductController();
                pController.DeleteProduct(productList.SelectedItem.ToString());
                BankController bank = new BankController();
                int availableBalance = bank.CheckAccountBalance(LoggedInVendorAccountNumber);

                int productPrice = Convert.ToInt32(this.priceBox.Text);
                int quantity = Convert.ToInt32(this.quantityBox.Text);
                int totalBill = (productPrice * quantity);

                bank.UpdateBankBalance(LoggedInVendorAccountNumber, availableBalance + totalBill);
                productList.Items.Clear();
                pController.GetAllProductsOfVendor(LoggedInVendorEmail, productList);

                Validator.CleanUpAll(this.quantityBox, this.priceBox, this.descriptionBox);
                productImageBox.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Product Selected!");
            }

        }
    }
}
