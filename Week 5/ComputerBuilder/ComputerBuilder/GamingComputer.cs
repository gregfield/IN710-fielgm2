using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    //gaming components
    public class GamingCPU : CPU
    {
        public GamingCPU()
        {
            price = 350;
            name = "4.00GHz Intel Core i7-6700k";
        }
    }
    public class GamingGPU : GPU
    {
        public GamingGPU()
        {
            price = 300;
            name = "AMD Radeon R9 380";
        }
    }
    public class GamingRAM : RAM
    {
        public GamingRAM()
        {
            price = 150;
            name = "8Gb DDR3 RAM";
        }
    }
}
