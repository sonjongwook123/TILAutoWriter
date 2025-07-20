using System;
using System.Drawing;
using System.Windows.Forms;

namespace TILAutoPublisher
{
    public partial class ImagePreviewForm : Form
    {
        public Image SelectedImage { get; private set; }
        public string SelectedImageIdentifier { get; private set; }

        public ImagePreviewForm(Image imageToPreview, string imageIdentifier)
        {
            InitializeComponent(); // This calls the method defined in ImagePreviewForm.Designer.cs
            pbPreview.Image = imageToPreview;
            SelectedImageIdentifier = imageIdentifier;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectedImage = pbPreview.Image;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}