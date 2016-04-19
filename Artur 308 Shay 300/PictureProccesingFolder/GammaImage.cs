using System;


namespace Artur_308_Shay_300
{
    public class GammaImage : PictureProccesing
    {
        protected override void colorProccesing(float i_Value)
        {
            i_Value = Normalize(i_Value, 0, 2, -100, 100);
            ColorRed = (float)Math.Pow(ColorRed, i_Value);
            ColorGreen = (float)Math.Pow(ColorGreen, i_Value);
            ColorBlue = (float)Math.Pow(ColorBlue, i_Value);
        }
    }
}
