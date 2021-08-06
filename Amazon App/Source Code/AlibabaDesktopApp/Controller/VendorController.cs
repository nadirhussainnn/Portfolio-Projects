using AlibabaDesktopApp.Model;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace AlibabaDesktopApp.Controller
{
    public class VendorController
    {

        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        String connectionString;

        private VendorModel vendor;

        public VendorController(){}

        public VendorController(VendorModel vendor)
        {
            this.vendor = vendor;
        }

        #region Create Vendor account

        public Boolean CreateVendorAccount()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            MemoryStream ms = new MemoryStream();

            vendor.ProfileImage.Save(ms, ImageFormat.Jpeg);
            byte[] photo_array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_array, 0, photo_array.Length);

            //command.CommandText = "INSERT into vendors VALUES('" + vendor.Email + "','" + vendor.Password + "','" + vendor.FirstName + "','" + vendor.LastName + "','"+vendor.Category+"','" + vendor.AccountNumber + "','" + vendor.BankName + "','"+vendor.RequestStatus+"','" + photo_array + "')";

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Vendors";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);

            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };

            DataRow row = set.Tables[0].Rows.Find(vendor.Email);

            if (row == null)
            {
                row = set.Tables[0].NewRow();
                row["email"] = vendor.Email;
                row["password"] = vendor.Password;
                row["firstName"] = vendor.FirstName;
                row["lastName"] = vendor.LastName;
                row["category"] = vendor.Category;
                row["accountNumber"] = vendor.AccountNumber;
                row["bankName"] = vendor.BankName;
                row["requestStatus"] = vendor.RequestStatus;
                row["image"] = photo_array;

                set.Tables[0].Rows.Add(row);
                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables[0]);
                return true;
            }
            return false;
        }
        #endregion

        #region Login To Vendor Account

        public string[] LoginToVendorAccount(string email, string password)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Vendors WHERE email='" + email + "' AND password='" + password + "' AND requestStatus='"+"Approved"+"'";
            
            SqlDataReader reader = command.ExecuteReader();
            string[] details = new string[2];

            if (reader.Read())
            {
                string category = reader.GetString(4);
                string account = reader.GetString(5);
                details[0] = category;
                details[1] = account;

                reader.Close();
                connection.Close();
                return details;
            }
            connection.Close();
            reader.Close();
            details[0] = "";
            details[1] = "";
            return details;
        }
        #endregion

        #region Get Profile Pic of Vendor
        public void GetProfilePic(string email, PictureBox profileImage)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Vendors";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);

            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };

            DataRow row = set.Tables[0].Rows.Find(email);

            if (row != null)
            {
                byte[] photo = (byte[])row["image"];
                MemoryStream stream = new MemoryStream(photo);
                profileImage.Image = Image.FromStream(stream);
            }
        }
        #endregion

        #region Load Emails of All Vendors
        public void LoadEmailsOfAllVendors(ComboBox vendors)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT email FROM Vendors";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) {

                while (reader.Read()) {
                    vendors.Items.Add(reader.GetString(0));
                }
            }
            connection.Close();
            reader.Close();
        }
        #endregion

        #region DELETE Vendor Profile

        public Boolean DeleteVendorProfile(String email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "DELETE FROM Vendors WHERE email='" + email + "'";
            int response = command.ExecuteNonQuery();

            if (response > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
        #endregion

        #region Return vendor bank account Number

        public string GetVendorAccountNumber(String email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT AccountNumber From Vendors Where email='"+email+"'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) {

                reader.Read();
                return reader.GetString(0);
            }
            return "";
        }
        #endregion

        #region Load Vendor Profile data 

        public void LoadVendorProfile(String email, TextBox firstName, TextBox lastName, TextBox emai, TextBox password, ComboBox category)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Vendors";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);

            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };

            DataRow row = set.Tables[0].Rows.Find(email);

            if (row != null)
            {
                emai.Text = (string)row[0];
                password.Text = (string)row[1];
                firstName.Text = (string)row[2];
                lastName.Text = (string)row[3];
                category.Text = (string)row[4];
                
            }
            connection.Close();
        }
        #endregion

        #region Load Vednor's bankaccount Info

        public void LoadVendorBankDetails(String accountNumber, TextBox accountNumField, TextBox cnic, TextBox balance, ComboBox bank)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM BankAccounts";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);

            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };

            DataRow row = set.Tables[0].Rows.Find(accountNumber);

            if (row != null)
            {
                accountNumField.Text = (string)row["accountNumber"];
                cnic.Text = (string)row["cnic"];
                bank.Text = (string)row["bankName"];
                balance.Text = Convert.ToInt32(row["balance"])+"";
            }
            connection.Close();
        }
        #endregion

        #region Update Vendors Profile

        public void UpdateVendorProfile(String email, string pass, string firstName, string lastName, string category, Image profileImage)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            MemoryStream st = new MemoryStream();

            profileImage.Save(st, ImageFormat.Jpeg);
            byte[] photo = new byte[st.Length];
            st.Position = 0;
            st.Read(photo, 0, photo.Length);

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Vendors";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            adapter.Fill(set);

            connection.Close();
            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };
            DataRow row = set.Tables[0].Rows.Find(email);

            if (row != null)
            {
                row[0] = email;
                row[1] = pass;
                row[2] = firstName;
                row[3] = lastName;
                row["category"] = category;
                row["image"] = photo;

                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables[0]);
            }
        }
        #endregion

        #region Change Payment Method for vendor

        public void UpdateVendorBankDetails(string email, string newAccountNumber, string newBank)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Vendors";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            
            adapter.Fill(set);
            connection.Close();

            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };
 
            DataRow row = set.Tables[0].Rows.Find(email);

            if (row != null)
            {
                row["accountNumber"] = newAccountNumber;
                row["bankName"] = newBank;
                
                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables[0]);
            }
        }
        #endregion

    }
}
