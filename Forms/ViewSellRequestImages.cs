using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TekManager.Code.Connection;
using TekManager.DataService;

namespace TekManager.Forms
{
    public partial class ViewSellRequestImages : Form
    {

        private readonly DataServiceHelper _serviceHelper;
        private readonly int _sellRequestId;
        private List<SellRequestImageModel> _images;
        private int _currentImageIndex = 0;
        public ViewSellRequestImages(int sellRequestId)
        {
            InitializeComponent();
            _sellRequestId = sellRequestId;
            _serviceHelper = new DataServiceHelper();
        }

        private void ViewSellRequestImages_Load(object sender, EventArgs e)
        {
            _serviceHelper.GetSellRequestImagesBySellRequestId(_sellRequestId)
                .Match(images =>
                {
                    if (images.Count == 0)
                    {
                        MessageBox.Show("There are no images.");
                        Close();
                    }
                    _images = images;
                }, error =>
                {
                    MessageBox.Show($"Failed to get request images.{Environment.NewLine}{error}");
                    Close();
                });

            UpdateView();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (_currentImageIndex == 0) return;
            _currentImageIndex--;
           UpdateView();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (_currentImageIndex == _images.Count - 1) return;
            _currentImageIndex++;
            UpdateView();
        }

        private void UpdateView()
        {
            var bitmap = ByteToImage(_images[_currentImageIndex].Image);
            Size = new Size(bitmap.Width + 56, bitmap.Height + 172);
            sellRequestImageBox.Image = bitmap;
            currentImageLabel.Text = $"Image {_currentImageIndex + 1} of {_images.Count}";
        }
    }
}
