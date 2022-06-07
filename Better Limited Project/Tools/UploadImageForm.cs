using System;
using System.Drawing;
using System.Windows.Forms;
using Better_Limited_Project.DocumentUtility;

namespace Better_Limited_Project.Tools
{
    public partial class UploadImageForm : Form
    {
        public event EventHandler<Image?>? Uploaded;

        public UploadImageForm(Image? originalImage = null)
        {
            InitializeComponent();
            Shown += (_, _) => FillOriginalInfo(originalImage);
        }

        private void FillOriginalInfo(Image? originalImage)
        {
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.Image = originalImage;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            string browserDescription = "Select an Image";
            var path = ImageFileBrowser.Browse(browserDescription);
            if (path == null) return;

            tbFilePath.Text = path;

            if (FileSizeChecker.IsFileLargerThan(5_000_000, path))
            {
                MessageBox.Show(ToolsStringResources.UploadImageForm_btnChooseImage_Click_File_size_cannot_be_larger_than_5MB_);
                return;
            }
            var image = ImageRetriever.Retrieve(path);
            if (image != null)
                pbImage.Image = image;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Close();
            Uploaded?.Invoke(this, pbImage.Image);
        }
    }
}