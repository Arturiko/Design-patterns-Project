
namespace Artur_308_Shay_300
{
    public class BrightnessImage : PictureProccesing
    {
        protected override void colorProccesing(float i_Value)
        {
            i_Value = Normalize(i_Value, -255, 255, -100, 100);
            ColorRed += i_Value;
            ColorGreen += i_Value;
            ColorBlue += i_Value;
        }
    }
}
