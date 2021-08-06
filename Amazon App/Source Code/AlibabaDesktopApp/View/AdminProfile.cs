using System;
using System.Drawing;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public partial class AdminProfile : UserControl
    {
        AdminController controller = new AdminController();

        public Image profileImage;
        public TextBox fname, lname, Email, Pass;
        
        public string LoggedInAdmin { get; set; }

        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            fname = this.firstNameBox;
            lname = this.lastNameBox;
            Email = this.emailBox;
            Pass = this.passwordBox;
        }

        #region Profile Pic
        private void browseBtnn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG|*.png|JPEG|*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                profileImage = Image.FromFile(open.FileName);
            }
        }
        #endregion

        #region Updtae Profile Button
        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (Validator.ValidateEmail(emailBox.Text))
            {
                if (Validator.IsNotEmpty(emailBox.Text, passwordBox.Text, firstNameBox.Text, lastNameBox.Text))
                {
                    if (profileImage != null)
                    {
                        controller.UpdateAdminProfile(LoggedInAdmin, passwordBox.Text, firstNameBox.Text, lastNameBox.Text, profileImage);
                        LoggedInAdmin = emailBox.Text;
                        new AlibabaDesktopApp.Controller.AdminController().GetProfilePic(emailBox.Text, AdminView.profilePic);
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

        private void deleteAccountBtn_Click_1(object sender, EventArgs e)
        {
            Boolean b = controller.DeleteAdminProfile(LoggedInAdmin);
            MessageBox.Show("Account Deleted Successfully!");
            AdminView.profile.Visible = false;
            AdminView.OptionContainer.Visible = true;
            MainWindow.logInRegisterWindow.Visible = true;
            MainWindow.admin.Visible = false;

        }

        #endregion

        #region Back Button

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            AdminView.profile.Visible = false;
            AdminView.OptionContainer.Visible = true;
        }

        #endregion
    }
}
