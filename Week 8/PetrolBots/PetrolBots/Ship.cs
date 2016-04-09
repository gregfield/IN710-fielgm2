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
        private int velocity;
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
            velocity = rGen.Next(10,50);
            shipCanvas = canvas;
            shipColor = Color.Red;
            shipLocation.X = rGen.Next(bounds.X);
            shipLocation.Y = rGen.Next(bounds.Y);
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
                shipLocation.X += velocity;
                shipLocation.Y += velocity;

                if ((shipLocation.X <= bounds.Left) || (shipLocation.X  >= bounds.Right) || (shipLocation.Y <= bounds.Top) || ((shipLocation.Y + SHIPSIZE) >= bounds.Bottom))
                {
                    velocity *= -1;
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
            do
            {
                petrol += 5;
                shipColor = Color.FromArgb(255 / 100 * petrol, 0, 0);
                drawShip();
                Thread.Sleep(100);
            }while (petrol != 100);

            OnFullOfFuelEvent();
            shipState = EShipState.wandering;
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
