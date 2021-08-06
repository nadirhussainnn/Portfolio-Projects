using System;
using AlibabaDesktopApp.Controller;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class RejectedRequestsView : UserControl
    {
        public static DataGridView rejectedRequestsGrid = new DataGridView();
        public RejectedRequestsView()
        {
            InitializeComponent();
            rejectedRequestsGrid = this.rejectedRequests;
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            AdminView.rejectedRequests.Visible = false;
            AdminView.OptionContainer.Visible = true;
        }

        private void RejectedRequestsView_Load(object sender, EventArgs e)
        {
        }
    }
}
