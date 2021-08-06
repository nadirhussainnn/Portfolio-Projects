using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
 
    public partial class VendorSignUpView : UserControl
    {
        public string firstName, lastName, email, password, category;
        public Image profileImage;
        Boolean selectedCategory = false;
        
        public VendorSignUpView()
        {
            InitializeComponent();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = true;
        }

        private void browseBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                profileImage = Image.FromFile(open.FileName);
            }
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {

            LoginRegisterView.optionContainerPanel.Visible = true;
            LoginRegisterView.vendor.Visible = false;
            LoginRegisterView.customer.Visible = false;
            LoginRegisterView.account.Visible = false;

            Validator.CleanUpAll(this.firstNameBox, this.lastNameBox, this.emailBox, this.passwordBox);
            categoryComboBox.Text = "SELECT category";
            profileImage = null;


        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            firstName = this.firstNameBox.Text;
            lastName = this.lastNameBox.Text;
            email = this.emailBox.Text;
            password = this.passwordBox.Text;
            category = selectedCategory == true ? this.categoryComboBox.SelectedItem.ToString() : "";


            if (Validator.IsNotEmpty(firstName, lastName, email, password, category))
            {

                if (Validator.ValidateEmail(email))
                {
                    if (profileImage != null)
                    {
                        LoginRegisterView.account.Location = new Point((int)LocationOnForm.X, (int)LocationOnForm.Y);

                        LoginRegisterView.account.Visible = true;
                        LoginRegisterView.vendor.Visible = false;
                        LoginRegisterView.customer.Visible = false;

                        //Send forward to bank account
                        LoginRegisterView.account.FirstName = firstName;
                        LoginRegisterView.account.LastName = lastName;
                        LoginRegisterView.account.Email = email;
                        LoginRegisterView.account.Password = password;
                        LoginRegisterView.account.Category = category;
                        LoginRegisterView.account.ProfileImage = profileImage;

                        Validator.CleanUpAll(firstNameBox, lastNameBox, emailBox, passwordBox);

                        this.categoryComboBox.Text = "Category";
                        selectedCategory = false;
                        profileImage = null;

                    }
                    else
                    {
                        MessageBox.Show("Select Profile Image Please..");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email Address Provided!");
                }
            }
            else
            {
                MessageBox.Show("All Fields are required!");
            }

        }

        private void VendorSignUpView_Load(object sender, EventArgs e)
        {
        }
    }
}
