using AlibabaDesktopApp.Controller;
using AlibabaDesktopApp.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class EditProductView : UserControl
    {

        public ProductController productController;
        public Image productImage;

        public ListBox productListBox;
        public int amountAlreadyInvested, newUpdatedAmmount, alreadyStoredQuantity;

        public string LoggedInVendorEmail { get; set; }
        public string LoggedInvendorAccountNumber { get; set; }
        public string Category { get; set; }

        public EditProductView()
        {
            InitializeComponent();
            productListBox = this.productList;
        }

        private void browseBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG|*.png|JPEG|*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                this.productImageBox.Image = Image.FromFile(open.FileName);
                productImage = Image.FromFile(open.FileName);
            }
        }

        #region Update Product
        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (productList.Items.Count > 0 && productList.SelectedItem != null)
            {
                int net = alreadyStoredQuantity * amountAlreadyInvested;

                if (Validator.IsNumber(this.priceBox.Text) && Validator.IsNumber(quantityBox.Text))
                {
                    int productPrice = Convert.ToInt32(this.priceBox.Text);
                    int quantity = Convert.ToInt32(this.quantityBox.Text);
                    int totalBill = (productPrice * quantity) - net;

                    if (Validator.IsNotEmpty(priceBox.Text, quantityBox.Text, descriptionBox.Text))
                    {
                        if (productImage != null)
                        {
                            BankController c = new BankController();
                            int availableBalance = c.CheckAccountBalance(LoggedInvendorAccountNumber);

                            if (totalBill < availableBalance)
                            {

                                ProductModel product = new ProductModel();


                                product.ProductName = this.productList.SelectedItem.ToString();
                                product.Description = descriptionBox.Text;
                                product.Price = productPrice;
                                product.Quantity = quantity;
                                product.Category = Category;
                                product.VendorEmail = LoggedInVendorEmail;
                                product.ProductImage = productImage;

                                DateTime d = DateTime.Today;
                                String day = d.Day.ToString();
                                String month = d.Month.ToString();
                                String year = d.Year.ToString();
                                String format = day + "/" + month + "/" + year;
                                product.DateAdded = format;

                                ProductController pController = new ProductController(product);
                                pController.DeleteProduct(productList.SelectedItem.ToString());
                                pController.AddNewProduct();
                                MessageBox.Show("Product Updated Successfully!");
                                c.UpdateBankBalance(LoggedInvendorAccountNumber, availableBalance - totalBill);
                                productList.Items.Clear();
                                pController.GetAllProductsOfVendor(LoggedInVendorEmail, productList);

                            }
                            else
                            {
                                MessageBox.Show("Sorry! Can't Add\n" + availableBalance + " Is Your Available Balance");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Select Product Image");
                        }
                    }
                    else
                    {
                        MessageBox.Show("All Fields required");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Price or quantity Input!");
                }
            }
            else
            {
                MessageBox.Show("No Product Selected");
            }
        }
        #endregion

        #region Back To Home

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            VendorView.editProductControl.Visible = false;
            VendorView.OptionContainer.Visible = true;
        }
        #endregion

        #region SelectedIndexChanged listener

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();

            alreadyStoredQuantity = productController.GetQuantity(productList.SelectedItem.ToString(), LoggedInVendorEmail);
            this.quantityBox.Text = "" + alreadyStoredQuantity;
            amountAlreadyInvested = productController.GetPrice(productList.SelectedItem.ToString(), LoggedInVendorEmail);
            this.priceBox.Text = "" + amountAlreadyInvested;
            this.descriptionBox.Text = productController.GetDescription(productList.SelectedItem.ToString(), LoggedInVendorEmail);

            productController.GetProductImage(productList.SelectedItem.ToString(), LoggedInVendorEmail, productImageBox);
        }
        #endregion
    }
}
