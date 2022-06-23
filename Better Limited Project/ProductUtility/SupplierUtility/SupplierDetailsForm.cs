using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public partial class SupplierDetailsForm : Form
    {
        private Supplier _supplier;

        public SupplierDetailsForm(Supplier supplier)
        {
            StartPosition = FormStartPosition.CenterScreen;
            _supplier = supplier;
            InitializeComponent();
            Shown += (_, _) => btnRemoveCustomer.Visible = false;
            Shown += (_, _) => FillFields();
        }

        public event EventHandler? Updated;

        private void FillFields()
        {
            tbname.Text = _supplier.Name;
            tbPhone.Text = _supplier.Phone;
            tbEmailAddress.Text = _supplier.Email;
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            _supplier.Remove();
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