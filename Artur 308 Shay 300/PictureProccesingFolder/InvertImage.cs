
namespace Artur_308_Shay_300
{
    public class InvertImage : PictureProccesing
    {
        protected override void colorProccesing(float i_Value)
        {
            ColorRed = 255 - ColorRed;
            ColorGreen = 255 - ColorGreen;
            ColorBlue = 255 - ColorBlue;
        }
    }
}
