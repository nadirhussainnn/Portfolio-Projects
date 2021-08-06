using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_System
{
    public partial class UnParkCar : UserControl
    {
        public UnParkCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G40JEGJ;Initial Catalog=Parking_DB;Integrated Security=True;");
            
            if (textBox1.Text.Length == 0){

                MessageBox.Show("This Field is required");
                return;
            }

            
            String query = "Delete From Cars Where Token="+Int64.Parse(textBox1.Text);
            SqlCommand com = new SqlCommand(query, connection);
            connection.Open();
            com.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Un Parked Car");
            textBox1.Text = "";
        }
    }
}
