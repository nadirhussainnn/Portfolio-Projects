using System;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AlibabaDesktopApp.View;

namespace AlibabaDesktopApp
{
    public partial class MainWindow : Form
    {
        static int progressValue = 0;

        public static AdminView admin = new AdminView();
        public static LoginRegisterView logInRegisterWindow = new LoginRegisterView();
        public static CustomerView customer = new CustomerView();
        public static VendorView vendor=new VendorView();
        public static CartItemsView cart = new CartItemsView();
        public static WishListItemsView wishList = new WishListItemsView();

        public MainWindow()
        {
            InitializeComponent();
            
            this.Controls.Add(admin);
            this.Controls.Add(logInRegisterWindow);
            this.Controls.Add(customer);
            this.Controls.Add(vendor);
            this.Controls.Add(cart);
            this.Controls.Add(wishList);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            admin.Visible = false;
            customer.Visible = false;
            vendor.Visible = false;
            cart.Visible = false;
            logInRegisterWindow.Visible = false;
            wishList.Visible = false;

            this.logoPic.Location = new Point(0-logoPic.Width,5);
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (logoPic.Location.X >= this.Width) {

                timer1.Stop();
                
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(250, 100);

                this.Width =885;
                this.Height =535+39;
                this.BackColor = Control.DefaultBackColor;

                logoPic.Visible = false;
                admin.Visible = false;
                customer.Visible = false;
                vendor.Visible = false;
                cart.Visible = false;
                logInRegisterWindow.Visible = true;
                wishList.Visible = false;
                
                return;
            }
            logoPic.Location=new Point(logoPic.Location.X+18, 5);
        }
    }
}