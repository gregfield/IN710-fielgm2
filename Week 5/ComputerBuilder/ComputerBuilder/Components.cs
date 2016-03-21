using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class Components
    {
        protected double price;
        protected String name;

        public override string ToString()
        {
            return "$" + price + "\t" + name;
        }

        public double Price
        {
            get { return price; }
        }
    }
}
