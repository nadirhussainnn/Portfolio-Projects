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

    public enum CardBounds
    {
        X = 20, Y = 20, WIDTH = 155, HEIGHT = 252, X_INC = 175, Y_INC = 272
    }

    public class ProductController
    {
        private ProductModel product;
        public List<ProductCardView> productCardList = new List<ProductCardView>();

        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        String connectionString;

        public ProductController() { }

        public ProductController(ProductModel product)
        {
            this.product = product;
        }

        #region Add new Product
        public void AddNewProduct()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            MemoryStream ms = new MemoryStream();

            product.ProductImage.Save(ms, ImageFormat.Jpeg);
            byte[] photo_array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_array, 0, photo_array.Length);

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Products";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);

            for (int i = 0; i < product.Quantity; i++)
            {
                DataRow row = set.Tables[0].NewRow();
                row["productName"] = product.ProductName;
                row["description"] = product.Description;
                row["category"] = product.Category;
                row["price"] = product.Price;
                row["vendorEmail"] = product.VendorEmail;
                row["productImage"] = photo_array;
                row["dateAdded"] = product.DateAdded;

                set.Tables[0].Rows.Add(row);
            }
            SqlCommandBuilder build = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables[0]);
        }
        #endregion

        #region All Load Products
        public void LoadAllAvailableProducts()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Products";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);


            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                ProductCardView card = new ProductCardView();

                DataRow row = set.Tables[0].Rows[i];

                byte[] photo = (byte[])row["productImage"];
                MemoryStream stream = new MemoryStream(photo);

                card.productPicture.Image = Image.FromStream(stream);
                card.productPrice.Text = "Price Rs. " + (int)row["price"];
                card.productName.Text = (string)row["productName"];
                card.productDetails.Text = (string)row["description"];

                card.ProductId = (int)row["productId"];
                card.Category = (string)row["category"];
                card.ProductOwnerEmail = (string)row["vendorEmail"];
                card.Price = (int)row["price"];
                card.ProductImage = Image.FromStream(stream);
                productCardList.Add(card);
            }

        }
        #endregion

        #region Delete Product
        public void DeleteProduct(string productName)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Products WHERE productName='" + productName + "'";
            command.ExecuteNonQuery();
            connection.Close();

        }
        #endregion

        #region Delete Product By Id, Overload

        public void DeleteProduct(int productId)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Products WHERE productId='" + productId + "'";
            command.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region Populate ListBox by products 

        public void GetAllProductsOfVendor(string Email, ListBox list)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT Distinct productName FROM Products WHERE vendorEmail='" + Email + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Items.Add(reader.GetString(0));
                }
            }
            reader.Close();
            connection.Close();
 
        }
        #endregion

        #region Get Quantity of particular product
        public int GetQuantity(string prodName,string Email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Products WHERE vendorEmail='" + Email + "' AND productName='"+prodName+"'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                int totalProds = reader.GetInt32(0);
                connection.Close();
                reader.Close();
                return totalProds;

            }
            connection.Close();
            reader.Close();
            return 0;
        }
        #endregion

        #region Get Price of particular product
        public int GetPrice(string prodName, string Email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT price FROM Products WHERE vendorEmail='" + Email + "' AND productName='" + prodName + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                int price = reader.GetInt32(0);
                reader.Close();
                connection.Close();
                return price;
            }
            connection.Close();
            reader.Close();
            return 0;
        }
        #endregion

        #region Get Description of particular product
        public string GetDescription(string prodName, string Email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT Description FROM Products WHERE vendorEmail='" + Email + "' AND productName='" + prodName + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string desc = reader.GetString(0);
                reader.Close();
                connection.Close();
                return desc;

            }
            connection.Close();
            reader.Close();
            return "";
        }
        #endregion

        #region Get Image of particular product
        public void GetProductImage(string productName,string email, PictureBox pic)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT productImage FROM Products WHERE productName='"+productName+"' AND vendorEmail='"+email+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);

            if (set.Tables[0].Rows.Count > 0)
            {
                DataRow row = set.Tables[0].Rows[0];

                byte[] photo = (byte[])row["productImage"];
                MemoryStream stream = new MemoryStream(photo);
                pic.Image = Image.FromStream(stream);
             }
        }
        #endregion

        #region Get Vendor Email
        public string GetVendorEmail(int productId)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT VendorEmail FROM Products WHERE productId='" + productId + "'";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string email= reader.GetString(0);
                connection.Close();
                reader.Close();
                return email;
            }
            connection.Close();
            reader.Close();
            return "";
        }
        #endregion
    }
}