using AlibabaDesktopApp.Controller;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class WishListItemsView : UserControl
    {

        public static Panel itemContainer;

        public string Email { get; set; }
        public string AccountNumber { get; set; }

        public WishListItemsView()
        {
            InitializeComponent();
            itemContainer = cartItemContainer;
        }

        private void WishListItemsView_Load(object sender, EventArgs e)
        {
            itemContainer = cartItemContainer;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backTohome_Click(object sender, EventArgs e)
        {
            
            MainWindow.wishList.Visible = false;
            MainWindow.customer.Visible = true;
            cartItemContainer.Controls.Clear();

        }

        public void ShowWishListItems(OrderController order)
        {
            int left = 20, top = 20;

            for (int i = 0; i < order.wishListItemsList.Count; i++)
            {
                order.wishListItemsList.ElementAt(i).Left = left;
                order.wishListItemsList.ElementAt(i).Top = top;
                left += order.wishListItemsList.ElementAt(i).Width + 10;

                this.cartItemContainer.Controls.Add(order.wishListItemsList.ElementAt(i));
            }
        }

    }
}
