using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Gray_Scott_Simulator
{
    //Class has all the information and methods needed to run the simulation
    public class SimulationManager
    {
        //class properties
        private Bitmap pattern;
        private Grid grid;
        private Graphics canvas;
        private Graphics formGraphics;
        private Rectangle bounds;
        private LaplacianDelegate lapFunc;
        private int cellSize;
        private int gridSize;
        private double perpDiffA;
        private double PerpDiffB;
        private double convDeltDiffA;
        private double convDeltDiffB;
        private double numOfIterations;
        private double feedA;
        private double killB;

        //first constructor used for batch simulation
        public SimulationManager(Bitmap pattern, Graphics canvas, Graphics formGraphics, Rectangle bounds, int cellSize, int gridSize, 
            double perpDiffA, double perpDiffB, double convDeltDiffA, double convDeltDiffB, double numOfIterations)
        {
            this.pattern = pattern;
            this.canvas = canvas;
            this.formGraphics = formGraphics;
            this.bounds = bounds;
            this.cellSize = cellSize;
            this.gridSize = gridSize;
            this.perpDiffA = perpDiffA;
            this.PerpDiffB = perpDiffB;
            this.convDeltDiffA = convDeltDiffA;
            this.convDeltDiffB = convDeltDiffB;
            this.numOfIterations = numOfIterations;
        }

        //second constructor used for user input simulation
        public SimulationManager(Bitmap pattern, Graphics canvas, Graphics formGraphics, Rectangle bounds, LaplacianDelegate lapFunc, IColourPicker colourScheme,
            int cellSize, int gridSize, double diffA, double diffB, double feedA, double killB)
        {
            this.pattern = pattern;
            this.canvas = canvas;
            this.formGraphics = formGraphics;
            this.cellSize = cellSize;
            this.gridSize = gridSize;
            this.feedA = feedA;
            this.killB = killB;
            grid = new Grid(canvas, bounds, lapFunc, colourScheme, cellSize, gridSize, diffA, diffB, feedA, killB);
        }

        //runs the user input simulation
        public void RunSimulation()
        { 
            grid.DrawGrid();
            grid.GetCellsNextValues();
            grid.UpdateCellsValues();
        }

        //runs the batch simulation
        public void RunBatchSimulation()
        {
            feedA = 0.001;
            killB = 0.001;
            double diffA = 0;
            double diffB = 0;
            IColourPicker colourScheme = new GrayScaleColours();
            for(int i = 0; i < 3; i++)
            {
                //set laplacian function and related diffusion rates
                if(i == 0)
                {
                    lapFunc = LaplacianFunctions.PerpendicularLaplacian;
                    diffA = perpDiffA;
                    diffB = PerpDiffB;
                }
                else if (i == 1)
                {
                    lapFunc = LaplacianFunctions.ConvolutionLaplacian;
                    diffA = convDeltDiffA;
                    diffB = convDeltDiffB;
                }
                else if (i == 2)
                {
                    lapFunc = LaplacianFunctions.DeltaMeansLaplacian;
                    diffA = convDeltDiffA;
                    diffB = convDeltDiffB;
                }

                //changes feed A until it reaches 0.099
                while(feedA <= 0.099)
                {
                    //changes kill b untill it reaches 0.099
                    while (killB <= 0.099)
                    {
                        //makes a new grid with those numbers
                        grid = new Grid(canvas, bounds, lapFunc, colourScheme, cellSize, gridSize, diffA, diffB, feedA, killB);
                        //runs throught the simulation for 5000 iterations - enough to become stable
                        for (int j = 0; j < numOfIterations; j++)
                        {
                            grid.GetCellsNextValues();
                            grid.UpdateCellsValues();
                        }
                        //once it has become stable draws to screen then saves the image
                        grid.DrawGrid();
                        formGraphics.DrawImage(pattern, 0, 0);
                        SaveImage();

                        killB += 0.001;
                    }
                    feedA += 0.001;
                    killB = 0.001;

                }
            }
        }

        //saves an image to debug folder
        public void SaveImage()
        {
            string imageName = "feedA" + feedA + "killB" + killB + ".bmp";
            pattern.Save(imageName, ImageFormat.Bmp);
        }
    }
}
