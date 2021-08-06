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
    public partial class CartItemsView : UserControl
    {
        
        public static Panel itemContainer;
        public string Email { get; set; }
        public string AccountNumber { get; set; }

        public CartItemsView()
        {
            InitializeComponent();
            itemContainer = cartItemContainer;
        }

        private void CartItemsView_Load(object sender, EventArgs e)
        {
            itemContainer = cartItemContainer;
        }

        private void backTohome_Click(object sender, EventArgs e)
        {
            MainWindow.cart.Visible = false;
            MainWindow.customer.Visible = true;
            cartItemContainer.Controls.Clear();
        }

        public void ShowCartItems(OrderController order)
        {
            int left = 20, top=20;
            for(int i = 0; i < order.CartItemsList.Count; i++)
            {
                order.CartItemsList.ElementAt(i).Left = left;
                order.CartItemsList.ElementAt(i).Top = top;
                left += order.CartItemsList.ElementAt(i).Width+10;

                this.cartItemContainer.Controls.Add(order.CartItemsList.ElementAt(i));
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
