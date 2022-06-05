using System;
using System.Drawing;
using System.Windows.Forms;
using Better_Limited_Project.DocumentUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class UpdateProductImageForm : Form
    {
        private readonly Product _product;
        public event EventHandler? ProductUpdated;

        public UpdateProductImageForm(Product product)
        {
            _product = product;
            InitializeComponent();
            Shown += (_, _) => FillOriginalInfo();
        }

        private void FillOriginalInfo()
        {
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.Image = _product.GetImage();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            string browserDescription = "Select a Product Image";
            var path = ImageFileBrowser.Browse(browserDescription);
            if (path == null) return;

            tbFilePath.Text = path;
            
            try
            {
                var image = Image.FromFile(path);
                pbImage.Image = image;
            }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show("Image file is in incorrect format. Please choose another one.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _product.SetImage(pbImage.Image);
            Close();
            ProductUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}