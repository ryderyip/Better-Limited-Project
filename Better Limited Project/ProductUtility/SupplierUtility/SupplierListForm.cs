using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public partial class SupplierListForm : Form
    {
        private List<Supplier> _suppliers;

        public SupplierListForm()
        {
            _suppliers = SupplierRepository.GetSuppliers().ToList();
            InitializeComponent();
            Shown += (_, _) => PopulateSupplierDgv(_suppliers);
        }

        private void PopulateSupplierDgv(List<Supplier> supplier)
        {
            dgvSupplier.Rows.Clear();
            supplier.ForEach(supp =>
                dgvSupplier.Rows.Add(supp.Name, supp.Phone,
                    supp.Email));
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedSupplierPhone = dgvSupplier.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            var selectedSupplier = _suppliers.First(supp => supp.Phone == selectedSupplierPhone);
            var form = new SupplierDetailsForm(selectedSupplier);
            form.Updated += (_, _) => RefreshSupplierDgv();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnNewProductClicked_Click(object sender, EventArgs e)
        {
            var form = new CreateSupplierForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.SupplierCreated += (_, _) => RefreshSupplierDgv();
            form.ShowDialog();
        }

        private void RefreshSupplierDgv()
        {
            _suppliers = SupplierRepository.GetSuppliers().ToList();
            PopulateSupplierDgv(_suppliers);
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = tbSearchBox.Text.ToLower();
            var suppliers = _suppliers
                .Where(supp => supp.Name.ToLower().Contains(keyword)
                               || supp.Email.ToLower().Contains(keyword)
                               || supp.Phone.ToLower().Contains(keyword)).ToList();
            PopulateSupplierDgv(suppliers);
        }
    }
}