﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Gray_Scott_Simulator
{
    //Interface to hold colour scheme
    public interface IColourPicker
    {
        Color MakeCellColour(double b);
    }
}
