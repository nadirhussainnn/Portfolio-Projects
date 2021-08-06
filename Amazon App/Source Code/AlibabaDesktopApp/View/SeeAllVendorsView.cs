using System;
using System.Collections.Generic;
using AlibabaDesktopApp.Controller;
using System.Windows.Forms;

namespace AlibabaDesktopApp.View
{
    public partial class SeeAllVendorsView : UserControl
    {
        public static DataGridView allVendorsGrid = new DataGridView();
        public SeeAllVendorsView()
        {
            InitializeComponent();
            allVendorsGrid = this.allVendors;
        }

        private void SeeAllVendorsView_Load(object sender, EventArgs e)
        {
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            AdminView.seeAllvendors.Visible = false;
            AdminView.OptionContainer.Visible = true;

        }
    }
}
