using System;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public partial class CheckStockView : UserControl
    {

        public ListBox productListBox;
        public string LoggedInVendorEmail { get; set; }
        public string LoggedInVendorAccountNumber { get; set; }

        public CheckStockView()
        {
            InitializeComponent();
            productListBox = this.productList;
        }

        #region Back To Home btn

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            VendorView.checkStockControl.Visible = false;
            VendorView.OptionContainer.Visible = true;
            Validator.CleanUpAll(this.quantityBox,this.priceBox,this.descriptionBox);
            productImageBox.Image = null;
            productList.Items.Clear();

        }
        #endregion

        #region SelectedIndexChanged Event

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();

            this.quantityBox.Text = "" + productController.GetQuantity(productList.SelectedItem.ToString(), LoggedInVendorEmail);
            this.priceBox.Text = "" + productController.GetPrice(productList.SelectedItem.ToString(), LoggedInVendorEmail);
            this.descriptionBox.Text = productController.GetDescription(productList.SelectedItem.ToString(), LoggedInVendorEmail);
            productController.GetProductImage(productList.SelectedItem.ToString(), LoggedInVendorEmail, productImageBox);

        }
        #endregion
    }
}
