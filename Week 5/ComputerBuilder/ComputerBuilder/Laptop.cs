using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    //laptop components
    public class LaptopCPU : CPU
    {
        public LaptopCPU()
        {
            price = 160;
            name = "2.4GHZ Intel Core i7-4700MQ";
        }
    }
    public class LaptopGPU : GPU
    {
        public LaptopGPU()
        {
            price = 180;
            name = "Nvidia GT-745M";
        }
    }
    public class LaptopRAM : RAM
    {
        public LaptopRAM()
        {
            price = 150;
            name = "8GB DDR3 RAM";
        }
    }
    public class LaptopMonitor : Monitor
    {
        public LaptopMonitor()
        {
            price = 150;
            name = "15.6 inch full hd";
        }
    }
}
