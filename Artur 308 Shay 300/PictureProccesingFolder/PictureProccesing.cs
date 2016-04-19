using System;
using System.Drawing;

namespace Artur_308_Shay_300
{
    public abstract class PictureProccesing
    {
        protected float ColorRed { get; set; }

        protected float ColorGreen { get; set; }

        protected float ColorBlue { get; set; }

        protected float ColorAlpha { get; set; }

        private float distEnsures(float i_X1, float i_X2)
        {
            return (float)Math.Sqrt(Math.Pow(i_X2 - i_X1, 2));
        }

        public float Normalize(float i_Value, float i_DestMinVal, float i_DestMaxVal, float i_SourceMinVal, float i_SourceMaxVal)
        {
            float sourceDist = distEnsures(i_SourceMinVal, i_SourceMaxVal);
            float destDist = distEnsures(i_DestMinVal, i_DestMaxVal);
            float ratio = destDist / sourceDist;
            i_Value = clamp(i_Value, i_SourceMinVal, i_SourceMaxVal);
            return i_DestMinVal + ((i_Value - i_SourceMinVal) * ratio);
        }

        private float clamp(float i_Value, float i_MinVal, float i_MaxVal)
        {
            return Math.Min(i_MaxVal, Math.Max(i_MinVal, i_Value));
        }

        internal Bitmap ImageProccesing(Bitmap io_SourceImage, float i_Value)
        {
            for (int i = 0; i < io_SourceImage.Width; i++)
            {
                for (int j = 0; j < io_SourceImage.Height; j++)
                {
                    Color color = io_SourceImage.GetPixel(i, j);
                    ColorRed = color.R;
                    ColorGreen = color.G;
                    ColorBlue = color.B;
                    ColorAlpha = color.A;

                    colorProccesing(i_Value);

                    io_SourceImage.SetPixel(i, j, Color.FromArgb((int)clamp(ColorAlpha, 0, 255), (int)clamp(ColorRed, 0, 255), (int)clamp(ColorGreen, 0, 255), (int)clamp(ColorBlue, 0, 255)));
                }
            }

            return io_SourceImage;
        }

        protected abstract void colorProccesing(float i_Value);
    }
}
