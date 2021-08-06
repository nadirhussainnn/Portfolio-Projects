using System;
using System.Drawing;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public partial class CustomerSignUpView : UserControl
    {
        public string firstName, lastName, email, password;
        public Image profileImage;

        public CustomerSignUpView()
        {
            InitializeComponent();
        }

        private void CustomerSignUpView_Load(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            firstName = this.firstNameBox.Text;
            lastName = this.lastNameBox.Text;
            email = this.emailBox.Text;
            password = this.passwordBox.Text;

            if (Validator.IsNotEmpty(firstName, lastName, email, password))
            {

                if (Validator.ValidateEmail(email))
                {
                    if (profileImage != null)
                    {
                        LoginRegisterView.account.Location = new Point((int)LocationOnForm.X, (int)LocationOnForm.Y);
                        CustomerController controller = new CustomerController();

                        if (controller.CustomerAlreadyExists(email) == false)
                        {
                            LoginRegisterView.account.Visible = true;
                            LoginRegisterView.vendor.Visible = false;
                            LoginRegisterView.customer.Visible = false;

                            //Send forward to bank account
                            LoginRegisterView.account.FirstName = firstName;
                            LoginRegisterView.account.LastName = lastName;
                            LoginRegisterView.account.Email = email;
                            LoginRegisterView.account.Password = password;
                            LoginRegisterView.account.ProfileImage = profileImage;
                            Validator.CleanUpAll(firstNameBox, lastNameBox, emailBox, passwordBox);
                            profileImage = null;

                        }
                        else
                        {

                            MessageBox.Show("Account Exists With This email!\nTry another one");
                            emailBox.Clear();
                        }
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

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Validator.CleanUpAll(this.firstNameBox, this.lastNameBox, this.emailBox, this.passwordBox);
            profileImage = null;

            LoginRegisterView.optionContainerPanel.Visible = true;
            LoginRegisterView.vendor.Visible = false;
            LoginRegisterView.customer.Visible = false;
            LoginRegisterView.account.Visible = false;

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
