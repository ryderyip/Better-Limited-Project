using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public partial class SupplierDetailsForm : Form
    {
        private SupplierEntity _supplier;
        public event EventHandler? Updated;
        
        public SupplierDetailsForm(SupplierEntity supplier)
        {
            _supplier = supplier;
            InitializeComponent();
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            tbname.Text = _supplier.Supplier.Name;
            tbPhone.Text = _supplier.Supplier.Phone;
            tbEmailAddress.Text = _supplier.Supplier.Email;
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            SupplierRepository.RemoveSupplier(_supplier.Id);
            Updated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            var form = new UpdateSupplierForm(_supplier);
            form.Updated += (_, _) => RefreshFields();
            form.Updated += (_, _) => Updated?.Invoke(this, EventArgs.Empty);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void RefreshFields()
        {
            _supplier = SupplierRepository.GetById(_supplier.Id);
            FillFields();
        }
    }
}
