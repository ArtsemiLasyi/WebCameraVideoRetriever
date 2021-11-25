using System;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;

using DirectShowLib;
using System.Collections.Generic;

namespace WebCameraVideoRetriever.Api
{
    public static class CameraWorker
    {
        public static VideoCapture capture = null;
        public static DsDevice[] webcams = null;

        public static int selectedCameraId = 0;

        public static IEnumerable<string> GetCameras()
        {
            webcams = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            foreach(var cam in webcams)
            {
                yield return cam.Name;
            }
        }

        public static void SetActiveCamera(int number)
        {
            selectedCameraId = number;
        }

        public static Image<Bgr, byte> GetImage()
        {
            Mat m = new Mat();
            capture.Retrieve(m);
            return m.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
        }
    }
}
