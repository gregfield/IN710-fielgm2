using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public interface IComponentFactory
    {
        CPU makeCPU();
        GPU makeGPU();
        RAM makeRam();
    }
}
