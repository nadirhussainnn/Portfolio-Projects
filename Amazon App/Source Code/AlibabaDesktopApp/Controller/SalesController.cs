using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace AlibabaDesktopApp.Controller
{
    public class SalesController
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        String connectionString;

        #region Add Product To Sales Table

        public Boolean AddToSales(string vendorEmail, int price)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "INSERT into Sales VALUES('" + vendorEmail + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + price + "')";
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

        #region Get Monthly Sales into Chart

        public void PopulateChartWithThisMonthsSales(Chart salesChart, string vendorEmail)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AmazonDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT SUM(Price),Day(DateSold) FROM sales where vendorEmail='" + vendorEmail + "' AND Month(DateSold)='"+DateTime.Now.Month+"'  GROUP BY DateSold";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                    while (reader.Read())
                    {
                        salesChart.Series["Sales"].Points.AddXY(reader.GetInt32(1), reader.GetInt32(0));
                    }
            }
            reader.Close();
            connection.Close();
        }
        #endregion
    }
}