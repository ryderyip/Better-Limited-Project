using System;
using System.Collections.Generic;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class UpdateStockLevelController
    {
        public delegate void StockLevelUpdatedEventHandler(object sender, EventArgs e);
        public event StockLevelUpdatedEventHandler StockLevelUpdated;

        public void OpenForm()
        {
            var form = new UpdateStockLevelForm();
            form.StockLevelUpdated += OnStockLevelUpdated;
            form.ShowDialog();
        }

        private void OnStockLevelUpdated(object sender, EventArgs e)
        {
            StockLevelUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}