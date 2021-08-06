using AlibabaDesktopApp.Model;
using AlibabaDesktopApp.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace AlibabaDesktopApp.Controller
{
    public class OrderController
    {
        private OrderModel order;

        public List<CartProductCardView> CartItemsList= new List<CartProductCardView>();
        public List<WishListItemCardView> wishListItemsList = new List<WishListItemCardView>();

        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        String connectionString;

        public OrderController() { }
        public OrderController(OrderModel order)
        {
            this.order = order;
        }

        #region Place Order
        public Boolean PlaceOrder()
        {
            
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            MemoryStream ms = new MemoryStream();
            order.ProductImage.Save(ms, ImageFormat.Jpeg);
            byte[] photo = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo, 0, photo.Length);

            command.Connection = connection;
            
            command.CommandText = "SELECT * FROM Orders";
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet set = new DataSet();
            adapter.Fill(set);
            connection.Close();
            int before = set.Tables[0].Rows.Count;
            
            DataRow record = set.Tables[0].NewRow();

            record["Price"] = order.Price;
            record["placedBy"] = order.PlacedBy;
            record["status"] = order.Status;
            record["productId"] = order.ProductId;
            record["dateAddedToCart"] = order.DateAddedToCart;
            record["datePurchased"] = order.DatePurchased;
            record["productImage"] = photo;

            set.Tables[0].Rows.Add(record);

            SqlCommandBuilder build = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables[0]);

            int after = set.Tables[0].Rows.Count;

            if (after > before)
                return true;

            return false;
        }
        #endregion

        #region Place Order
        public Boolean LoadAllBuyers(string email, DataGridView grid)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            MemoryStream ms = new MemoryStream();
            order.ProductImage.Save(ms, ImageFormat.Jpeg);
            byte[] photo = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo, 0, photo.Length);

            command.Connection = connection;

            command.CommandText = "SELECT * FROM Orders WHERE ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet set = new DataSet();
            adapter.Fill(set);
            connection.Close();
            int before = set.Tables[0].Rows.Count;

            DataRow record = set.Tables[0].NewRow();

            record["Price"] = order.Price;
            record["placedBy"] = order.PlacedBy;
            record["status"] = order.Status;
            record["productId"] = order.ProductId;
            record["dateAddedToCart"] = order.DateAddedToCart;
            record["datePurchased"] = order.DatePurchased;
            record["productImage"] = photo;

            set.Tables[0].Rows.Add(record);

            SqlCommandBuilder build = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables[0]);

            int after = set.Tables[0].Rows.Count;

            if (after > before)
                return true;

            return false;
        }
        #endregion

        #region Number of carted items
        public int GetNumberOfProductsAddedToCart(string email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Orders WHERE Status='" + "AddedToCart" + "' AND PlacedBy='" + email + "'";
            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set);

            connection.Close();
            if (set.Tables[0].Rows.Count > 0)
            {
                return set.Tables[0].Rows.Count;
            }
            return 0;
        }
        #endregion

        #region Number of WishList items
        public int GetNumberOfProductsAddedToWishList(string email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Orders WHERE Status='" + "WishListed" + "' AND PlacedBy='" + email + "'";
            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set);

            connection.Close();
            if (set.Tables[0].Rows.Count > 0)
            {
                return set.Tables[0].Rows.Count;
            }
            return 0;
        }
        #endregion

        #region Show Monthly Sales of Vendor

        public void ShowMonthlySalesOfVendor(string email, DataGridView grid)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT firstName, lastName,email, category, bankName, requestStatus FROM Vendors WHERE requestStatus='" + "Pending" + "'";

            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set, "PendingRequests");
            connection.Close();
            grid.DataSource = set.Tables["PendingRequests"];

        }
        #endregion

        #region All Cart Items of loggedIn Customer
        
        public void LoadCartItems(string email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Orders WHERE status='"+"AddedTocart"+"' AND PlacedBy='"+email+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            DataSet set = new DataSet();
            adapter.Fill(set);

            connection.Close();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                DataRow row = set.Tables[0].Rows[i];
                
                
                    CartProductCardView card = new CartProductCardView();
                    
                    byte[] photo = (byte[])row["productImage"];
                    MemoryStream stream = new MemoryStream(photo);

                    card.productPicture.Image = Image.FromStream(stream);
                    card.productPrice.Text = "Price Rs. " + (int)row["price"];
                    card.addedDate.Text = (string)row["dateAddedtocart"];
                    card.ProductId = (int)row["productId"];
                    CartItemsList.Add(card);
            }
        }
        #endregion

        #region All WishList Items of loggedIn Customer

        public void LoadWishListItems(string email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Orders WHERE status='" + "WishListed" + "' AND PlacedBy='" + email + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet set = new DataSet();
            adapter.Fill(set);

            connection.Close();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                DataRow row = set.Tables[0].Rows[i];


                WishListItemCardView card = new WishListItemCardView();

                card.ProductId = (int)row["productId"];
                byte[] photo = (byte[])row["productImage"];
                MemoryStream stream = new MemoryStream(photo);

                card.productPicture.Image = Image.FromStream(stream);
                card.productPrice.Text = "Price Rs." + (int)row["price"];
                card.addedDate.Text = (string)row["dateAddedtocart"];
                wishListItemsList.Add(card);
            }
        }
        #endregion

        #region Add To cart From WishList
        public int AddToCartFromWishLists(int productId, string email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();
            
            DateTime d = DateTime.Today;
            String day = d.Day.ToString();
            String month = d.Month.ToString();
            String year = d.Year.ToString();
            String dateAddedToCart = day + "/" + month + "/" + year;

            command.Connection = connection;
            command.CommandText = "Update Orders Set status='" + "AddedTocart" + "', DateAddedToCart='"+dateAddedToCart+ "'WHERE ProductId='" + productId + "' AND placedBy='"+email+"'";

            int response=command.ExecuteNonQuery();
            connection.Close();
            return response;
        }
        #endregion

        #region Remove From WishList
        public int RemoveFromWishList(int productId, string email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "DELETE FROM orders WHERE ProductId='" + productId + "' AND PlacedBy='"+email+"'";
            int response = command.ExecuteNonQuery();
            connection.Close();
            return response;
        }
        #endregion

        #region Remove From Cart
        public int RemoveFromCart(int productId, string email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "DELETE FROM orders WHERE ProductId='" + productId + "' AND PlacedBy='" + email + "'";
            int response = command.ExecuteNonQuery();
            connection.Close();
            return response;
        }
        #endregion

        #region Remove From WishList
        public int AddToPurchaseList(int productId, int price, int balance, string email, string accountNumber)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();
            string purchased = "Purchased";

            DateTime d = DateTime.Today;
            String day = d.Day.ToString();
            String month = d.Month.ToString();
            String year = d.Year.ToString();
            String datePurchased = day + "/" + month + "/" + year;

            command.Connection = connection;
            
            command.CommandText = "UPDATE Orders SET status='"+purchased+"', DatePurchased='"+ datePurchased + "' WHERE placedBy='" + email + "' AND productId='"+productId+"'";
            int response = command.ExecuteNonQuery();
            
            command.CommandText = "UPDATE BankAccounts SET balance='" + (balance-price )+ "' WHERE AccountNumber='" + accountNumber+ "'";
            response = command.ExecuteNonQuery();
            connection.Close();

            return response;
            
        }
        #endregion
    }
}
