using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public class SpecPrinter
    {
        private IComponentFactory componentFactory;
        private ListBox displayBox;

        public SpecPrinter (IComponentFactory componentFactory, ListBox displayBox)
        {
            this.componentFactory = componentFactory;
            this.displayBox = displayBox;
        }

        public void printSpec()
        {
            CPU currCPU = componentFactory.makeCPU();
            GPU currGPU = componentFactory.makeGPU();
            RAM currRAM = componentFactory.makeRam();

            double totalPrice = currCPU.Price + currGPU.Price + currRAM.Price;

            displayBox.Items.Clear();
            displayBox.Items.Add("Price\tComponent");
            displayBox.Items.Add("----------------------------------");

            displayBox.Items.Add(currCPU.ToString());
            displayBox.Items.Add(currGPU.ToString());
            displayBox.Items.Add(currRAM.ToString());

            displayBox.Items.Add("----------------------------------");
            displayBox.Items.Add("Total Price: $" + totalPrice.ToString());
        }
    }
}
