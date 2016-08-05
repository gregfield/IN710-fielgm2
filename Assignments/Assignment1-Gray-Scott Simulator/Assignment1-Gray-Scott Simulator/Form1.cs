using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Gray_Scott_Simulator
{
    public partial class Form1 : Form
    {
        //simulation constants
        private const int NUMOFITERATIONS = 5000;
        private const int CELLSIZE = 2;
        private const int GRIDSIZE = 256;
        private const double PERPDIFFA = 0.00002;
        private const double PERPDIFFB = 0.00001;
        private const double CONVDELTADIFFA = 1;
        private const double CONVDELTADIFFB = 0.5;

        //form properties
        private Bitmap pattern;
        private Rectangle canvasBounds;
        private Graphics canvas;
        private Graphics formGraphics;
        private SimulationManager manager;
        private LaplacianDelegate lapFunc;
        private int iterationNum;

        public Form1()
        {
            InitializeComponent();
        }

        //initialises the properties
        private void Form1_Load(object sender, EventArgs e)
        {
            canvasBounds = new Rectangle(25, 25, GRIDSIZE*CELLSIZE, GRIDSIZE*CELLSIZE);
            pattern = new Bitmap((GRIDSIZE * (CELLSIZE * CELLSIZE)), (GRIDSIZE * (CELLSIZE * CELLSIZE)));
            canvas = Graphics.FromImage(pattern);
            formGraphics = CreateGraphics();
            lapFunc = null;
            iterationNum = 0;
        }

        //what happens when the user clicks the run simulation button
        private void runSimBtn_Click(object sender, EventArgs e)
        {
            iterationNum = 0;
            double diffA = 0, diffB = 0, feedA, killB;
            ColourFactory colourFactory = new ColourFactory();
            IColourPicker colourScheme;

            //gets the selected colour scheme or defaults to grayscale
            if(grayScaleRbtn.Checked)
            {
                colourScheme = colourFactory.MakeColour(ColourChoices.GrayScale);
            }
            else if (blueRbtn.Checked)
            {
                colourScheme = colourFactory.MakeColour(ColourChoices.Colour1);
            }
            else if (redRbtn.Checked)
            {
                colourScheme = colourFactory.MakeColour(ColourChoices.Colour2);
            }
            else
            {
                colourScheme = colourFactory.MakeColour(0);
            }

            try
            {
                //gets the user specified values
                feedA = Convert.ToDouble(feedATxtBox.Text);
                killB = Convert.ToDouble(killBTxtBox.Text);
                if((feedA > 1)||(killB < 0))
                {
                    MessageBox.Show("Please enter numbers between 0 and 1");
                    feedATxtBox.Text = "";
                    killBTxtBox.Text = "";
                    return;
                }

                //gets the user specified laplacian function to use
                if (perpendicularRbtn.Checked)
                {
                    lapFunc = LaplacianFunctions.PerpendicularLaplacian;
                    diffA = PERPDIFFA;
                    diffB = PERPDIFFB;
                }
                else if (convolutionRbtn.Checked)
                {
                    lapFunc = LaplacianFunctions.ConvolutionLaplacian;
                    diffA = CONVDELTADIFFA;
                    diffB = CONVDELTADIFFB;
                }
                else if (deltaRbtn.Checked)
                {
                    lapFunc = LaplacianFunctions.DeltaMeansLaplacian;
                    diffA = CONVDELTADIFFA;
                    diffB = CONVDELTADIFFB;
                }

                //if a laplacian function has been selected makes a simulation manger
                //then starts the timer 
                if (lapFunc != null)
                {
                    manager = new SimulationManager(pattern, canvas, formGraphics, canvasBounds, lapFunc, colourScheme, CELLSIZE, GRIDSIZE, diffA, diffB, feedA, killB);
                    timer1.Enabled = true;
                }
                else //if laplacian function hasnt been selected
                {
                    MessageBox.Show("Please select a Laplacian Function");
                }
            }
            catch (FormatException) //if user hasn't entered a and b values
            {
                MessageBox.Show("Please enter Values between 0 and 1 for Feed A and Kill B");
            }
        }

        //what happens when user clicks to run a batch simulation
        private void runBatchBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Batch Simulation will create a pattern then \n draw it to the screen and save the image. \n Click Ok to run batch simulation");
            iterationLabel.Text = "Batch simulation running ...";
            iterationLabel.Update();
            manager = new SimulationManager(pattern, canvas, formGraphics, canvasBounds, CELLSIZE, GRIDSIZE,
                PERPDIFFA, PERPDIFFB, CONVDELTADIFFA, CONVDELTADIFFB, NUMOFITERATIONS);
            manager.RunBatchSimulation();
            MessageBox.Show("Batch Simulation Finished");
            iterationLabel.Text = "Batch simulation finished";
        }

        //what happens when a user clicks to save an image
        private void saveBtn_Click(object sender, EventArgs e)
        {
            manager.SaveImage();
            MessageBox.Show("Image Saved!");
        }

        //what happens each timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if there has been less than NUMOFITERATIONS ticks run the simulation
            //500 is used for NUMOFITERATIONS because most patterns should be constant by that point
            if (iterationNum < NUMOFITERATIONS)
            {
                manager.RunSimulation();
                iterationLabel.Text = "Iteration Number " + iterationNum + " out of 5000";
                iterationNum++;
            }
            else //sets the label to say simulation has finished
            {
                iterationLabel.Text = "Simulation finished";
                iterationNum = 0;
                timer1.Enabled = false;
            }
            formGraphics.DrawImage(pattern,0,0);
        }
    }
}
