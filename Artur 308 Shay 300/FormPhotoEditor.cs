using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Artur_308_Shay_300
{
    public partial class FormPhotoEditor : Form
    {
        private const string k_PromotingPostEditedPhoto = "Add your status with the edited picture here!";
        private readonly User r_ChosenFriendToEdit;
        private readonly ImageManipulate r_ImageManipulate;
        private Bitmap m_SourceImage;
        private PictureProccesing m_PictureProccesing;

        public FormPhotoEditor()
        {
            InitializeComponent();
        }

        public FormPhotoEditor(User i_ChosenFriendToEdit)
        {
            InitializeComponent();
            r_ChosenFriendToEdit = i_ChosenFriendToEdit;
            r_ImageManipulate = new ImageManipulate();
            initFormAndStartEditing();
        }

        private void initFormAndStartEditing()
        {
            {
                pictureBoxOriginalPic.LoadAsync(r_ChosenFriendToEdit.PictureLargeURL);
                pictureBoxEditablePic.LoadAsync(r_ChosenFriendToEdit.PictureLargeURL);
            }
        }

        private void trackBarGamma_ValueChanged(object sender, EventArgs e)
        {
            textBoxGamma.Text = TrackBarGamma.Value.ToString();
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);
            m_PictureProccesing = new GammaImage();
            pictureBoxEditablePic.Image = m_PictureProccesing.ImageProccesing(m_SourceImage, TrackBarGamma.Value / 20f);
        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            textBoxBrightness.Text = TrackBarBrightness.Value.ToString();
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);
            m_PictureProccesing = new BrightnessImage();
            pictureBoxEditablePic.Image = m_PictureProccesing.ImageProccesing(m_SourceImage, TrackBarBrightness.Value / 15f);
        }

        private void trackBarContrast_ValueChanged(object sender, EventArgs e)
        {
            textBoxContrast.Text = TrackBarContrast.Value.ToString();
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);
            m_PictureProccesing = new ContrastImage();
            pictureBoxEditablePic.Image = m_PictureProccesing.ImageProccesing(m_SourceImage, TrackBarContrast.Value);
        }

        private void buttonUploadEditablePhoto_Click(object sender, EventArgs e)
        {
            string fileNamingAfterEdit = "imgAfterEdit.Jpeg";
            string filePathToSaveAt = AppDomain.CurrentDomain.BaseDirectory + "\\" + fileNamingAfterEdit;

            pictureBoxEditablePic.Image.Save(filePathToSaveAt, ImageFormat.Jpeg);
            string statusToPost = textBoxStatusWithPicture.Text;
            if (textBoxStatusWithPicture.Text.Equals(k_PromotingPostEditedPhoto))
            {
                statusToPost = string.Empty;
            }

            CurrentLoggedInUser.Instance.CurentUser.PostPhoto(filePathToSaveAt, statusToPost, null, string.Empty);
            textBoxStatusWithPicture.Text = k_PromotingPostEditedPhoto;
            MessageBox.Show("Picture Posted !!");
        }

        private void textBoxStatusWithPicture_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxStatusWithPicture.Text = string.Empty;
        }

        private void buttonResetImage_Click(object sender, EventArgs e)
        {
            pictureBoxEditablePic.Image = pictureBoxOriginalPic.Image;
            textBoxBrightness.Text = 0.ToString();
            textBoxContrast.Text = 0.ToString();
            textBoxContrast.Text = 0.ToString();
            TrackBarBrightness.Value = 0;
            TrackBarContrast.Value = 0;
            TrackBarGamma.Value = 0;
        }

        private void buttonInvertColors_Click(object sender, EventArgs e)
        {
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);

            m_PictureProccesing = new InvertImage();
            Bitmap destImage = m_PictureProccesing.ImageProccesing(m_SourceImage, 0);
            pictureBoxEditablePic.Image = destImage;
        }

        private void buttonGrayScale_Click(object sender, EventArgs e)
        {
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);
            m_PictureProccesing = new GrayScaleImage();
            Bitmap destImage = m_PictureProccesing.ImageProccesing(m_SourceImage, 0);
            pictureBoxEditablePic.Image = destImage;
        }

        private void buttonSepia_Click(object sender, EventArgs e)
        {
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);
            m_PictureProccesing = new SepiaImage();
            Bitmap destImage = m_PictureProccesing.ImageProccesing(m_SourceImage, 0);
            pictureBoxEditablePic.Image = destImage;
        }

        private void buttonMirror_Click(object sender, EventArgs e)
        {
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);
            pictureBoxEditablePic.Image = r_ImageManipulate.MirrorImage(m_SourceImage);
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);
            pictureBoxEditablePic.Image = r_ImageManipulate.RotateImage(m_SourceImage);
        }

        private void buttonFlip_Click(object sender, EventArgs e)
        {
            m_SourceImage = new Bitmap(pictureBoxEditablePic.Image);
            pictureBoxEditablePic.Image = r_ImageManipulate.FlipImage(m_SourceImage);
        }

        private void buttonSaveAsAnImage_Click(object sender, EventArgs e)
        {
            SavingPictureContext savingImageOption = new SavingPictureContext();
            savingImageOption.SavingImageOption(pictureBoxEditablePic.Image);
        }
    }
}