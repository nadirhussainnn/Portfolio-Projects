using AlibabaDesktopApp.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AlibabaDesktopApp.Controller
{
    public class BankController
    {
        private BankModel model1;

        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        String connectionString;
        
        public BankController() { }
        
        public BankController(BankModel model1)
        {
            this.model1 = model1;
        }
        
        #region CreateBankAccount

        public Boolean CreateBankAccount() {

            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "INSERT into BankAccounts VALUES('" + model1.AccountNumber + "','" + model1.CNIC + "','" + model1.Email + "','" + model1.BankName + "','" + model1.FirstName + "','" + model1.LastName + "','" + model1.Balance + "')";
            int response = command.ExecuteNonQuery();
            if (response > 0) {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
        #endregion

        #region Return Balance of Partcular Account Number

        public int CheckAccountBalance(string accountNumber) {

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
                int balance = (int)row["balance"];
                return balance;
            }
            return 0;
        }
        #endregion

        #region Update Bank balance
        public void UpdateBankBalance(string AccountNumber, int newBalance)
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
    }
}