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
            Mat imgMat = new Mat();
            imgMat = image.ToMat();

            // Get image center
            PointF center = new PointF(imgMat.Width / 2f, imgMat.Height / 2f);

            // Define rotation matrix
            Mat rotMat = new Mat();
            CvInvoke.GetRotationMatrix2D(center, angle, 1.0, rotMat);

            // Apply rotation
            CvInvoke.WarpAffine(imgMat, imgMat, rotMat, imgMat.Size);

            // Convert Mat back to Bitmap
            CvInvoke.Imshow("test",imgMat);
            return imgMat.ToBitmap();
        }
        public static Bitmap ConvertToGray(Bitmap image)
        {
            Image<Gray, byte> imgGray = new Image<Gray, byte>(image.Width, image.Height);
            CvInvoke.CvtColor(image.ToMat(),imgGray, ColorConversion.Bgr2Gray);
            return imgGray.ToBitmap();
        }

        public static bool ConvertToNegative(Bitmap b)
        {

            for (int i = 0; i < b.Width; i++)    // Loop for Width
                for (int j = 0; j < b.Height; j++)    // Loo for Height
                {

                    Color c1 = b.GetPixel(i, j);    // Get Pixel from colour
                    int a = c1.A;    // Extracting ARGB from pixel colour
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    // For negative values

                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;

                    b.SetPixel(i, j, Color.FromArgb(a, r1, g1, b1));   // Setting new colour for negative processed image
                }
            return true;
        }
    }
}