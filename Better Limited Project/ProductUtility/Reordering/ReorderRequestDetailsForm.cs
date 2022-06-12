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
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (_reorderRequest.IsApproved())
                btnUnsendRequest.Visible = false;
            FillFields();
        }

        private void FillFields()
        {
            tbRequestNumber.Text = _reorderRequest.RequestNumber;
            tbRequestedOn.Text = _reorderRequest.RequestedOn.ToString("f");
            tbWarehouseName.Text = _reorderRequest.Warehouse.Name;
            tbRequestedByStaffName.Text = _reorderRequest.RequestedByStaff.Name;
            tbIsApproved.Text = _reorderRequest.IsApproved() ? "Yes" : "No";
            if (!_reorderRequest.IsApproved()) return;
            tbApprovedByStaffName.Text = _reorderRequest.ApprovedBy!.Name;
            tbApprovedOn.Text = _reorderRequest.ApprovedOn!.Value.ToString("f");
        }

        private void btnUnsendRequest_Click(object sender, System.EventArgs e)
        {
            if (_reorderRequest.IsApproved())
                return;
            var result = MessageBox.Show("Confirm unsending request?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK)
                return;
            
            _reorderRequest.Remove();
            DialogResult = DialogResult.OK;
        }
    }
}
