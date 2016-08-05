using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Gray_Scott_Simulator
{
    public enum ColourChoices { GrayScale, Colour1, Colour2}
    public class ColourFactory
    {
        //makes the colour scheme that is to be used
        public IColourPicker MakeColour(ColourChoices choice)
        {
            IColourPicker newColour = new GrayScaleColours();

            switch (choice)
            {
                case ColourChoices.GrayScale:
                    newColour = new GrayScaleColours();
                    break;
                case ColourChoices.Colour1:
                    newColour = new ColourScheme1();
                    break;
                case ColourChoices.Colour2:
                    newColour = new ColourScheme2();
                    break;
            }
            return newColour;
        }
    }
}
