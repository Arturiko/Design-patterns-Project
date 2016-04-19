using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Artur_308_Shay_300
{
    public class SavingPictureContext
    {
        private IImageSaveStrategy m_SaveStrategy;

        public void SavingImageOption(Image i_SourceImage)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files (*.bmp , *.jepg, *.png |*.bmp;*.jepg;*.png)";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var extension = Path.GetExtension(saveFileDialog.FileName);

            switch (extension.ToLower())
            {
                case ".bmp":
                    {
                        m_SaveStrategy = new BmpStrategy();
                        break;
                    }

                case ".jepg":
                    {
                        m_SaveStrategy = new JpegStrategy();
                        break;
                    }

                case ".png":
                    {
                        m_SaveStrategy = new PngStrategy();
                        break;
                    }

                default:
                    m_SaveStrategy = new JpegStrategy();
                    break;
            }

            m_SaveStrategy.SaveImage(i_SourceImage, Path.GetFullPath(saveFileDialog.FileName));
        }
    }
}
