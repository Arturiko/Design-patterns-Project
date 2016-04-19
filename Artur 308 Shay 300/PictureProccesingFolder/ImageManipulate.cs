using System.Drawing;

namespace Artur_308_Shay_300
{
    public class ImageManipulate
    {
        public Bitmap FlipImage(Bitmap io_Image)
        {
            io_Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            return io_Image;
        }

        public Bitmap RotateImage(Bitmap io_Image)
        {
            io_Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return io_Image;
        }

        public Bitmap MirrorImage(Bitmap i_SourceImage)
        {
            Bitmap destImage = new Bitmap(i_SourceImage.Width * 2, i_SourceImage.Height);

            for (int y = 0; y < i_SourceImage.Height; y++)
            {
                for (int lx = 0, rx = (i_SourceImage.Width * 2) - 1; lx < i_SourceImage.Width; lx++, rx--)
                {
                    Color color = i_SourceImage.GetPixel(lx, y);
                    destImage.SetPixel(rx, y, color);
                    destImage.SetPixel(lx, y, color);
                }
            }

            return destImage;
        }
    }
}
