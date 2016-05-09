using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMandLinq
{
    public partial class Form1 : Form
    {
        StrikesAndFiresDBDataContext strikesDB;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            strikesDB = new StrikesAndFiresDBDataContext();
        }

        private void avgStrikeIntensityBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var avgStrikes = strikesDB.tblStrikes.Average(s => s.strikeIntensity);

            listBox1.Items.Add("The average Intensity for alll Lightning Strikes is " + avgStrikes);
        }

        private void larget3FiresBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var largestFires = strikesDB.tblFires.OrderByDescending(f => f.fireArea).Take(3);

            foreach(var fire in largestFires)
            {
                listBox1.Items.Add("ID: " + fire.fireID + "   Date: " + fire.fireDate +"   Latitude: "+
                    fire.fireLatitude + "   Longitude: " + fire.fireLongitude + "   Area: " + fire.fireArea);
            }
        }

        private void picLongLatFileBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var picInfo = from s in strikesDB.tblStrikes
                          join p in strikesDB.tblPictures on s.strikeID equals p.strikeID
                          select new { s.strikeLatitude, s.strikeLongitude, p.pictureFileName };

            foreach(var pic in picInfo)
            {
                listBox1.Items.Add("Latitude: " + pic.strikeLatitude + "   Longitude: " + pic.strikeLongitude + "   Filename: " + pic.pictureFileName);
            }
        }

        private void fireCausedbyStrikeBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var firesCausedByStrikes = from s in strikesDB.tblStrikes
                                       from f in strikesDB.tblFires
                                       where s.strikeDate == f.fireDate && s.strikeLatitude == f.fireLatitude && 
                                       s.strikeLongitude == f.fireLongitude
                                       select f;

            foreach(var fire in firesCausedByStrikes)
            {
                listBox1.Items.Add("ID: " + fire.fireID + "   Date: " + fire.fireDate + "   Latitude: " +
                    fire.fireLatitude + "   Longitude: " + fire.fireLongitude + "   Area: " + fire.fireArea);
            }
        }
    }
}
