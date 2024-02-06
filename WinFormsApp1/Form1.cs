using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileNameee = "C:\\Users\\eduar\\source\\repos\\WinFormsApp1\\WinFormsApp1\\lean.png";
            Mat img = CvInvoke.Imread(fileNameee, ImreadModes.Color);
            Bitmap bmp = img.ToBitmap();
            picOriginal.Image = bmp;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)picOriginal.Image);
            newImage.Image = Method.RotateNDegree((Bitmap)picOriginal.Image, 45.0);
        }

        private void newImage_Click(object sender, EventArgs e)
        {
        }
    }
}
