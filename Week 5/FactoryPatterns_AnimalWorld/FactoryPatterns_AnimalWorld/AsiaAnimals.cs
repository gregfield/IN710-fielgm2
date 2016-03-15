using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns_AnimalWorld
{
    //===================================================================
    //Asianimals holds multiple classes one for each asian animal that
    //is being usedEach animal class sets the information for that animal
    //===================================================================
    public class GiantPanda : Animal
    {
        public GiantPanda()
        {
            name = "Giant Panda";
            family = "Herbivore";
            food = "Bamboo";
            image = new Bitmap("images/giantpanda.jpg");
        }
    }

    public class AsianElephant : Animal
    {
        public AsianElephant()
        {
            name = "Asian Elephant";
            family = "Herbivore";
            food = "Malvales";
            image = new Bitmap("images/asainelephants.jpg");
        }
    }

    public class MalayanTapir : Animal
    {
        public MalayanTapir()
        {
            name = "Malayan Tapir";
            family = "Herbivore";
            food = "Leaves";
            image = new Bitmap("images/malayantapir.jpg");
        }
    }
}
