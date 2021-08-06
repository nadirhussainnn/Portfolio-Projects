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
    public partial class ParkNewCar : UserControl
    {
        public ParkNewCar()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G40JEGJ;Initial Catalog=Parking_DB;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {

            if (Car_Type.Text.Length == 0 || reg.Text.Length == 0 || model.Text.Length==0 || chalan.Text.Length == 0) {

                MessageBox.Show("All Fields are required");
                return;
            }
            
            DateTime day = DateTime.UtcNow.Date;
            
            String query ="Insert Into Cars(Type,Model, Reg_No,Chalan,Parked_date) Values(@Type,@Model,@Reg_No,@Chalan,@Parked_date)";
            SqlCommand com = new SqlCommand(query,connection);
            com.CommandType = CommandType.Text;
            
            com.Parameters.AddWithValue("@Type",Car_Type.Text);
            com.Parameters.AddWithValue("@Model", reg.Text);
            com.Parameters.AddWithValue("@Reg_No", model.Text);
            com.Parameters.AddWithValue("@Chalan", chalan.Text);
            com.Parameters.AddWithValue("@Parked_date",day);
            
            
            connection.Open();
            com.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Parked The Car");
            Car_Type.Text = "";
            reg.Text = "";
            model.Text = "";
            chalan.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
