using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    //multimedia components
    public class MultimediaCPU : CPU
    {
        public MultimediaCPU()
        {
            price = 300;
            name = "2.80GHz Intel Core i7-6700t";
        }
    }
    public class MultimediaGPU : GPU
    {
        public MultimediaGPU()
        {
            price = 130;
            name = "Asus GeForce GT 740 OC";
        }
    }
    public class MultimediaRAM : RAM
    {
        public MultimediaRAM()
        {
            price = 230;
            name = "16Gb DDR3 RAM";
        }
    }
    public class MultimediaMonitor : Monitor
    {
        public MultimediaMonitor()
        {
            price = 300;
            name = "4k 26 inch";
        }
    }
}
