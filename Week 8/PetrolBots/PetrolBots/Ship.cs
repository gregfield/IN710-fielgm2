using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PetrolBots
{
    public delegate void OutOfFuelEventHandler(object o, ShipEventArgs se);

    public enum EShipState { wandering, refueling };
    public class Ship
    {
        public event EventHandler FullOfFuelEvent;
        public event OutOfFuelEventHandler OutOfFuelEvent;

        private const int SHIPSIZE = 50;

        private int petrol;
        private int velocityX;
        private int velocityY;
        private Random rGen;
        private Graphics shipCanvas;
        private Rectangle bounds;
        private Color shipColor;
        private Point shipLocation;
        private EShipState shipState;

        public Ship(Graphics canvas, Rectangle bounds)
        {
            rGen = new Random();
            this.bounds = bounds;
            petrol = 100;
            shipLocation.X = rGen.Next(bounds.Width);
            shipLocation.Y = rGen.Next(bounds.Height);
            velocityX = rGen.Next(10, 50);
            velocityY = rGen.Next(10, 50);
            shipCanvas = canvas;
            shipColor = Color.Red;

        }

        public void drawShip()
        { 
            SolidBrush colour = new SolidBrush(shipColor);
            shipCanvas.FillRectangle(colour, shipLocation.X, shipLocation.Y, SHIPSIZE, SHIPSIZE);
        }

        public void moveShip()
        {
            if(shipState == EShipState.wandering)
            {
                shipLocation.X += velocityX;
                shipLocation.Y += velocityY;

                if ((shipLocation.X <= bounds.Left) || (shipLocation.X  >= bounds.Right - SHIPSIZE))
                {
                    velocityX *= -1;
                }
                else if ((shipLocation.Y <= bounds.Top) || ((shipLocation.Y + SHIPSIZE) >= bounds.Bottom))
                {
                    velocityY *= -1;
                }
            }                
        }

        public void OnFullOfFuelEvent()
        {
            EventArgs shipEvent = new EventArgs();
            if(FullOfFuelEvent != null)
            {
                FullOfFuelEvent(this, shipEvent);
            }
        }

        public void OnOutOfFuelEvent()
        {
            ShipEventArgs shipEvent = new ShipEventArgs(shipLocation);
            if(OutOfFuelEvent != null)
            {
                OutOfFuelEvent(this, shipEvent);
            }
        }

        public void refuel()
        {
            if (petrol != 100)
            {
                petrol += 5;
                shipColor = Color.FromArgb(255 / 100 * petrol, 0, 0);
                drawShip();
            }
            else
            {
                OnFullOfFuelEvent();
                shipState = EShipState.wandering;
            }
        }

        public void ShipCycle()
        {
            if (shipState == EShipState.wandering)
            {
                moveShip();
                drawShip();
                usePetrol();
                shipColor = Color.FromArgb(255 * petrol / 100, 0, 0);
            }
            else if(shipState == EShipState.refueling)
            {
                refuel();
            }
        }

        public void usePetrol()
        {
            petrol--;

            if(petrol <= 0)
            {
                OnOutOfFuelEvent();
                shipState = EShipState.refueling;

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
