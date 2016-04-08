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

        public PetrolBot(Graphics canvas)
        {
            botCanvas = canvas;
            botColor = Color.Purple;
        }

        public void drawBot()
        {
            SolidBrush colour = new SolidBrush(botColor);
            botCanvas.FillEllipse(colour, 100, 100, BOTSIZE, BOTSIZE);
        }

        public void FullOfFuelEventHandler()
        { }

        public void OutOfFuelEventHandler()
        { }
    }
}
