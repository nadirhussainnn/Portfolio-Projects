using System;
using System.Windows.Forms;
using AlibabaDesktopApp.Controller;
namespace AlibabaDesktopApp.View
{
    public partial class NewRequestsView : UserControl
    {
        AdminController controller = new AdminController();
        string selectedVendor = "";
        public static DataGridView pendingRequestsGrid=new DataGridView();
        public NewRequestsView()
        {
            InitializeComponent();
            pendingRequestsGrid = this.pendingRequests;
        }


        private void NewRequestView_Load(object sender, EventArgs e)
        {
            
        }

        private void pendingRequests_SelectionChanged(object sender, EventArgs e)
        {
            if (pendingRequests.SelectedCells.Count>0)
            {
                int selectedRowIndex = this.pendingRequests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.pendingRequests.Rows[selectedRowIndex];
                selectedVendor = Convert.ToString(selectedRow.Cells["email"].Value);
            }
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            AdminView.newRequests.Visible = false;
            AdminView.OptionContainer.Visible = true;
        }

        private void rejectAllBtn_Click_1(object sender, EventArgs e)
        {
            controller.ApproveOrRejectVendors("Reject All", "None", this.pendingRequests);
        }

        private void approveAllBtn_Click_1(object sender, EventArgs e)
        {
            controller.ApproveOrRejectVendors("Approve All", "None", this.pendingRequests);
        }

        private void rejectSelectedBtn_Click_1(object sender, EventArgs e)
        {
            if (selectedVendor.Length != 0)
            {
                controller.ApproveOrRejectVendors("Reject Selected", selectedVendor, this.pendingRequests);
            }
            else
            {
                MessageBox.Show("Select Vendor Please");
            }
        }

        private void approveSelectedBtn_Click_1(object sender, EventArgs e)
        {
            if (selectedVendor.Length != 0)
            {
                controller.ApproveOrRejectVendors("Approve Selected", selectedVendor, this.pendingRequests);
            }
            else
            {
                MessageBox.Show("Select Vendor Please");
            }

        }
    }
}
