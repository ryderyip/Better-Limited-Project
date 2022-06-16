using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.DefectiveItemReturning
{
    public partial class DefectiveItemListForm : Form
    {
        private List<DefectiveItem> _defectiveItems;
        
        public DefectiveItemListForm()
        {
            _defectiveItems = DefectiveItemRepository.GetAll().ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (LoginSession.GetSession().CurrentStaff.Department is not Department.Sales)
                btnNewRecord.Visible = false;
            PopulateDgv(_defectiveItems);
        }

        private void PopulateDgv(List<DefectiveItem> items)
        {
            dgvDefectiveItems.Rows.Clear();
            items.ForEach(di => dgvDefectiveItems.Rows.Add(di.Id,
                di.SalesOrder.OrderNumber,
                di.Product.Name,
                di.Quantity,
                di.ReturnedToRetailStoreOn.ToString("g"),
                di.IsReturnApproved() ? "Yes" : "No"));
            dgvDefectiveItems.Sort(returnedOnColumn, ListSortDirection.Descending);
        }

        private void btnNewItem_Click(object sender, System.EventArgs e)
        {
            var form = new NewDefectiveItem();
            var result = form.ShowDialog();
            if (result is not DialogResult.OK)
                return;
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            _defectiveItems = DefectiveItemRepository.GetAll().ToList();
            PopulateDgv(_defectiveItems);
        }

        private void dgvDefectiveItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = _defectiveItems.Find(di =>
                di.Id == dgvDefectiveItems.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString());
            var form = new DefectiveItemDetailsForm(selected);
            var result = form.ShowDialog();
            if (result is DialogResult.OK)
                RefreshDgv();
        }
    }
}
