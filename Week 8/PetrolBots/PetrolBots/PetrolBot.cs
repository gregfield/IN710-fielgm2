using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class PetrolBot
    {
        private const int BOTSIZE = 10;

        private Graphics botCanvas;
        private Color botColor;
        private Point botCurrentLocation;
        private Ship botShip;
        private Point botStartingLocation;
        private Point shipLocation;

        public PetrolBot(Graphics canvas, Point startingLocation, Ship botShip)
        {
            botCanvas = canvas;
            botColor = Color.Purple;
            botStartingLocation = startingLocation;
            this.botShip = botShip;

            botShip.FullOfFuelEvent += new EventHandler(fullOfFuelEventHandler);
            botShip.OutOfFuelEvent += new OutOfFuelEventHandler(outOfFuelEventHandler);
        }

        public void drawBot()
        {
            SolidBrush colour = new SolidBrush(botColor);
            botCanvas.FillEllipse(colour, 100, 100, BOTSIZE, BOTSIZE);
        }

        public void fullOfFuelEventHandler(object o, EventArgs args)
        {
            botCurrentLocation = botStartingLocation;
        }

        public void outOfFuelEventHandler(object o, ShipEventArgs args)
        {
            botCurrentLocation = args.ShipLocation;
        }
    }
}
