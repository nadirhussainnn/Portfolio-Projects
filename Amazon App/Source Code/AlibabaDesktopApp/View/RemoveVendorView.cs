using System;
using AlibabaDesktopApp.Controller;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class RemoveVendorView : UserControl
    {
        AdminController controller = new AdminController();
        public static DataGridView removeVendorGrid = new DataGridView();
        string selectedVendor = "";

        public RemoveVendorView()
        {
            InitializeComponent();
            removeVendorGrid = this.allVendors;
        }

        private void RemoveVendorView_Load(object sender, EventArgs e)
        {
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            AdminView.OptionContainer.Visible = true;
            AdminView.removeVendor.Visible = false;
        }

        private void allVendors_SelectionChanged(object sender, EventArgs e)
        {
            if (allVendors.SelectedCells.Count > 0)
            {
                int selectedRowIndex = this.allVendors.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.allVendors.Rows[selectedRowIndex];
                selectedVendor = Convert.ToString(selectedRow.Cells["email"].Value);
            }
        }

        private void removeAllBtn_Click_1(object sender, EventArgs e)
        {
            controller.RemoveVendor("All", "null", allVendors);
        }

        private void removeSelectedBtn_Click_1(object sender, EventArgs e)
        {
            controller.RemoveVendor("Selected", selectedVendor, allVendors);
        }
    }
}
