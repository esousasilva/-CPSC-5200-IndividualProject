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
        private bool _box1, _box2, _box3 = false;

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
            newImage.Image = (Bitmap)picOriginal.Image;
         
            if (checkBox1.Checked)
            {
                newImage.Image = Method.ConvertToGray((Bitmap)newImage.Image);
            }

            if(checkBox2.Checked)
            {
                newImage.Image = Method.RotateNDegree((Bitmap)newImage.Image, 90.0);
            }

            if(checkBox3.Checked) 
            {
                newImage.Image = Method.RotateNDegree((Bitmap)newImage.Image, 45.0);
            }
            newImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void newImage_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _box1 = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _box2 = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            _box3 = true;
        }
    }
}
