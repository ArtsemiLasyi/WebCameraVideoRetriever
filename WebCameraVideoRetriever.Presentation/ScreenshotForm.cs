using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCameraVideoRetriever.Presentation
{
    public partial class ScreenshotForm : Form
    {
        private Image<Bgr, byte> image;

        private string fileName = string.Empty;

        public ScreenshotForm(Image<Bgr, byte> image)
        {
            InitializeComponent();
            this.image = image;
        }

        private void ScreenshotForm_Load(object sender, EventArgs e)
        {
            fileName = $"WCVC_{Guid.NewGuid()}.jpg";
            ScreenshotPictureBox.Image = image.ToBitmap();
        }

        private void SaveScreenshotToolStripButton_Click(object sender, EventArgs e)
        {
            ScreenshotPictureBox.Image.Save(fileName, ImageFormat.Jpeg);
            Close();
        }

        private void ExitWithoutSavetoolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
