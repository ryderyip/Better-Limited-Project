using System.Windows.Forms;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public partial class ReorderRequestDetailsForm : Form
    {
        private readonly ReorderRequest _reorderRequest;

        public ReorderRequestDetailsForm(ReorderRequest reorderRequest)
        {
            _reorderRequest = reorderRequest;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnUnsendRequest_Click(object sender, System.EventArgs e)
        {

        }
    }
}
