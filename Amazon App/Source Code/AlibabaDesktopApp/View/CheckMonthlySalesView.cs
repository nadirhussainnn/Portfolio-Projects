using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AlibabaDesktopApp.View
{
    public partial class CheckMonthlySalesView : UserControl
    {
        public Chart salesChart;
        public CheckMonthlySalesView()
        {
            InitializeComponent();
            salesChart = this.chart1;
        }

        private void CheckMonthlySalesView_Load(object sender, EventArgs e)
        {

        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            VendorView.checkMonthlySalesControl.Visible = false;
            VendorView.OptionContainer.Visible = true;
        }
    }
}
