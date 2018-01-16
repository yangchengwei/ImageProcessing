﻿namespace FreshmanTrainingProject
{
    partial class ImageProcessing
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loadImage = new System.Windows.Forms.Button();
            this.colorExtraction = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorTransformation = new System.Windows.Forms.Button();
            this.meanFilter = new System.Windows.Forms.Button();
            this.medianFilter = new System.Windows.Forms.Button();
            this.histogramEqualization = new System.Windows.Forms.Button();
            this.thresholding = new System.Windows.Forms.Button();
            this.scrollBar = new System.Windows.Forms.HScrollBar();
            this.sobelEdgeDetection = new System.Windows.Forms.Button();
            this.edgeOverlapping = new System.Windows.Forms.Button();
            this.numericRed = new System.Windows.Forms.NumericUpDown();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.numericGreen = new System.Windows.Forms.NumericUpDown();
            this.numericBlue = new System.Windows.Forms.NumericUpDown();
            this.resetSourceImage = new System.Windows.Forms.Button();
            this.erosion = new System.Windows.Forms.Button();
            this.dilation = new System.Windows.Forms.Button();
            this.scrollBarValue = new System.Windows.Forms.TextBox();
            this.saveImage = new System.Windows.Forms.Button();
            this.imageEncryption = new System.Windows.Forms.Button();
            this.rotation = new System.Windows.Forms.Button();
            this.stretching = new System.Windows.Forms.Button();
            this.labelDegree = new System.Windows.Forms.Label();
            this.numericDegree = new System.Windows.Forms.NumericUpDown();
            this.labelHorizontal = new System.Windows.Forms.Label();
            this.numericHorizontal = new System.Windows.Forms.NumericUpDown();
            this.labelVertical = new System.Windows.Forms.Label();
            this.numericVertical = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(318, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // loadImage
            // 
            this.loadImage.AutoSize = true;
            this.loadImage.Location = new System.Drawing.Point(624, 40);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(180, 40);
            this.loadImage.TabIndex = 3;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // colorExtraction
            // 
            this.colorExtraction.AutoSize = true;
            this.colorExtraction.Enabled = false;
            this.colorExtraction.Location = new System.Drawing.Point(624, 86);
            this.colorExtraction.Name = "colorExtraction";
            this.colorExtraction.Size = new System.Drawing.Size(180, 40);
            this.colorExtraction.TabIndex = 4;
            this.colorExtraction.Text = "Color Extraction";
            this.colorExtraction.UseVisualStyleBackColor = true;
            this.colorExtraction.Click += new System.EventHandler(this.colorExtraction_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(12, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 300);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(318, 380);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 300);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 11;
            // 
            // colorTransformation
            // 
            this.colorTransformation.AutoSize = true;
            this.colorTransformation.Enabled = false;
            this.colorTransformation.Location = new System.Drawing.Point(624, 132);
            this.colorTransformation.Name = "colorTransformation";
            this.colorTransformation.Size = new System.Drawing.Size(180, 40);
            this.colorTransformation.TabIndex = 5;
            this.colorTransformation.Text = "Color Transformation";
            this.colorTransformation.UseVisualStyleBackColor = true;
            this.colorTransformation.Click += new System.EventHandler(this.colorTransformation_Click);
            // 
            // meanFilter
            // 
            this.meanFilter.AutoSize = true;
            this.meanFilter.Enabled = false;
            this.meanFilter.Location = new System.Drawing.Point(624, 178);
            this.meanFilter.Name = "meanFilter";
            this.meanFilter.Size = new System.Drawing.Size(180, 40);
            this.meanFilter.TabIndex = 6;
            this.meanFilter.Text = "Mean Filter ";
            this.meanFilter.UseVisualStyleBackColor = true;
            this.meanFilter.Click += new System.EventHandler(this.meanFilter_Click);
            // 
            // medianFilter
            // 
            this.medianFilter.AutoSize = true;
            this.medianFilter.Enabled = false;
            this.medianFilter.Location = new System.Drawing.Point(624, 224);
            this.medianFilter.Name = "medianFilter";
            this.medianFilter.Size = new System.Drawing.Size(180, 40);
            this.medianFilter.TabIndex = 7;
            this.medianFilter.Text = "Median Filter ";
            this.medianFilter.UseVisualStyleBackColor = true;
            this.medianFilter.Click += new System.EventHandler(this.medianFilter_Click);
            // 
            // histogramEqualization
            // 
            this.histogramEqualization.AutoSize = true;
            this.histogramEqualization.Enabled = false;
            this.histogramEqualization.Location = new System.Drawing.Point(624, 270);
            this.histogramEqualization.Name = "histogramEqualization";
            this.histogramEqualization.Size = new System.Drawing.Size(180, 40);
            this.histogramEqualization.TabIndex = 8;
            this.histogramEqualization.Text = "Histogram Equalization";
            this.histogramEqualization.UseVisualStyleBackColor = true;
            this.histogramEqualization.Click += new System.EventHandler(this.histogramEqualization_Click);
            // 
            // thresholding
            // 
            this.thresholding.AutoSize = true;
            this.thresholding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thresholding.Enabled = false;
            this.thresholding.Location = new System.Drawing.Point(624, 316);
            this.thresholding.Name = "thresholding";
            this.thresholding.Size = new System.Drawing.Size(180, 40);
            this.thresholding.TabIndex = 9;
            this.thresholding.Text = "Thresholding";
            this.thresholding.UseVisualStyleBackColor = true;
            this.thresholding.Click += new System.EventHandler(this.thresholding_Click);
            // 
            // scrollBar
            // 
            this.scrollBar.Enabled = false;
            this.scrollBar.LargeChange = 1;
            this.scrollBar.Location = new System.Drawing.Point(812, 316);
            this.scrollBar.Maximum = 256;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(115, 30);
            this.scrollBar.TabIndex = 10;
            this.scrollBar.Value = 128;
            this.scrollBar.ValueChanged += new System.EventHandler(this.scrollBar_ValueChanged);
            // 
            // sobelEdgeDetection
            // 
            this.sobelEdgeDetection.AutoSize = true;
            this.sobelEdgeDetection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sobelEdgeDetection.Enabled = false;
            this.sobelEdgeDetection.Location = new System.Drawing.Point(624, 362);
            this.sobelEdgeDetection.Name = "sobelEdgeDetection";
            this.sobelEdgeDetection.Size = new System.Drawing.Size(180, 40);
            this.sobelEdgeDetection.TabIndex = 12;
            this.sobelEdgeDetection.Text = "Sobel Edge Detection";
            this.sobelEdgeDetection.UseVisualStyleBackColor = true;
            this.sobelEdgeDetection.Click += new System.EventHandler(this.sobelEdgeDetection_Click);
            // 
            // edgeOverlapping
            // 
            this.edgeOverlapping.AutoSize = true;
            this.edgeOverlapping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.edgeOverlapping.Enabled = false;
            this.edgeOverlapping.Location = new System.Drawing.Point(624, 409);
            this.edgeOverlapping.Name = "edgeOverlapping";
            this.edgeOverlapping.Size = new System.Drawing.Size(180, 40);
            this.edgeOverlapping.TabIndex = 13;
            this.edgeOverlapping.Text = "Edge Overlapping";
            this.edgeOverlapping.UseVisualStyleBackColor = true;
            this.edgeOverlapping.Click += new System.EventHandler(this.edgeOverlapping_Click);
            // 
            // numericRed
            // 
            this.numericRed.Enabled = false;
            this.numericRed.Location = new System.Drawing.Point(808, 424);
            this.numericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed.Name = "numericRed";
            this.numericRed.Size = new System.Drawing.Size(50, 22);
            this.numericRed.TabIndex = 14;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Enabled = false;
            this.labelRed.Location = new System.Drawing.Point(808, 409);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(24, 12);
            this.labelRed.TabIndex = 22;
            this.labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Enabled = false;
            this.labelGreen.Location = new System.Drawing.Point(862, 409);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(33, 12);
            this.labelGreen.TabIndex = 23;
            this.labelGreen.Text = "Green";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Enabled = false;
            this.labelBlue.Location = new System.Drawing.Point(918, 409);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(27, 12);
            this.labelBlue.TabIndex = 24;
            this.labelBlue.Text = "Blue";
            // 
            // numericGreen
            // 
            this.numericGreen.Enabled = false;
            this.numericGreen.Location = new System.Drawing.Point(864, 424);
            this.numericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen.Name = "numericGreen";
            this.numericGreen.Size = new System.Drawing.Size(50, 22);
            this.numericGreen.TabIndex = 15;
            // 
            // numericBlue
            // 
            this.numericBlue.Enabled = false;
            this.numericBlue.Location = new System.Drawing.Point(920, 424);
            this.numericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue.Name = "numericBlue";
            this.numericBlue.Size = new System.Drawing.Size(50, 22);
            this.numericBlue.TabIndex = 16;
            // 
            // resetSourceImage
            // 
            this.resetSourceImage.AutoSize = true;
            this.resetSourceImage.Enabled = false;
            this.resetSourceImage.Location = new System.Drawing.Point(810, 86);
            this.resetSourceImage.Name = "resetSourceImage";
            this.resetSourceImage.Size = new System.Drawing.Size(180, 40);
            this.resetSourceImage.TabIndex = 20;
            this.resetSourceImage.Text = "Reset Source Image";
            this.resetSourceImage.UseVisualStyleBackColor = true;
            this.resetSourceImage.Click += new System.EventHandler(this.resetSourceImage_Click);
            // 
            // erosion
            // 
            this.erosion.AutoSize = true;
            this.erosion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.erosion.Enabled = false;
            this.erosion.Location = new System.Drawing.Point(624, 455);
            this.erosion.Name = "erosion";
            this.erosion.Size = new System.Drawing.Size(180, 40);
            this.erosion.TabIndex = 17;
            this.erosion.Text = "Erosion";
            this.erosion.UseVisualStyleBackColor = true;
            this.erosion.Click += new System.EventHandler(this.erosion_Click);
            // 
            // dilation
            // 
            this.dilation.AutoSize = true;
            this.dilation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dilation.Enabled = false;
            this.dilation.Location = new System.Drawing.Point(624, 501);
            this.dilation.Name = "dilation";
            this.dilation.Size = new System.Drawing.Size(180, 40);
            this.dilation.TabIndex = 18;
            this.dilation.Text = "Dilation";
            this.dilation.UseVisualStyleBackColor = true;
            this.dilation.Click += new System.EventHandler(this.dilation_Click);
            // 
            // scrollBarValue
            // 
            this.scrollBarValue.Enabled = false;
            this.scrollBarValue.Location = new System.Drawing.Point(930, 316);
            this.scrollBarValue.MaxLength = 3;
            this.scrollBarValue.Name = "scrollBarValue";
            this.scrollBarValue.Size = new System.Drawing.Size(50, 22);
            this.scrollBarValue.TabIndex = 11;
            this.scrollBarValue.Text = "128";
            this.scrollBarValue.TextChanged += new System.EventHandler(this.scrollBarValue_TextChanged);
            // 
            // saveImage
            // 
            this.saveImage.AutoSize = true;
            this.saveImage.Enabled = false;
            this.saveImage.Location = new System.Drawing.Point(810, 132);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(180, 40);
            this.saveImage.TabIndex = 21;
            this.saveImage.Text = "Save Image";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // imageEncryption
            // 
            this.imageEncryption.AutoSize = true;
            this.imageEncryption.Enabled = false;
            this.imageEncryption.Location = new System.Drawing.Point(810, 40);
            this.imageEncryption.Name = "imageEncryption";
            this.imageEncryption.Size = new System.Drawing.Size(180, 40);
            this.imageEncryption.TabIndex = 19;
            this.imageEncryption.Text = "Image Encryption";
            this.imageEncryption.UseVisualStyleBackColor = true;
            this.imageEncryption.Click += new System.EventHandler(this.imageEncryption_Click);
            // 
            // rotation
            // 
            this.rotation.AutoSize = true;
            this.rotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rotation.Enabled = false;
            this.rotation.Location = new System.Drawing.Point(624, 547);
            this.rotation.Name = "rotation";
            this.rotation.Size = new System.Drawing.Size(180, 40);
            this.rotation.TabIndex = 25;
            this.rotation.Text = "Rotation";
            this.rotation.UseVisualStyleBackColor = true;
            this.rotation.Click += new System.EventHandler(this.rotation_Click);
            // 
            // stretching
            // 
            this.stretching.AutoSize = true;
            this.stretching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stretching.Enabled = false;
            this.stretching.Location = new System.Drawing.Point(624, 593);
            this.stretching.Name = "stretching";
            this.stretching.Size = new System.Drawing.Size(180, 40);
            this.stretching.TabIndex = 26;
            this.stretching.Text = "Stretching";
            this.stretching.UseVisualStyleBackColor = true;
            this.stretching.Click += new System.EventHandler(this.stretching_Click);
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Enabled = false;
            this.labelDegree.Location = new System.Drawing.Point(810, 547);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(38, 12);
            this.labelDegree.TabIndex = 28;
            this.labelDegree.Text = "Degree";
            // 
            // numericDegree
            // 
            this.numericDegree.Enabled = false;
            this.numericDegree.Location = new System.Drawing.Point(812, 562);
            this.numericDegree.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericDegree.Name = "numericDegree";
            this.numericDegree.Size = new System.Drawing.Size(50, 22);
            this.numericDegree.TabIndex = 27;
            this.numericDegree.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelHorizontal
            // 
            this.labelHorizontal.AutoSize = true;
            this.labelHorizontal.Enabled = false;
            this.labelHorizontal.Location = new System.Drawing.Point(810, 593);
            this.labelHorizontal.Name = "labelHorizontal";
            this.labelHorizontal.Size = new System.Drawing.Size(54, 12);
            this.labelHorizontal.TabIndex = 30;
            this.labelHorizontal.Text = "Horizontal";
            // 
            // numericHorizontal
            // 
            this.numericHorizontal.DecimalPlaces = 1;
            this.numericHorizontal.Enabled = false;
            this.numericHorizontal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericHorizontal.Location = new System.Drawing.Point(812, 608);
            this.numericHorizontal.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericHorizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericHorizontal.Name = "numericHorizontal";
            this.numericHorizontal.Size = new System.Drawing.Size(50, 22);
            this.numericHorizontal.TabIndex = 29;
            this.numericHorizontal.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // labelVertical
            // 
            this.labelVertical.AutoSize = true;
            this.labelVertical.Enabled = false;
            this.labelVertical.Location = new System.Drawing.Point(864, 593);
            this.labelVertical.Name = "labelVertical";
            this.labelVertical.Size = new System.Drawing.Size(41, 12);
            this.labelVertical.TabIndex = 32;
            this.labelVertical.Text = "Vertical";
            // 
            // numericVertical
            // 
            this.numericVertical.DecimalPlaces = 1;
            this.numericVertical.Enabled = false;
            this.numericVertical.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericVertical.Location = new System.Drawing.Point(866, 608);
            this.numericVertical.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericVertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericVertical.Name = "numericVertical";
            this.numericVertical.Size = new System.Drawing.Size(50, 22);
            this.numericVertical.TabIndex = 31;
            this.numericVertical.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1004, 691);
            this.Controls.Add(this.labelVertical);
            this.Controls.Add(this.numericVertical);
            this.Controls.Add(this.labelHorizontal);
            this.Controls.Add(this.numericHorizontal);
            this.Controls.Add(this.labelDegree);
            this.Controls.Add(this.numericDegree);
            this.Controls.Add(this.stretching);
            this.Controls.Add(this.rotation);
            this.Controls.Add(this.imageEncryption);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.scrollBarValue);
            this.Controls.Add(this.dilation);
            this.Controls.Add(this.erosion);
            this.Controls.Add(this.resetSourceImage);
            this.Controls.Add(this.numericBlue);
            this.Controls.Add(this.numericGreen);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.numericRed);
            this.Controls.Add(this.edgeOverlapping);
            this.Controls.Add(this.sobelEdgeDetection);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.thresholding);
            this.Controls.Add(this.histogramEqualization);
            this.Controls.Add(this.medianFilter);
            this.Controls.Add(this.meanFilter);
            this.Controls.Add(this.colorTransformation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.colorExtraction);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImageProcessing";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVertical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button colorExtraction;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button colorTransformation;
        private System.Windows.Forms.Button meanFilter;
        private System.Windows.Forms.Button medianFilter;
        private System.Windows.Forms.Button histogramEqualization;
        private System.Windows.Forms.Button thresholding;
        private System.Windows.Forms.HScrollBar scrollBar;
        private System.Windows.Forms.Button sobelEdgeDetection;
        private System.Windows.Forms.Button edgeOverlapping;
        private System.Windows.Forms.NumericUpDown numericRed;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.NumericUpDown numericGreen;
        private System.Windows.Forms.NumericUpDown numericBlue;
        private System.Windows.Forms.Button resetSourceImage;
        private System.Windows.Forms.Button erosion;
        private System.Windows.Forms.Button dilation;
        private System.Windows.Forms.TextBox scrollBarValue;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button imageEncryption;
        private System.Windows.Forms.Button rotation;
        private System.Windows.Forms.Button stretching;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.NumericUpDown numericDegree;
        private System.Windows.Forms.Label labelHorizontal;
        private System.Windows.Forms.NumericUpDown numericHorizontal;
        private System.Windows.Forms.Label labelVertical;
        private System.Windows.Forms.NumericUpDown numericVertical;
    }
}

