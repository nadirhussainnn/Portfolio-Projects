using System;
using System.Drawing;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;

namespace AlibabaDesktopApp.View
{
    public partial class AdminView : UserControl
    {
        public static NewRequestsView newRequests = new NewRequestsView();
        public static ApprovedRequestsView approvedRequests = new ApprovedRequestsView();
        public static RejectedRequestsView rejectedRequests = new RejectedRequestsView();
        public static SeeAllVendorsView seeAllvendors = new SeeAllVendorsView();
        public static RemoveVendorView removeVendor = new RemoveVendorView();
        public static SendEmailView sendEmail = new SendEmailView();
        public static AdminProfile profile = new AdminProfile();

        public static PictureBox profilePic = new PictureBox();
        
        public static Panel OptionContainer = new Panel();

        AdminController controller = new AdminController();

        public string Email { get; set; }

        public AdminView()
        {
            InitializeComponent();
            
            newRequests.Location = new Point(165,115);
            approvedRequests.Location = new Point(165, 115);
            rejectedRequests.Location = new Point(165, 115);
            seeAllvendors.Location = new Point(165, 115);
            removeVendor.Location = new Point(165,115);
            sendEmail.Location = new Point(165, 115);
            profile.Location = new Point(238, 150);
            profilePic = profileAvatar;

            this.Controls.Add(newRequests);
            this.Controls.Add(approvedRequests);
            this.Controls.Add(rejectedRequests);
            this.Controls.Add(seeAllvendors);
            this.Controls.Add(removeVendor);
            this.Controls.Add(profile);
            this.Controls.Add(sendEmail);

            OptionContainer = this.optionContainer;
        }

        #region Form Load Event

        private void AdminView_Load(object sender, EventArgs e)
        {
            this.sideBar.Width = 0;
            profileAvatar.Visible = false;
            this.optionContainer.Location=new Point(151,this.optionContainer.Location.Y);

            newRequests.Visible = false;
            approvedRequests.Visible = false;
            rejectedRequests.Visible = false;
            seeAllvendors.Visible = false;
            removeVendor.Visible = false;
            profile.Visible = false;
            sendEmail.Visible = false;
        }

        #endregion

        #region Three-Liner
        private void threeLiner_Click(object sender, EventArgs e)
        {

            if (this.sideBar.Width<= 0)
            {
                threeLiner.Width -= 10;
                threeLiner.Height -= 10;
                Animator.Start();
            }
            else if(this.sideBar.Width >= 145)
            {

                //this.optionContainer.Location = new Point(151, 123);

                threeLiner.Width += 10;
                threeLiner.Height += 10;
                Animator2.Start();
            }
        }
        #endregion

        #region SideBarAnimation
        private void Animator_Tick(object sender, EventArgs e)
        {
            this.sideBar.Width += 5;
            this.optionContainer.Location = new Point(optionContainer.Location.X + 3, this.optionContainer.Location.Y);

            if (this.sideBar.Width >= 145)
            {
                profileAvatar.Visible = true;
                Animator.Stop();
            }
        }
        private void Animator2_Tick(object sender, EventArgs e)
        {
            this.sideBar.Width -= 5;
            this.optionContainer.Location = new Point(optionContainer.Location.X - 3, this.optionContainer.Location.Y);

            if (this.sideBar.Width <= 0)
            {
                profileAvatar.Visible = false;
                Animator2.Stop();
            }
        }
        #endregion


        #region Logout Button

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MainWindow.logInRegisterWindow.Visible = true;
            MainWindow.admin.Visible = false;
            MainWindow.customer.Visible = false;
            MainWindow.vendor.Visible = false;

            newRequests.Visible = false;
            approvedRequests.Visible = false;
            rejectedRequests.Visible = false;
            seeAllvendors.Visible = false;
            removeVendor.Visible = false;
            profile.Visible = false;
            sendEmail.Visible = false;
            OptionContainer.Visible = true;
            this.optionContainer.Location = new Point(151, this.optionContainer.Location.Y);

            sideBar.Width = 0;
            threeLiner.Width += 10;
            threeLiner.Height += 10;
        }

        #endregion

        
        private void newRequestsBtn_Click(object sender, EventArgs e)
        {
            controller.LoadAllPendingRequests(NewRequestsView.pendingRequestsGrid);
            newRequests.Visible = true;
            OptionContainer.Visible = false;
        }

        private void previousRequestsBtn_Click(object sender, EventArgs e)
        {
            controller.LoadAllApprovesRequests(ApprovedRequestsView.approvedrequestsGrid);
            approvedRequests.Visible = true;
            OptionContainer.Visible = false;
        }

        private void rejectedRequestsBtn_Click(object sender, EventArgs e)
        {
            controller.LoadAllRejectedRequests(RejectedRequestsView.rejectedRequestsGrid);
            rejectedRequests.Visible = true;
            OptionContainer.Visible = false;
        }

        private void seeAllVendorsBtn_Click(object sender, EventArgs e)
        {
            controller.LoadAllVendors(SeeAllVendorsView.allVendorsGrid);
            seeAllvendors.Visible = true;
            OptionContainer.Visible = false;
        }

        private void removeVendorBtn_Click(object sender, EventArgs e)
        {
            controller.LoadAllVendors(RemoveVendorView.removeVendorGrid);
            removeVendor.Visible = true;
            OptionContainer.Visible = false;
        }

        private void sendNotificationBtn_Click(object sender, EventArgs e)
        {
            sendEmail.Visible = true;
            OptionContainer.Visible = false;

            VendorController v = new VendorController();
            v.LoadEmailsOfAllVendors(sendEmail.vendors);

        }
        
        private void profileBtn_Click_1(object sender, EventArgs e)
        {
            newRequests.Visible = false;
            approvedRequests.Visible = false;
            rejectedRequests.Visible = false;
            seeAllvendors.Visible = false;
            removeVendor.Visible = false;
            sendEmail.Visible = false;
            OptionContainer.Visible = true;

            AdminController controller = new AdminController();
            controller.LoadAdminProfile(Email, profile.fname, profile.lname, profile.Email, profile.Pass);
            profile.Visible = true;
            profile.LoggedInAdmin = Email;
            OptionContainer.Visible = false;

        }
    }
}
