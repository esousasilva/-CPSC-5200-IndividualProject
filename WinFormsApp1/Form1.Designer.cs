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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newImage).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(357, 811);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(189, 81);
            button1.TabIndex = 0;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1371, 811);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(206, 81);
            button2.TabIndex = 1;
            button2.Text = "Gray";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // picOriginal
            // 
            picOriginal.Location = new Point(22, 105);
            picOriginal.Margin = new Padding(6);
            picOriginal.Name = "picOriginal";
            picOriginal.Size = new Size(925, 640);
            picOriginal.TabIndex = 2;
            picOriginal.TabStop = false;
            picOriginal.Click += pictureBox1_Click;
            // 
            // newImage
            // 
            newImage.Location = new Point(1010, 105);
            newImage.Margin = new Padding(6);
            newImage.Name = "newImage";
            newImage.Size = new Size(973, 640);
            newImage.TabIndex = 3;
            newImage.TabStop = false;
            newImage.Click += newImage_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(744, 797);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 36);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Gray";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(744, 856);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(229, 36);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Rotate 90 degree";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(744, 924);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(229, 36);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Rotate 45 degree";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2006, 1116);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(newImage);
            Controls.Add(picOriginal);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)picOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)newImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox picOriginal;
        private PictureBox newImage;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}
