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
    public partial class VendorProfile : UserControl
    {
        public Image profileImage;
        public VendorController controller=new VendorController();

        public TextBox fName, lName, email, password;
        public ComboBox category;
        
        public string LoggedInVendor { get; set; }


        public VendorProfile()
        {
            InitializeComponent();
        }


        private void VendorProfile_Load(object sender, EventArgs e)
        {
            fName = firstNameBox;
            lName = lastNameBox;
            email = emailBox;
            password = passwordBox;
            category = categoryComboBox;
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            VendorView.OptionContainer.Visible = true;
            VendorView.profile.Visible = false;
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

        private void deleteAccountBtn_Click_1(object sender, EventArgs e)
        {
            Boolean b = controller.DeleteVendorProfile(LoggedInVendor);
            MessageBox.Show("Account Deleted Successfully!");
            VendorView.profile.Visible = false;
            VendorView.OptionContainer.Visible = true;
            MainWindow.logInRegisterWindow.Visible = true;
            MainWindow.vendor.Visible = false;

        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (Validator.ValidateEmail(emailBox.Text))
            {
                if (Validator.IsNotEmpty(emailBox.Text, passwordBox.Text, firstNameBox.Text, lastNameBox.Text))
                {
                    if (profileImage != null)
                    {
                        controller.UpdateVendorProfile(LoggedInVendor, passwordBox.Text, firstNameBox.Text, lastNameBox.Text, category.Text, profileImage);
                        LoggedInVendor = emailBox.Text;
                        controller.GetProfilePic(emailBox.Text, VendorView.profilePic);
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
            else
            {
                MessageBox.Show("Invalid Email Format");
            }
        }


    }
}
