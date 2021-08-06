using AlibabaDesktopApp.Controller;
using AlibabaDesktopApp.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class AddProductView : UserControl
    {
        public string productName, productDescription;
        public int productPrice;

        public int quantity;
        public Image productImage;

        VendorController controller = new VendorController();

        public string Email { get; set; }
        public string AccountNumber { get; set; }
        public string Category { get; set; }


        public AddProductView()
        {
            InitializeComponent();
        }

        #region Import Product Image

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG|*.png|JPEG|*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                productImage = Image.FromFile(open.FileName);
            }
        }

        #endregion

        #region backToHomeBtn

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            VendorView.OptionContainer.Visible = true;
            VendorView.addProductControl.Visible = false;
        }

        private void AddProductView_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Browser For Pic

        private void browseBtnn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG|*.png|JPEG|*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                productImage = Image.FromFile(open.FileName);
            }
        }
        #endregion

        #region Confirm Button Clicked

        private void confirmBtn_Click_1(object sender, EventArgs e)
        {
            productName = this.productNameBox.Text;
            productDescription = this.descriptionBox.Text;
            if (Validator.IsNumber(this.priceBox.Text) && Validator.IsNumber(quantityBox.Text))
            {
                productPrice = Convert.ToInt32(this.priceBox.Text);
                quantity = Convert.ToInt32(this.quantityBox.Text);
                int totalBill = productPrice * quantity;

                if (Validator.IsNotEmpty(productName, productDescription))
                {
                    if (productImage != null)
                    {
                        BankController bank = new BankController();
                        int availableBalance = bank.CheckAccountBalance(AccountNumber);
                        if (totalBill < availableBalance)
                        {
                            ProductModel product = new ProductModel();
                            product.ProductName = productNameBox.Text;
                            product.Description = descriptionBox.Text;
                            product.Price = productPrice;
                            product.Quantity = quantity;
                            product.Category = Category;
                            product.VendorEmail = Email;
                            product.ProductImage = productImage;

                            DateTime d = DateTime.Today;
                            String day = d.Day.ToString();
                            String month = d.Month.ToString();
                            String year = d.Year.ToString();
                            String format = day + "/" + month + "/" + year;
                            product.DateAdded = format;

                            ProductController pController = new ProductController(product);
                            pController.AddNewProduct();
                            bank.UpdateBankBalance(AccountNumber, (availableBalance - totalBill));

                            MessageBox.Show("Added new product(s) Successfully");

                            Validator.CleanUpAll(productNameBox, descriptionBox, priceBox, quantityBox);
                            productImage = null;
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
        #endregion
    }
}
