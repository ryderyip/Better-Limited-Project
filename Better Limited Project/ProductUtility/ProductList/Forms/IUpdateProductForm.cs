using System;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public interface IUpdateProductForm
    {
        public event EventHandler? ProductUpdated;
        void ShowForm();
    }
}