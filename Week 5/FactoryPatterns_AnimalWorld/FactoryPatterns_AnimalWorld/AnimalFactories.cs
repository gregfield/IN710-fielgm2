﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns_AnimalWorld
{
    //=========================================================
    //These factories select what type of animal should be made
    //=========================================================
    public class AustralianAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Koala();
                    break;
                case 1:
                    newAnimal = new Crocodile();
                    break;
                case 2:
                    newAnimal = new Kangaroo();
                    break;
                case 3:
                    newAnimal = new TasmanianDevil();
                    break;
            }
            return newAnimal;
        }
    }

    public class NorthAmericanAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch(animalCode)
            {
                case 0:
                    newAnimal = new Bison();
                    break;
                case 1:
                    newAnimal = new Wolf();
                    break;
                case 2:
                    newAnimal = new Eagle();
                    break;
                case 3:
                    newAnimal = new Groundhog();
                    break;
                 
            }
            return newAnimal;
        }
    }

    public class AsianAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new GiantPanda();
                    break;
                case 1:
                    newAnimal = new AsianElephant();
                    break;
                case 2:
                    newAnimal = new MalayanTapir();
                    break;
            }
            return newAnimal;
        }
    }
}
