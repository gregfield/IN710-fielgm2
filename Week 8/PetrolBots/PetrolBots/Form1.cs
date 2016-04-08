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

        Graphics canvas;
        Rectangle bounds;
        Ship ship;
        PetrolBot bot;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            canvas = CreateGraphics();
            bounds = new Rectangle(0, 0, Width, Height);

            ship = new Ship(canvas, bounds);
            bot = new PetrolBot(canvas);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ship.ShipCycle();
            bot.drawBot();
        }
    }
}
