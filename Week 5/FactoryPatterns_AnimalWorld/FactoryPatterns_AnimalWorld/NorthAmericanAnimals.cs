using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns_AnimalWorld
{
    //=======================================================================
    //NorthAmericanAnimals holds multiple classes one for each north american
    //animal that is being used
    //Each animal class sets the information for that animal
    //=======================================================================
    public class Bison : Animal
    {
        public Bison()
        {
            name = "Bison";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("images/bison.jpg");
        }
    }

    public class Wolf : Animal
    {
        public Wolf()
        {
            name = "Wolf";
            family = "Carnivore";
            food = "Rabits";
            image = new Bitmap("images/wolf.jpg");
        }
    }

    public class Eagle : Animal
    {
        public Eagle()
        {
            name = "Eagle";
            family = "Carnivore";
            food = "Fish";
            image = new Bitmap("images/eagle.jpg");
        }
    }
}
