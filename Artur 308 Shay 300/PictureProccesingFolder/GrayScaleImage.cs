using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Artur_308_Shay_300
{
    public class GrayScaleImage : PictureProccesing
    {
        protected override void colorProccesing(float i_Value)
        {
            int grey = (int)((ColorRed * 0.3) + (ColorGreen * 0.59) + (ColorBlue * 0.11));

            ColorRed = grey;
            ColorGreen = grey;
            ColorBlue = grey;
        }
    }
}