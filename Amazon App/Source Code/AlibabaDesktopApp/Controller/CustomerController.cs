using AlibabaDesktopApp.Model;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace AlibabaDesktopApp.Controller
{
    public class CustomerController
    {
        private CustomerModel customer;

        public CustomerController(){}

        public CustomerController(CustomerModel customer)
        {
            this.customer = customer;
        }


        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        String connectionString;

        #region Create Customer account

        public Boolean CreateCustomerAccount()
        {
            
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            MemoryStream ms = new MemoryStream();

            customer.ProfileImage.Save(ms, ImageFormat.Jpeg);
            byte[] photo_array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_array, 0, photo_array.Length);

            
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Customers";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);

            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };

            DataRow row = set.Tables[0].Rows.Find(customer.Email);

            if (row == null)
            {
                row = set.Tables[0].NewRow();
                row["email"] = customer.Email;
                row["password"] = customer.Password;
                row["firstName"] = customer.FirstName;
                row["lastName"] = customer.LastName;
                row["accountNumber"] = customer.AccountNumber;
                row["bankName"] = customer.BankName;
                row["image"] = photo_array;

                set.Tables[0].Rows.Add(row);
                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables[0]);
                return true;
            }
            return false;
        }
        #endregion

        #region Login To Customer Account

        public string LoginToCustomerAccount(string email, string password)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Customers WHERE email='" + email + "' AND password='" + password + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string account = reader.GetString(4);
                reader.Close();
                connection.Close();
                return account;
            }
            connection.Close();
            reader.Close();
            return "";
        }
        #endregion

        #region Check If Customer Already Exists
        public Boolean CustomerAlreadyExists(String email) 
        {    
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Customers WHERE email='"+email+"'";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                reader.Close();
                return true;
            }
            connection.Close();
            reader.Close();
            return false;
        }
        #endregion

        #region Verify Bank Details Provided by vendor or customer

        public Boolean VerifyBankAccount(String accountNumber)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM BankAccounts WHERE accountNumber='" + accountNumber + "'";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                reader.Close();
                return true;
            }
            connection.Close();
            reader.Close();
            return false;
        }
        #endregion

        #region Overload of verify bank Account

        public Boolean VerifyBankAccount(String accountNumber, string bankname)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM BankAccounts WHERE accountNumber='" + accountNumber + "' AND bankName='"+bankname+"'";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                reader.Close();
                return true;
            }
            connection.Close();
            reader.Close();
            return false;
        }

        #endregion

        #region Get Profile Pic of Customer
        public void GetProfilePic(string email, PictureBox profileImage)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Customers";
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

        #region Load Customer Profile data
       
        public void LoadCustomerProfile(String email, TextBox firstName, TextBox lastName, TextBox emai, TextBox password)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Customers";
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
            }
            connection.Close();
        }
        #endregion

        #region Update Customer Profile

        public void UpdateCustomerProfile(String email, string pass, string firstName, string lastName, Image profileImage)
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
            command.CommandText = "SELECT * FROM Customers";

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
                row["image"] = photo;

                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables[0]);
            }
        }
        #endregion

        #region Change Payment Method for customer

        public void UpdateCustomerBankDetails(string email, string newAccountNumber, string newBank)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Customers";
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

        #region Add Balance to account attached to Customer

        public void UpdateCustomerBankBalance(string AccountNumber, int newBalance)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM bankAccounts";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();

            adapter.Fill(set);

            connection.Close();

            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };

            DataRow row2 = set.Tables[0].Rows.Find(AccountNumber);

            if (row2 != null)
            {

                row2["balance"] = newBalance;
                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables[0]);

            }
        }
        #endregion

        #region DELETE Customer Profile

        public Boolean DeleteCustomerProfile(String email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "DELETE FROM Customers WHERE email='" + email + "'";
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

        #region Load customer's bankaccount Info

        public void LoadCustomerBankDetails(String accountNumber, TextBox accountNumField, TextBox cnic, TextBox balance, ComboBox bank)
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
                balance.Text = Convert.ToInt32(row["balance"]) + "";
            }
            connection.Close();
        }
        #endregion
    }
}