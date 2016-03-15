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
        //number of animals displayed on the screen
        public const int ANIMAL_COUNT = 4;

        protected ListBox displayBox;
        protected Random randomGen;
        protected int nAminalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        public Continent(ListBox displayBox, Graphics canvas, int nAnimalTypes)
        {
            this.displayBox = displayBox;
            this.canvas = canvas;
            this.nAminalTypes = nAnimalTypes;
            randomGen = new Random();
        }
        
        //creats new animals and displays pictures anfd info to screen
        public void runSimulation()
        {
            Animal currentAnimal;

            for (int i = 0; i < ANIMAL_COUNT; i++)
            {
                int animalChoice = randomGen.Next(nAminalTypes);

                currentAnimal = animalFactory.createAnimal(animalChoice);

                displayBox.Items.Add(currentAnimal.ToString());
                canvas.DrawImage(currentAnimal.image, 40, 10 + (i * 110), 100, 100);
            }
        }
    }
}
