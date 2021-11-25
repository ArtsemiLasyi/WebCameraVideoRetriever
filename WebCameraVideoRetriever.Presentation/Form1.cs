using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCameraVideoRetriever.Api;

namespace WebCameraVideoRetriever.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IEnumerable<string> cams = CameraWorker.GetCameras();
            foreach(string cam in cams)
            {
                CameraToolStripComboBox.Items.Add(cam);
            }
        }

        private void CameraToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CameraWorker.SetActiveCamera(CameraToolStripComboBox.SelectedIndex);
        }

        private void PlayToolStripButton_Click(object sender, EventArgs e)
        {
            if (CameraWorker.webcams.Length == 0)
            {
                return;
            }
            else if (CameraToolStripComboBox.SelectedItem == null)
            {
                return;
            }
            else if (CameraWorker.capture != null)
            {
                CameraWorker.capture.Start();
            }
            else
            {
                CameraWorker.capture = new VideoCapture(CameraWorker.selectedCameraId);
                CameraWorker.capture.ImageGrabbed += Capture_ImageGrabbed;
                CameraWorker.capture.Start();
            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            VideoPictureBox.Image = CameraWorker.GetImage().ToBitmap();
        }

        private void PauseToolStripButton_Click(object sender, EventArgs e)
        {
            if (CameraWorker.capture != null)
            {
                CameraWorker.capture.Pause();
            }
        }

        private void StopToolStripButton_Click(object sender, EventArgs e)
        {
            if (CameraWorker.capture != null)
            {
                CameraWorker.capture.Pause();
                CameraWorker.capture.Dispose();
                CameraWorker.capture = null;
                VideoPictureBox.Image = null;
            }
        }

        private void ScreenshotToolStripButton_Click(object sender, EventArgs e)
        {
            ScreenshotForm screenshotForm = new ScreenshotForm(CameraWorker.GetImage());
            screenshotForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
