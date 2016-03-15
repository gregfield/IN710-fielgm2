using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns_AnimalWorld
{
    public class Animal
    {
        //=====================================================
        //Animal class hold all the information about an animal
        //=====================================================
        public string name;
        public string family;
        public string food;
        public Bitmap image { get; set; }

        public override string ToString()
        {
            string displayString = "I am " + name;
            displayString += ". I am a " + family;
            displayString += ". I eat " + food + ".";
            return displayString;
        }
    }
}
