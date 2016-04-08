using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBots
{
    public delegate void FullOfFuelEventHandler(object o, ShipEventArgs se);
    public delegate void OutOfFuelEventHandler(object o, ShipEventArgs se);

    public enum EShipState { wandering, refueling };
    public class Ship
    {
        public event FullOfFuelEventHandler FullOfFuelEvent;
        public event OutOfFuelEventHandler OutOfFuelEvent;

        private const int SHIPSIZE = 50;

        private int petrol;
        private int velocity;
        private Random rGen;
        private Graphics shipCanvas;
        private Rectangle bounds;
        private Color shipColor;
        private Point shipLocation;
        private EShipState shipState;

        public Ship(Graphics canvas, Rectangle bounds)
        {
            this.bounds = bounds;
            petrol = 100;
            velocity = 50;
            rGen = new Random();
            shipCanvas = canvas;
            shipColor = Color.Red;
            shipLocation.X = rGen.Next(bounds.Width);
            shipLocation.Y = rGen.Next(bounds.Height);
        }

        public void drawShip()
        {
            shipCanvas.Clear(Color.Blue);  
            SolidBrush colour = new SolidBrush(shipColor);
            shipCanvas.FillRectangle(colour, shipLocation.X, shipLocation.Y, SHIPSIZE, SHIPSIZE);
        }

        public void moveShip()
        {
            if(shipLocation.X++ < bounds.X )
            {
                shipLocation.X = shipLocation.X + velocity;
            }
            if (shipLocation.Y++ < bounds.Y)
            {
                shipLocation.Y = shipLocation.Y + velocity;
            }
            usePetrol();
        }

        public void OnFullOfFuelEvent()
        { }

        public void OnOutOfFuelEvent()
        { }

        public void refuel()
        { }

        public void ShipCycle()
        {
            drawShip();
            moveShip();
            usePetrol();
        }

        public void usePetrol()
        {
            petrol--;
            int colour = 255;
            
            if((petrol % 5) == 0)
            {
                colour = colour - 30;
                //shipColor = Color.FromArgb(colour, 0, 0);
                shipColor = ControlPaint.Dark(shipColor);
            }
        }

        public int Petrol
        {
            get { return petrol; }
            set { petrol = value; }
        }
        public Point ShipLocation
        {
            get { return shipLocation; }
            set { shipLocation = value; }
        }        
    }
}
