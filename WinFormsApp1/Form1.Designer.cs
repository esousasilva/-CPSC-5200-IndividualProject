namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            picOriginal = new PictureBox();
            newImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newImage).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(192, 380);
            button1.Name = "button1";
            button1.Size = new Size(102, 38);
            button1.TabIndex = 0;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(738, 380);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 1;
            button2.Text = "Gray";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // picOriginal
            // 
            picOriginal.Location = new Point(12, 49);
            picOriginal.Name = "picOriginal";
            picOriginal.Size = new Size(498, 300);
            picOriginal.TabIndex = 2;
            picOriginal.TabStop = false;
            picOriginal.Click += pictureBox1_Click;
            // 
            // newImage
            // 
            newImage.Location = new Point(544, 49);
            newImage.Name = "newImage";
            newImage.Size = new Size(524, 300);
            newImage.TabIndex = 3;
            newImage.TabStop = false;
            newImage.Click += newImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 523);
            Controls.Add(newImage);
            Controls.Add(picOriginal);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)picOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)newImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox picOriginal;
        private PictureBox newImage;
    }
}
