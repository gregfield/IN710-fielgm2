using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    //business components
    public class BusinessCPU : CPU
    {
        public BusinessCPU()
        {
            price = 160;
            name = "2.2GHZ Intel Core i5-6400t";
        }
    }
    public class BusinessGPU : GPU
    {
        public BusinessGPU()
        {
            price = 160;
            name = "Intel HD Graphics 4600";
        }
    }
    public class BusinessRAM : RAM
    {
        public BusinessRAM()
        {
            price = 70;
            name = "4GB DDR3 RAM";
        }
    }
}
