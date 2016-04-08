using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class ShipEventArgs : EventArgs
    {
        private Point shipLocation;



        public Point ShipLocation
        {
            get { return shipLocation; }
            set { shipLocation = value; }
        }

    }
}
