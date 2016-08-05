using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment1_Gray_Scott_Simulator
{
    //makes colours in grayscale
    public class GrayScaleColours : IColourPicker
    {
        public Color MakeCellColour(double b)
        {
            int colourValueB = Convert.ToInt32(b * 255);
            return Color.FromArgb(colourValueB, colourValueB, colourValueB);
        }
    }
    //first colour scheme
    public class ColourScheme1 : IColourPicker
    {
        public Color MakeCellColour(double b)
        {
            int colourValueB = Convert.ToInt32(b * 255);
            return Color.FromArgb(colourValueB, colourValueB, 128);
        }
    }
    //second colour scheme
    public class ColourScheme2 : IColourPicker
    {
        public Color MakeCellColour(double b)
        {
            int colourValueB = Convert.ToInt32(b * 255);
            return Color.FromArgb(0, 128, colourValueB);
        }
    }
}
