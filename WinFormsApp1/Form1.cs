using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Microsoft.VisualBasic;
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
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Supported files: (*.bmp, *.jpg, *.png)|*.bmp; *.jpg; *png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Mat img = CvInvoke.Imread(open.FileName, ImreadModes.Color);
                Bitmap bmp = img.ToBitmap();
                picOriginal.Image = bmp;
                picOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //newImage.Image = Method.ConvertToGray((Bitmap)picOriginal.Image);
            newImage.Image = Method.RotateNDegree((Bitmap)picOriginal.Image, 45.0);
            newImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void newImage_Click(object sender, EventArgs e)
        {
        }
    }
}
