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
    public class AdminController
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        String connectionString;

        #region Admin Login

        public Boolean LoginToAdminAccount(string email, string password)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Admin WHERE email='" + email + "' AND password='"+password+"'";
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

        #region Pending Vendors

        public void LoadAllPendingRequests(DataGridView grid) {

            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT firstName, lastName,email, category, bankName, requestStatus FROM Vendors WHERE requestStatus='" + "Pending" + "'";

            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set,"PendingRequests");
            connection.Close();

            grid.DataSource = set.Tables["PendingRequests"];
        }
        #endregion

        #region get Approved Vendors

        public void LoadAllApprovesRequests(DataGridView grid)
        {

            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT firstName, lastName,email, category, bankName, requestStatus FROM Vendors WHERE requestStatus='" + "Approved" + "'";

            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set, "ApprovedRequests");
            connection.Close();

            grid.DataSource = set.Tables["ApprovedRequests"];
        }
        #endregion


        #region get Rejected Vendors

        public void LoadAllRejectedRequests(DataGridView grid)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT firstName, lastName,email, category, bankName, requestStatus FROM Vendors WHERE requestStatus='" + "Rejected" + "'";

            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set, "RejectedRequests");
            connection.Close();

            grid.DataSource = set.Tables["RejectedRequests"];
        }
        #endregion

        #region All Vendors

        public void LoadAllVendors(DataGridView grid)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT firstName, lastName,email, category, bankName, requestStatus FROM Vendors";

            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set, "AllVendors");
            connection.Close();

            grid.DataSource = set.Tables["AllVendors"];
        }
        #endregion

        #region Approve Or Reject Vendor

        public void ApproveOrRejectVendors(String choice, string email, DataGridView grid) 
        {    
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();
            
            command.Connection = connection;
            if (choice.Equals("Approve All")) {
                command.CommandText = "UPDATE Vendors set requestStatus='" + "Approved" + "'";
            }
            else if (choice.Equals("Approve Selected")) {
                command.CommandText = "UPDATE Vendors set requestStatus='" + "Approved" + "' WHERE email='"+email+"'";
            }
            else if (choice.Equals("Reject All")) {
                command.CommandText = "UPDATE Vendors set requestStatus='" + "Rejected" + "'";
            }
            else if (choice.Equals("Reject Selected")) {
                command.CommandText = "UPDATE Vendors set requestStatus='" + "Rejected" + "' WHERE email='" + email + "'";
            }

            command.ExecuteNonQuery();
            command.CommandText = "SELECT firstName, lastName,email, category, bankName, requestStatus FROM Vendors WHERE requestStatus='" + "Pending" + "'";
            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set, "PendingRequests");
            connection.Close();

            grid.DataSource = set.Tables["PendingRequests"];
        }
        #endregion

        #region Remove Vendor

        public void RemoveVendor(String choice, string email, DataGridView grid)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            if (choice.Equals("All"))
            {
                command.CommandText = "DELETE FROM Vendors";
            }
            else if (choice.Equals("Selected"))
            {
                command.CommandText = "DELETE FROM Vendors WHERE email='" + email + "'";
            }

            command.ExecuteNonQuery();
            command.CommandText = "SELECT firstName, lastName,email, category, bankName, requestStatus FROM Vendors";
            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(set, "AllVendors");
            connection.Close();

            grid.DataSource = set.Tables["AllVendors"];
        }
        #endregion

        #region Load Admin Profile data 

        public void LoadAdminProfile(String email, TextBox firstName, TextBox lastName, TextBox emai, TextBox password)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM Admin WHERE email='"+email+"'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                firstName.Text = reader.GetString(2);
                lastName.Text = reader.GetString(3);
                emai.Text = reader.GetString(0);
                password.Text = reader.GetString(1);
            }
            connection.Close();
            reader.Close();
        }
        #endregion

        #region Delete Admin Profile

        public Boolean DeleteAdminProfile(String email)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "DELETE FROM Admin WHERE email='" + email + "'";
            int response=command.ExecuteNonQuery();

            if (response > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
        #endregion

        #region Update Admin Profile

        public void UpdateAdminProfile(String email, string pass, string firstName, string lastName,Image profileImage)
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
            command.CommandText = "SELECT * FROM Admin";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            adapter.Fill(set);

            connection.Close();
            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0]};
            DataRow row = set.Tables[0].Rows.Find(email);

            if (row != null)
            {
                row[0] = email;
                row[1] = pass;
                row[2] = firstName;
                row[3] = lastName;
                row[4] = photo;

                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables[0]);
            }
        }
        #endregion

        #region Get Admin Profile Pic

        public  void GetProfilePic(string email, PictureBox profileImage)
        {
         
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Admin";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();

            DataSet set = new DataSet();
            adapter.Fill(set);

            set.Tables[0].PrimaryKey = new DataColumn[] { set.Tables[0].Columns[0] };

            DataRow row = set.Tables[0].Rows.Find(email);

            if (row != null) {
                byte[] photo = (byte[])row[4];
                MemoryStream stream = new MemoryStream(photo);
                profileImage.Image = Image.FromStream(stream);
            }
        }
        #endregion

        #region Load Emails of All admin Accounts
        public void LoadEmailsOfAllAdmins(ComboBox admins)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT email FROM Admin";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    admins.Items.Add(reader.GetString(0));
                }
            }
            connection.Close();
            reader.Close();
        }
        #endregion
    }
}