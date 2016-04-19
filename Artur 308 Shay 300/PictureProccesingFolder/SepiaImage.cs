
namespace Artur_308_Shay_300
{
    public class SepiaImage : PictureProccesing
    {
        protected override void colorProccesing(float i_Value)
        {
            float tcr = ColorRed, tcg = ColorGreen, tcb = ColorBlue;
            ColorRed = (tcr * 0.393f) + (tcg * 0.769f) + (tcb * 0.189f);
            ColorGreen = (tcr * 0.349f) + (tcg * 0.686f) + (tcb * 0.168f);
            ColorBlue = (tcr * 0.272f) + (tcg * 0.534f) + (tcb * 0.131f);
        }
    }
}
