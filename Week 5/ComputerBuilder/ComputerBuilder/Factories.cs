using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    //the factories that make all the different types of computers
    public class BusinessComputerFactory : IComponentFactory
    {  
        CPU IComponentFactory.makeCPU()
        {
            return new BusinessCPU();
        }

        public GPU makeGPU()
        {
            return new BusinessGPU();
        }
        public RAM makeRam()
        {
            return new BusinessRAM();
        }
    }
    public class MultimediaComputerFactory : IComponentFactory
    {
        CPU IComponentFactory.makeCPU()
        {
            return new MultimediaCPU();
        }

        public GPU makeGPU()
        {
            return new MultimediaGPU();
        }
        public RAM makeRam()
        {
            return new MultimediaRAM();
        }
    }
    public class GamingComputerFactory : IComponentFactory
    {
        CPU IComponentFactory.makeCPU()
        {
            return new GamingCPU();
        }

        public GPU makeGPU()
        {
            return new GamingGPU();
        }
        public RAM makeRam()
        {
            return new GamingRAM();
        }
    }
}
