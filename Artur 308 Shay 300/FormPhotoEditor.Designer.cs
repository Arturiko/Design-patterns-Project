using System.Windows.Forms;

namespace Artur_308_Shay_300
{
    public partial class FormPhotoEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxOriginalPic = new System.Windows.Forms.PictureBox();
            this.labelOriginalPictureText = new System.Windows.Forms.Label();
            this.labelEditablePictureText = new System.Windows.Forms.Label();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.labelBrightnessText = new System.Windows.Forms.Label();
            this.groupBoxBrightnessAndContrast = new System.Windows.Forms.GroupBox();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.labelGammaText = new System.Windows.Forms.Label();
            this.TrackBarGamma = new System.Windows.Forms.TrackBar();
            this.buttonResetImage = new System.Windows.Forms.Button();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.labelContrastText = new System.Windows.Forms.Label();
            this.TrackBarContrast = new System.Windows.Forms.TrackBar();
            this.buttonUploadEditablePhoto = new System.Windows.Forms.Button();
            this.textBoxStatusWithPicture = new System.Windows.Forms.TextBox();
            this.groupBoxAutoProccessing = new System.Windows.Forms.GroupBox();
            this.buttonSepia = new System.Windows.Forms.Button();
            this.buttonGrayScale = new System.Windows.Forms.Button();
            this.buttonInvertColors = new System.Windows.Forms.Button();
            this.groupBoxImageManipulating = new System.Windows.Forms.GroupBox();
            this.buttonFlip = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonMirror = new System.Windows.Forms.Button();
            this.pictureBoxEditablePic = new System.Windows.Forms.PictureBox();
            this.buttonSaveAsAnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            this.groupBoxBrightnessAndContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).BeginInit();
            this.groupBoxAutoProccessing.SuspendLayout();
            this.groupBoxImageManipulating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditablePic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginalPic
            // 
            this.pictureBoxOriginalPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxOriginalPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginalPic.ErrorImage = null;
            this.pictureBoxOriginalPic.InitialImage = null;
            this.pictureBoxOriginalPic.Location = new System.Drawing.Point(12, 334);
            this.pictureBoxOriginalPic.Name = "pictureBoxOriginalPic";
            this.pictureBoxOriginalPic.Size = new System.Drawing.Size(300, 314);
            this.pictureBoxOriginalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginalPic.TabIndex = 0;
            this.pictureBoxOriginalPic.TabStop = false;
            // 
            // labelOriginalPictureText
            // 
            this.labelOriginalPictureText.AutoSize = true;
            this.labelOriginalPictureText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelOriginalPictureText.Location = new System.Drawing.Point(12, 318);
            this.labelOriginalPictureText.Name = "labelOriginalPictureText";
            this.labelOriginalPictureText.Size = new System.Drawing.Size(99, 13);
            this.labelOriginalPictureText.TabIndex = 1;
            this.labelOriginalPictureText.Text = "Original Picture :";
            // 
            // labelEditablePictureText
            // 
            this.labelEditablePictureText.AutoSize = true;
            this.labelEditablePictureText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelEditablePictureText.Location = new System.Drawing.Point(506, 318);
            this.labelEditablePictureText.Name = "labelEditablePictureText";
            this.labelEditablePictureText.Size = new System.Drawing.Size(101, 13);
            this.labelEditablePictureText.TabIndex = 3;
            this.labelEditablePictureText.Text = "Editable Picture :";
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.Location = new System.Drawing.Point(9, 48);
            this.TrackBarBrightness.Maximum = 100;
            this.TrackBarBrightness.Minimum = -100;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(149, 45);
            this.TrackBarBrightness.TabIndex = 4;
            this.TrackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            // 
            // labelBrightnessText
            // 
            this.labelBrightnessText.AutoSize = true;
            this.labelBrightnessText.Location = new System.Drawing.Point(6, 32);
            this.labelBrightnessText.Name = "labelBrightnessText";
            this.labelBrightnessText.Size = new System.Drawing.Size(62, 13);
            this.labelBrightnessText.TabIndex = 5;
            this.labelBrightnessText.Text = "Brightness :";
            // 
            // groupBoxBrightnessAndContrast
            // 
            this.groupBoxBrightnessAndContrast.Controls.Add(this.textBoxGamma);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.labelGammaText);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.TrackBarGamma);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.buttonResetImage);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.textBoxContrast);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.textBoxBrightness);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.labelContrastText);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.TrackBarContrast);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.labelBrightnessText);
            this.groupBoxBrightnessAndContrast.Controls.Add(this.TrackBarBrightness);
            this.groupBoxBrightnessAndContrast.Location = new System.Drawing.Point(309, 12);
            this.groupBoxBrightnessAndContrast.Name = "groupBoxBrightnessAndContrast";
            this.groupBoxBrightnessAndContrast.Size = new System.Drawing.Size(202, 286);
            this.groupBoxBrightnessAndContrast.TabIndex = 7;
            this.groupBoxBrightnessAndContrast.TabStop = false;
            this.groupBoxBrightnessAndContrast.Text = "Brightness / Contrast";
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(164, 169);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.ReadOnly = true;
            this.textBoxGamma.Size = new System.Drawing.Size(30, 20);
            this.textBoxGamma.TabIndex = 14;
            this.textBoxGamma.Text = "0";
            this.textBoxGamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGammaText
            // 
            this.labelGammaText.AutoSize = true;
            this.labelGammaText.Location = new System.Drawing.Point(6, 153);
            this.labelGammaText.Name = "labelGammaText";
            this.labelGammaText.Size = new System.Drawing.Size(49, 13);
            this.labelGammaText.TabIndex = 13;
            this.labelGammaText.Text = "Gamma :";
            // 
            // TrackBarGamma
            // 
            this.TrackBarGamma.Location = new System.Drawing.Point(9, 169);
            this.TrackBarGamma.Maximum = 100;
            this.TrackBarGamma.Minimum = -100;
            this.TrackBarGamma.Name = "TrackBarGamma";
            this.TrackBarGamma.Size = new System.Drawing.Size(149, 45);
            this.TrackBarGamma.TabIndex = 12;
            this.TrackBarGamma.ValueChanged += new System.EventHandler(this.trackBarGamma_ValueChanged);
            // 
            // buttonResetImage
            // 
            this.buttonResetImage.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonResetImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonResetImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonResetImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonResetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonResetImage.ForeColor = System.Drawing.Color.Snow;
            this.buttonResetImage.Location = new System.Drawing.Point(9, 220);
            this.buttonResetImage.Name = "buttonResetImage";
            this.buttonResetImage.Size = new System.Drawing.Size(185, 60);
            this.buttonResetImage.TabIndex = 11;
            this.buttonResetImage.Text = "Reset Image";
            this.buttonResetImage.UseVisualStyleBackColor = false;
            this.buttonResetImage.Click += new System.EventHandler(this.buttonResetImage_Click);
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Location = new System.Drawing.Point(164, 109);
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.ReadOnly = true;
            this.textBoxContrast.Size = new System.Drawing.Size(30, 20);
            this.textBoxContrast.TabIndex = 10;
            this.textBoxContrast.Text = "0";
            this.textBoxContrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Location = new System.Drawing.Point(164, 48);
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.ReadOnly = true;
            this.textBoxBrightness.Size = new System.Drawing.Size(30, 20);
            this.textBoxBrightness.TabIndex = 9;
            this.textBoxBrightness.Text = "0";
            this.textBoxBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelContrastText
            // 
            this.labelContrastText.AutoSize = true;
            this.labelContrastText.Location = new System.Drawing.Point(6, 93);
            this.labelContrastText.Name = "labelContrastText";
            this.labelContrastText.Size = new System.Drawing.Size(52, 13);
            this.labelContrastText.TabIndex = 8;
            this.labelContrastText.Text = "Contrast :";
            // 
            // TrackBarContrast
            // 
            this.TrackBarContrast.Location = new System.Drawing.Point(9, 109);
            this.TrackBarContrast.Maximum = 100;
            this.TrackBarContrast.Minimum = -100;
            this.TrackBarContrast.Name = "TrackBarContrast";
            this.TrackBarContrast.Size = new System.Drawing.Size(149, 45);
            this.TrackBarContrast.TabIndex = 7;
            this.TrackBarContrast.ValueChanged += new System.EventHandler(this.trackBarContrast_ValueChanged);
            // 
            // buttonUploadEditablePhoto
            // 
            this.buttonUploadEditablePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonUploadEditablePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUploadEditablePhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonUploadEditablePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonUploadEditablePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadEditablePhoto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonUploadEditablePhoto.ForeColor = System.Drawing.Color.Snow;
            this.buttonUploadEditablePhoto.Location = new System.Drawing.Point(333, 455);
            this.buttonUploadEditablePhoto.Name = "buttonUploadEditablePhoto";
            this.buttonUploadEditablePhoto.Size = new System.Drawing.Size(157, 71);
            this.buttonUploadEditablePhoto.TabIndex = 8;
            this.buttonUploadEditablePhoto.Text = "Upload as a status";
            this.buttonUploadEditablePhoto.UseVisualStyleBackColor = false;
            this.buttonUploadEditablePhoto.Click += new System.EventHandler(this.buttonUploadEditablePhoto_Click);
            // 
            // textBoxStatusWithPicture
            // 
            this.textBoxStatusWithPicture.Location = new System.Drawing.Point(334, 334);
            this.textBoxStatusWithPicture.Multiline = true;
            this.textBoxStatusWithPicture.Name = "textBoxStatusWithPicture";
            this.textBoxStatusWithPicture.Size = new System.Drawing.Size(156, 115);
            this.textBoxStatusWithPicture.TabIndex = 9;
            this.textBoxStatusWithPicture.Text = "Add your status with the edited picture here!";
            this.textBoxStatusWithPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxStatusWithPicture_MouseClick);
            // 
            // groupBoxAutoProccessing
            // 
            this.groupBoxAutoProccessing.Controls.Add(this.buttonSepia);
            this.groupBoxAutoProccessing.Controls.Add(this.buttonGrayScale);
            this.groupBoxAutoProccessing.Controls.Add(this.buttonInvertColors);
            this.groupBoxAutoProccessing.Location = new System.Drawing.Point(15, 12);
            this.groupBoxAutoProccessing.Name = "groupBoxAutoProccessing";
            this.groupBoxAutoProccessing.Size = new System.Drawing.Size(200, 286);
            this.groupBoxAutoProccessing.TabIndex = 10;
            this.groupBoxAutoProccessing.TabStop = false;
            this.groupBoxAutoProccessing.Text = "Auto proccessing";
            // 
            // buttonSepia
            // 
            this.buttonSepia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonSepia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSepia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonSepia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSepia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSepia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSepia.ForeColor = System.Drawing.Color.Snow;
            this.buttonSepia.Location = new System.Drawing.Point(6, 207);
            this.buttonSepia.Name = "buttonSepia";
            this.buttonSepia.Size = new System.Drawing.Size(188, 51);
            this.buttonSepia.TabIndex = 13;
            this.buttonSepia.Text = "Sepia";
            this.buttonSepia.UseVisualStyleBackColor = false;
            this.buttonSepia.Click += new System.EventHandler(this.buttonSepia_Click);
            // 
            // buttonGrayScale
            // 
            this.buttonGrayScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonGrayScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGrayScale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonGrayScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonGrayScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrayScale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonGrayScale.ForeColor = System.Drawing.Color.Snow;
            this.buttonGrayScale.Location = new System.Drawing.Point(6, 115);
            this.buttonGrayScale.Name = "buttonGrayScale";
            this.buttonGrayScale.Size = new System.Drawing.Size(188, 51);
            this.buttonGrayScale.TabIndex = 12;
            this.buttonGrayScale.Text = "GrayScale";
            this.buttonGrayScale.UseVisualStyleBackColor = false;
            this.buttonGrayScale.Click += new System.EventHandler(this.buttonGrayScale_Click);
            // 
            // buttonInvertColors
            // 
            this.buttonInvertColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonInvertColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonInvertColors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonInvertColors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonInvertColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvertColors.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonInvertColors.ForeColor = System.Drawing.Color.Snow;
            this.buttonInvertColors.Location = new System.Drawing.Point(6, 32);
            this.buttonInvertColors.Name = "buttonInvertColors";
            this.buttonInvertColors.Size = new System.Drawing.Size(188, 51);
            this.buttonInvertColors.TabIndex = 11;
            this.buttonInvertColors.Text = "Invert Colors";
            this.buttonInvertColors.UseVisualStyleBackColor = false;
            this.buttonInvertColors.Click += new System.EventHandler(this.buttonInvertColors_Click);
            // 
            // groupBoxImageManipulating
            // 
            this.groupBoxImageManipulating.Controls.Add(this.buttonFlip);
            this.groupBoxImageManipulating.Controls.Add(this.buttonRotate);
            this.groupBoxImageManipulating.Controls.Add(this.buttonMirror);
            this.groupBoxImageManipulating.Location = new System.Drawing.Point(611, 12);
            this.groupBoxImageManipulating.Name = "groupBoxImageManipulating";
            this.groupBoxImageManipulating.Size = new System.Drawing.Size(200, 286);
            this.groupBoxImageManipulating.TabIndex = 14;
            this.groupBoxImageManipulating.TabStop = false;
            this.groupBoxImageManipulating.Text = "Image manipulate";
            // 
            // buttonFlip
            // 
            this.buttonFlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFlip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonFlip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonFlip.ForeColor = System.Drawing.Color.Snow;
            this.buttonFlip.Location = new System.Drawing.Point(6, 207);
            this.buttonFlip.Name = "buttonFlip";
            this.buttonFlip.Size = new System.Drawing.Size(188, 51);
            this.buttonFlip.TabIndex = 13;
            this.buttonFlip.Text = "Flip";
            this.buttonFlip.UseVisualStyleBackColor = false;
            this.buttonFlip.Click += new System.EventHandler(this.buttonFlip_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRotate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonRotate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonRotate.ForeColor = System.Drawing.Color.Snow;
            this.buttonRotate.Location = new System.Drawing.Point(6, 115);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(188, 51);
            this.buttonRotate.TabIndex = 12;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = false;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonMirror
            // 
            this.buttonMirror.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonMirror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMirror.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonMirror.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonMirror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMirror.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonMirror.ForeColor = System.Drawing.Color.Snow;
            this.buttonMirror.Location = new System.Drawing.Point(6, 32);
            this.buttonMirror.Name = "buttonMirror";
            this.buttonMirror.Size = new System.Drawing.Size(188, 51);
            this.buttonMirror.TabIndex = 11;
            this.buttonMirror.Text = "Mirror";
            this.buttonMirror.UseVisualStyleBackColor = false;
            this.buttonMirror.Click += new System.EventHandler(this.buttonMirror_Click);
            // 
            // pictureBoxEditablePic
            // 
            this.pictureBoxEditablePic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxEditablePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEditablePic.ErrorImage = null;
            this.pictureBoxEditablePic.InitialImage = null;
            this.pictureBoxEditablePic.Location = new System.Drawing.Point(509, 334);
            this.pictureBoxEditablePic.Name = "pictureBoxEditablePic";
            this.pictureBoxEditablePic.Size = new System.Drawing.Size(302, 314);
            this.pictureBoxEditablePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditablePic.TabIndex = 2;
            this.pictureBoxEditablePic.TabStop = false;
            // 
            // buttonSaveAsAnImage
            // 
            this.buttonSaveAsAnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonSaveAsAnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveAsAnImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(90)))), ((int)(((byte)(139)))));
            this.buttonSaveAsAnImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSaveAsAnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAsAnImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSaveAsAnImage.ForeColor = System.Drawing.Color.Snow;
            this.buttonSaveAsAnImage.Location = new System.Drawing.Point(334, 577);
            this.buttonSaveAsAnImage.Name = "buttonSaveAsAnImage";
            this.buttonSaveAsAnImage.Size = new System.Drawing.Size(157, 71);
            this.buttonSaveAsAnImage.TabIndex = 15;
            this.buttonSaveAsAnImage.Text = "Save editable image";
            this.buttonSaveAsAnImage.UseVisualStyleBackColor = false;
            this.buttonSaveAsAnImage.Click += new System.EventHandler(this.buttonSaveAsAnImage_Click);
            // 
            // FormPhotoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 660);
            this.Controls.Add(this.buttonSaveAsAnImage);
            this.Controls.Add(this.groupBoxImageManipulating);
            this.Controls.Add(this.groupBoxAutoProccessing);
            this.Controls.Add(this.textBoxStatusWithPicture);
            this.Controls.Add(this.buttonUploadEditablePhoto);
            this.Controls.Add(this.groupBoxBrightnessAndContrast);
            this.Controls.Add(this.labelEditablePictureText);
            this.Controls.Add(this.pictureBoxEditablePic);
            this.Controls.Add(this.labelOriginalPictureText);
            this.Controls.Add(this.pictureBoxOriginalPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPhotoEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            this.groupBoxBrightnessAndContrast.ResumeLayout(false);
            this.groupBoxBrightnessAndContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).EndInit();
            this.groupBoxAutoProccessing.ResumeLayout(false);
            this.groupBoxImageManipulating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditablePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginalPic;
        private System.Windows.Forms.Label labelOriginalPictureText;
        private System.Windows.Forms.PictureBox pictureBoxEditablePic;
        private System.Windows.Forms.Label labelEditablePictureText;
        private System.Windows.Forms.TrackBar TrackBarBrightness;
        private System.Windows.Forms.Label labelBrightnessText;
        private System.Windows.Forms.GroupBox groupBoxBrightnessAndContrast;
        private System.Windows.Forms.Label labelContrastText;
        private System.Windows.Forms.TrackBar TrackBarContrast;
        private System.Windows.Forms.Button buttonUploadEditablePhoto;
        private System.Windows.Forms.TextBox textBoxBrightness;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.TextBox textBoxStatusWithPicture;
        private System.Windows.Forms.Button buttonResetImage;
        private System.Windows.Forms.GroupBox groupBoxAutoProccessing;
        private System.Windows.Forms.Button buttonInvertColors;
        private System.Windows.Forms.Button buttonGrayScale;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.Label labelGammaText;
        private System.Windows.Forms.TrackBar TrackBarGamma;
        private System.Windows.Forms.Button buttonSepia;
        private System.Windows.Forms.GroupBox groupBoxImageManipulating;
        private System.Windows.Forms.Button buttonFlip;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonMirror;
        private Button buttonSaveAsAnImage;
    }
}