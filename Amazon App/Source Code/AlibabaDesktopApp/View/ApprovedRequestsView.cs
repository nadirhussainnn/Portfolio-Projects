using System;
using AlibabaDesktopApp.Controller;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class ApprovedRequestsView : UserControl
    {
        public static DataGridView approvedrequestsGrid = new DataGridView();
        public ApprovedRequestsView()
        {
            InitializeComponent();
            approvedrequestsGrid = this.approvedRequests;
        }

        private void ApprovedRequestsView_Load(object sender, EventArgs e)
        {
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            AdminView.approvedRequests.Visible = false;
            AdminView.OptionContainer.Visible = true;
        }
    }
}
