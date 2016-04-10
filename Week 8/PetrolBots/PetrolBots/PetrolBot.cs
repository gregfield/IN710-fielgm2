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
            botCurrentLocation = botStartingLocation;
            this.botShip = botShip;
            this.shipLocation = botShip.ShipLocation;
            botShip.FullOfFuelEvent += new EventHandler(FullOfFuelEventHandler);
            botShip.OutOfFuelEvent += new OutOfFuelEventHandler(OutOfFuelEventHandler);
        }

        public void drawBot()
        {
            SolidBrush colour = new SolidBrush(botColor);
            botCanvas.FillEllipse(colour, botCurrentLocation.X, botCurrentLocation.Y, BOTSIZE, BOTSIZE);
        }

        public void FullOfFuelEventHandler(object o, EventArgs args)
        {
            botCurrentLocation = botStartingLocation;
        }

        public void OutOfFuelEventHandler(object o, ShipEventArgs args)
        {
            botCurrentLocation = args.ShipLocation;
        }
    }
}
