using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public partial class CustomerProfile : UserControl
    {
        public Image profileImage;
        public TextBox fName, lName, password, email;
        public CustomerController controller = new CustomerController();

        public string LoggedInCustomer { get; set; }

        public CustomerProfile()
        {
            InitializeComponent();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            fName = this.firstNameBox;
            lName = this.lastNameBox;
            password = this.passwordBox;
            email = this.emailBox;
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            CustomerView.productCardConatinerPanel.Visible = true;
            CustomerView.profile.Visible = false;
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(passwordBox.Text, firstNameBox.Text, lastNameBox.Text))
            {
                if (profileImage != null)
                {
                    controller.UpdateCustomerProfile(LoggedInCustomer, passwordBox.Text, firstNameBox.Text, lastNameBox.Text, profileImage);
                    LoggedInCustomer = emailBox.Text;
                    controller.GetProfilePic(emailBox.Text, CustomerView.profilePic);
                    MessageBox.Show("Profile Updated SUccessfully");
                }
                else
                {
                    MessageBox.Show("SELECT Profile Image Please");
                }
            }
            else
            {
                MessageBox.Show("All Fields Required!");
            }

        }

        private void deleteAccountBtn_Click_1(object sender, EventArgs e)
        {
            Boolean b = controller.DeleteCustomerProfile(LoggedInCustomer);
            if (b == true)
            {
                MessageBox.Show("Account Deleted Successfully!");
                CustomerView.profile.Visible = false;
                CustomerView.productCardConatinerPanel.Visible = true;
                MainWindow.logInRegisterWindow.Visible = true;
                MainWindow.customer.Visible = false;

            }
        }

        private void browseBtn_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG|*.png|JPEG|*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                profileImage = Image.FromFile(open.FileName);
            }

        }
    }
 }
