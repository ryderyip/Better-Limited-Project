using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.DefectiveItemReturning
{
    public partial class DefectiveItemListForm : Form
    {
        private List<DefectiveItem> _defectiveItems;
        private readonly List<SalesOrder> _salesOrders;

        public DefectiveItemListForm() // TODO implement search function
        {
            _defectiveItems = DefectiveItemRepository.GetAll().ToList();
            _salesOrders = new SalesOrderRepository().FindAll(so => _defectiveItems.Any(di => di.SalesOrderId == so.Id))
                .ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            tbSearchBox.TextChanged += (_, _) => FilterDgv();
            if (LoginSession.GetSession().CurrentStaff.Department is not Department.Sales)
                btnNewRecord.Visible = false;
            PopulateDgv(_defectiveItems);
        }

        private void FilterDgv()
        {
            string searchKeyword = tbSearchBox.Text.Trim().ToLower();
            var filtered = _defectiveItems.Where(di => _salesOrders.Find(so => so.Id == di.SalesOrderId).OrderNumber.ToLower().Contains(searchKeyword)
                                                       || di.Product.Name.ToLower().Contains(searchKeyword));
            PopulateDgv(filtered);
        }

        private void PopulateDgv(IEnumerable<DefectiveItem> items)
        {
            dgvDefectiveItems.Rows.Clear();
            foreach (var defectiveItem in items)
                dgvDefectiveItems.Rows.Add(defectiveItem.Id,
                    defectiveItem.SalesOrder.OrderNumber,
                    defectiveItem.Product.Name,
                    defectiveItem.Quantity,
                    defectiveItem.ReturnedToRetailStoreOn.ToString("g"),
                    defectiveItem.IsReturnApproved() ? "Yes" : "No");
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
