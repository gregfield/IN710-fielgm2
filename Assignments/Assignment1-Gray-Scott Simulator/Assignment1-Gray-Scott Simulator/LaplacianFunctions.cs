using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Gray_Scott_Simulator
{
    //Class holds all the laplacian functions
    public static class LaplacianFunctions
    {
        //Perpendicular Laplacian function
        //calculates sum of neighbours the gets the difference between that and 4* the cell
        //then * by rh which is a biology constant
        public static double PerpendicularLaplacian(Cell[] neighbours, double value, bool AorB)
        {
            double h = 2.5 / 127.0;
            double rh = 1.0 / h / h;
            double sumOfNeighboursX = 0;

            for (int i = 0; i < neighbours.Length; i++)
            {
                if((i == 0)||(i == 2)||(i == 4)||(i == 6))
                {
                    if (AorB == true)
                    {
                        sumOfNeighboursX += neighbours[i].CurrentAValue;
                    }
                    else
                    {
                        sumOfNeighboursX += neighbours[i].CurrentBValue;
                    }
                }
            }

            return rh * (sumOfNeighboursX - (4 * value));
        }

        //Convolution Laplacian function
        //calculates sum of all neighbours and cell after they are * by a constant
        public static double ConvolutionLaplacian(Cell[] neighbours, double value, bool AorB)
        {
            double sumOfNeighbours = 0;
            for (int i = 0; i < neighbours.Length; i++)
            {
                if ((i == 0) || (i == 2) || (i == 4) || (i == 6))
                {
                    if (AorB == true)
                    {
                        sumOfNeighbours += (neighbours[i].CurrentAValue * 0.2);
                    }
                    else
                    {
                        sumOfNeighbours += (neighbours[i].CurrentBValue * 0.2);
                    }
                }
                else
                {
                    if (AorB == true)
                    {
                        sumOfNeighbours += (neighbours[i].CurrentAValue * 0.05);
                    }
                    else
                    {
                        sumOfNeighbours += (neighbours[i].CurrentBValue * 0.05);
                    }
                }
            }


            return (value*-1) + sumOfNeighbours;
        }

        // Delta means Laplacian function
        //calculates difference between average of the neighbours and the current cell
        public static double DeltaMeansLaplacian(Cell[] neighbours, double value, bool AorB)
        {
            double averageOfNeighbours = 0;

            for (int i = 0; i < neighbours.Length; i++)
            {
                if (AorB == true)
                {
                    averageOfNeighbours += neighbours[i].CurrentAValue;
                }
                else
                {
                    averageOfNeighbours += neighbours[i].CurrentBValue;
                }
            }

            averageOfNeighbours /= neighbours.Length;
            return averageOfNeighbours -= value;
        }
    }
}
