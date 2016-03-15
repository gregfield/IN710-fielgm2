/* Author: Greg Field
 * Date: 15/03/2016
 * Description: Displays Animals and their info
 * from different continents to the screen
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPatterns_AnimalWorld
{
    public partial class Form1 : Form
    {
        private const int NAUSTRALIAN_ANIMALS = 3;
        private const int NNORTHAMERICAN_ANIMALS = 3;

        Graphics canvas;

        Continent Australia;
        Continent NorthAmerica;

        public Form1()
        {
            InitializeComponent();  
            canvas = this.CreateGraphics();

            Australia = new Australian(displayAnimalInfo, canvas, NAUSTRALIAN_ANIMALS);
            NorthAmerica = new NorthAmerica(displayAnimalInfo, canvas, NNORTHAMERICAN_ANIMALS);

        }

        private void AUSBtn_Click(object sender, EventArgs e)
        {
            displayAnimalInfo.Items.Clear();
            Australia.runSimulation();
        }

        private void NorthABtn_Click(object sender, EventArgs e)
        {
            displayAnimalInfo.Items.Clear();
            NorthAmerica.runSimulation();
        }
    }
}
