﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPatterns_AnimalWorld
{
    //===============================================
    //Continents creates a new animal factory for the 
    //continent that has been selected
    //===============================================
    public class Australian : Continent
    {
        public Australian(ListBox displayBox, Graphics canvas, int nAnimalTypes)
            : base(displayBox, canvas, nAnimalTypes)
        {
            animalFactory = new AustralianAnimalFactory();
        }
    }

    public class NorthAmerica : Continent
    {
        public NorthAmerica(ListBox displayBox, Graphics canvas, int nAnimalTypes)
            :base(displayBox, canvas, nAnimalTypes)
        {
            animalFactory = new NorthAmericanAnimalFactory();
        }
    }

    public class Asia : Continent
    {
        public Asia(ListBox displayBox, Graphics canvas, int nAnimalTypes)
            : base(displayBox, canvas, nAnimalTypes)
        {
            animalFactory = new AsianAnimalFactory();
        }
    }
}
