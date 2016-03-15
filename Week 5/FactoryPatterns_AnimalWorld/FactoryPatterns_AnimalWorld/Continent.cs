using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPatterns_AnimalWorld
{
    //=====================================================
    //Continent class does lots
    //=====================================================
    public abstract class Continent
    {
        public const int ANIMAL_COUNT = 4;

        protected RichTextBox displayBox;
        protected Random randomGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        public Continent(RichTextBox displayBox, Random randomGen, int nAnimalTypes, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.randomGen = randomGen;
            this.nAnimalTypes = nAnimalTypes;
            this.canvas = canvas;
        }

        public void runSimulation()
        {

        }
    }
}
