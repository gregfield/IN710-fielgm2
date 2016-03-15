using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns_AnimalWorld
{
    //================================================================
    //AustralianAnimals holds multiple classes one for each australian
    //animal that is being used
    //Each animal class sets the information for that animal
    //================================================================
    public class Koala : Animal
    {
        public Koala()
        {
            name = "Koala";
            family = "Herbivore";
            food = "Leaves";
            image = new Bitmap("images/koala.jpg");
        }
    }

    public class Crocodile : Animal
    {
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "Chickens";
            image = new Bitmap("images/crocodile.jpg");
        }
    }

    public class Kangaroo : Animal
    {
        public Kangaroo()
        {
            name = "Kangaroo";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("images/kangaroo.jpg");
        }
    }

    public class TasmanianDevil : Animal
    {
        public TasmanianDevil()
        {
            name = "Tasmanian Devil";
            family = "Carnivore";
            food = "Wombat";
            image = new Bitmap("images/tasmaniandevil.jpg");
        }
    }
}
