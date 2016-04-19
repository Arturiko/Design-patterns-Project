using System.Drawing;
using System.Drawing.Imaging;

namespace Artur_308_Shay_300
{
    public class BmpStrategy : IImageSaveStrategy
    {
        public void SaveImage(Image i_Image, string i_GetFullPath)
        {
            i_Image.Save(i_GetFullPath, ImageFormat.Bmp);
        }
    }
}
