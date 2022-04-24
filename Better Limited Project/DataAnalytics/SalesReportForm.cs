using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better_Limited_Project.DataAnalytics
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            chartCity.Series["city"].Points.AddXY("Hong Kong", 422);
            chartDistrict.Series["district"].Points.AddXY("Kowloon Bay", 211);
            chartDistrict.Series["district"].Points.AddXY("Tseun Wan", 113);
        }
    }
}
