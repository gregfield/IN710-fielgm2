using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns_AnimalWorld
{
    //=====================================================================
    //Animals holds multiple classes one for each animal that is being used
    //Each animal class sets the information for that animal
    //=====================================================================
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

    public class Koala: Animal
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


}
