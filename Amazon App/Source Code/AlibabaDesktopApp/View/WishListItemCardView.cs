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
    public partial class WishListItemCardView : UserControl
    {
        public Label addedDate, productPrice;
        public PictureBox productPicture = new PictureBox();
        
        public int ProductId { get; set; }

        public static string LoggedInCustomer { get; set; }
        
        public WishListItemCardView()
        {
            InitializeComponent();
            productPicture = this.productPic;
            addedDate = dateAddedLabel;
            productPrice = priceLabel;
        }


        private void WishListItemCardView_Load(object sender, EventArgs e)
        {

        }


        private void removeFromcartBtn_Click_1(object sender, EventArgs e)
        {
            MainWindow.customer.wishListItems.Text = Convert.ToInt32(MainWindow.customer.wishListItems.Text) - 1 + "";

            OrderController controller = new OrderController();

            int response = controller.RemoveFromWishList(ProductId, LoggedInCustomer);
            if (response > 0)
            {
                WishListItemsView.itemContainer.Controls.Remove(this);
                return;
            }
            else
            {
                MessageBox.Show("Error Occured");

            }
        }

        private void addToCartBtn_Click_1(object sender, EventArgs e)
        {
            MainWindow.customer.cartItems.Text = Convert.ToInt32(MainWindow.customer.cartItems.Text) + 1 + "";

            OrderController controller = new OrderController();
            int response = controller.AddToCartFromWishLists(ProductId, LoggedInCustomer);
            if (response > 0)
            {
                WishListItemsView.itemContainer.Controls.Remove(this);
                MessageBox.Show("Added To cart Successfully");
                return;
            }
            else
            {
                MessageBox.Show("Error Occured");

            }
        }
    }
}
