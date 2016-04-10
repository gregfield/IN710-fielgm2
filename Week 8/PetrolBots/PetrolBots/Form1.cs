using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBots
{

    public partial class Form1 : Form
    {
        private const int NUMSHIPS= 5;

        Graphics canvas;
        Rectangle shipBounds;
        List<Ship> shipList;
        List<PetrolBot> botList;
        Point botStartLocation;
        Random rGen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shipList = new List<Ship>();
            botList = new List<PetrolBot>();
            canvas = CreateGraphics();
            rGen = new Random();
            shipBounds = new Rectangle(0, 0, Width - 20, Height - 100);
            botStartLocation.X = 20; 
            botStartLocation.Y = Height - 70; 

            for (int i = 0; i < NUMSHIPS; i++ )
            {
                shipList.Add(new Ship(canvas, shipBounds, rGen));
                botList.Add(new PetrolBot(canvas, botStartLocation, shipList[i]));
                botStartLocation.X += 20;
            }

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas.Clear(Color.Blue);
            canvas.DrawLine(Pens.Black, 0, Height - 90, Width, Height - 90);

            for(int i = 0; i < shipList.Count; i++)
            {
                shipList[i].ShipCycle();
                botList[i].drawBot();
            }
        }
    }
}
