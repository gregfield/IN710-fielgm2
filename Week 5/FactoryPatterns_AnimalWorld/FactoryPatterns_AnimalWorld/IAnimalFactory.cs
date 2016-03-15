using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns_AnimalWorld
{
    public interface IAnimalFactory
    {
        Animal createAnimal(int animalCode);
    }
}
