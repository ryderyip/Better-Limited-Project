using System;
using Better_Limited_Project.ProductUtility.ProductList.Forms;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class UpdateStockLevelController
    {
        private readonly string _selectedWorkplaceId;
        
        public UpdateStockLevelController(string selectedWorkplaceId)
        {
            _selectedWorkplaceId = selectedWorkplaceId;
        }

        public delegate void StockLevelUpdatedEventHandler(object sender, EventArgs e);
        public event StockLevelUpdatedEventHandler? StockLevelUpdated;

        
        public void OpenForm()
        {
            var form = new UpdateStockLevelForm(_selectedWorkplaceId);
            form.StockLevelUpdated += OnStockLevelUpdated;
            form.ShowDialog();
        }

        private void OnStockLevelUpdated(object sender, EventArgs e)
        {
            StockLevelUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}