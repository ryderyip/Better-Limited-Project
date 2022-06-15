using System;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.DevTools.AutoLogin
{
    public partial class StaffRoleChooserForm : Form
    {
        public delegate void RoleSelectedEventHandler(object sender, StaffTitle title);
        public event RoleSelectedEventHandler? TitleSelected;

        public StaffRoleChooserForm()
        {
            InitializeComponent();
        }
        
        private void BtnButtonClicked(object sender, EventArgs e)
        {
            var button = (Button) sender;

            var selectedTitle = button.Name switch
            {
                "btnSalesRep" => StaffTitle.SalesRepresentative,
                "btnSalesManager" => StaffTitle.SalesManager,
                "btnAccountingClerk" => StaffTitle.AccountingClerk,
                "btnAccountingManager" => StaffTitle.AccountingManager,
                "btnPurchaseClerk" => StaffTitle.PurchaseClerk,
                "btnPurchaseManager" => StaffTitle.PurchaseManager,
                "btnInventoryClerk" => StaffTitle.InventoryClerk,
                "btnReceivingClerk" => StaffTitle.ReceivingClerk,
                "btnTechClerk" => StaffTitle.TechnicalSupportClerk,
                "btnTechManager" => StaffTitle.TechnicalSupportManager,
                "btnAdmin" => StaffTitle.Admin,
                _ => StaffTitle.Unknown
            };

            TitleSelected?.Invoke(this, selectedTitle);
        }

        private void btnGenerateSalesOrder_Click(object sender, EventArgs e)
        {
            Dog();
        }
        
        private void Dog()
        {
            var form = new RandomOrderPlacerForm()
            {
                MaxNumber = 1000, MinNumber = 1
            };
            form.ShowDialog();
        }
    }
}