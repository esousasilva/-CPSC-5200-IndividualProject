using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    class Method
    {
        public Method()
        {

        }

        public static Bitmap RotateNDegree(Bitmap image, double angle) 
        {
            Mat imgMat = image.ToMat();

            // Get image center
            PointF center = new PointF(imgMat.Width / 2f, imgMat.Height / 2f);

            // Define rotation matrix
            Mat rotMat = new Mat();
            CvInvoke.GetRotationMatrix2D(center, angle, 1.0, rotMat);

            // Apply rotation
            CvInvoke.WarpAffine(imgMat, imgMat, rotMat, imgMat.Size);
            return imgMat.ToBitmap();
        }
        public static Bitmap ConvertToGray(Bitmap image)
        {
            Image<Gray, byte> imgGray = new Image<Gray, byte>(image.Width, image.Height);
            CvInvoke.CvtColor(image.ToMat(),imgGray, ColorConversion.Bgr2Gray);
            return imgGray.ToBitmap();
        }

    }
}