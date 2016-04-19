using System.Drawing;

namespace Artur_308_Shay_300
{
   public interface IImageSaveStrategy
   {
       void SaveImage(Image i_Image, string i_GetFullPath);
   }
}
