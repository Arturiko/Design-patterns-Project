
namespace Artur_308_Shay_300
{
    public class ContrastImage : PictureProccesing
    {
        private float contrastCalculation(float i_Value, float i_Color)
        {
            return ((i_Value - 0.5f) * i_Color) + 0.5f;
        }

        protected override void colorProccesing(float i_Value)
        {
            i_Value = Normalize(i_Value, 0, 2, -100, 100);
            ColorRed = 255 * contrastCalculation(ColorRed / 255, i_Value);
            ColorGreen = 255 * contrastCalculation(ColorGreen / 255, i_Value);
            ColorBlue = 255 * contrastCalculation(ColorBlue / 255, i_Value);
        }
    }
}
