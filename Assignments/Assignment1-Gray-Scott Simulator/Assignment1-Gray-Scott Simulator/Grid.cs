using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Gray_Scott_Simulator
{
    //delegate for which laplacian to use
    public delegate double LaplacianDelegate(Cell[] neighbours, double value, bool AorB);

    //Class has all the information and methods a grid needs
    public class Grid
    {
        //grid class properties
        private Cell[,] grid;
        private Graphics gridCanvas;
        private Rectangle gridBounds;
        private LaplacianDelegate lapFunc;
        private IColourPicker colourScheme;
        private int cellSize;
        private int gridSize;
        private double feedA;
        private double killB;
        private double diffA;
        private double diffB;

        //grid constructor - passes in needed variables
        //initialises 2d array of cells and fills it
        public Grid(Graphics canvas, Rectangle gridBounds, LaplacianDelegate lapFunc, IColourPicker colourScheme, int cellSize, int gridSize,
            double diffA, double diffB, double feedA, double killB)
        {
            this.gridBounds = gridBounds;
            this.cellSize = cellSize;
            this.gridSize = gridSize;
            this.lapFunc = lapFunc;
            this.colourScheme = colourScheme;
            this.feedA = feedA;
            this.killB = killB;
            this.diffA = diffA;
            this.diffB = diffB;
            gridCanvas = canvas;
            grid = new Cell[gridSize,gridSize];
            InitialGrid();
            GiveEachCellItsNeighbours();
        }

        //tells each cell in 2d cell array to draw to screen
        public void DrawGrid()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j].DrawCell();
                }
            }
        }

        //goes through the grid calculating the next values for each cell
        public void GetCellsNextValues()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Cell currentCell = grid[i,j];
                    //turns the neighbour points held in each cell into the cells that they are
                    Point[] neighbours = currentCell.CellNeighbours;
                    Cell[] cellNeighbours = new Cell[neighbours.Length];
                    for(int k = 0; k < neighbours.Length; k++)
                    {
                        cellNeighbours[k] = grid[neighbours[k].X, neighbours[k].Y];
                    }
                    currentCell.NextAValue = CalcAValue(currentCell, cellNeighbours);
                    currentCell.NextBValue = CalcBValue(currentCell, cellNeighbours);
                }
            }
        }

        //Grey-Scott Equation for B
        public double CalcAValue(Cell cell, Cell[] neighbours)
        {
            //lapFunc is method call for the laplacian function
            double calc1 = diffA * lapFunc(neighbours, cell.CurrentAValue, true);
            double calc2 = cell.CurrentAValue * (cell.CurrentBValue * cell.CurrentBValue);
            double calc3 = feedA * (1 - cell.CurrentAValue);

            double returnValue = cell.CurrentAValue + calc1 - calc2 + calc3;
            if (returnValue < 0)
            {
                returnValue = 0;
            }
            else if (returnValue > 1)
            {
                returnValue = 1;
            }
            return returnValue;
        }

        //Grey-Scott Equation for B
        public double CalcBValue(Cell cell, Cell[] neighbours)
        {
            //lapFunc is method call for the laplacian function
            double calc1 = diffB * lapFunc(neighbours, cell.CurrentBValue, false);
            double calc2 = cell.CurrentAValue * (cell.CurrentBValue * cell.CurrentBValue);
            double calc3 = (killB + feedA) * cell.CurrentBValue;

            double returnValue = cell.CurrentBValue + calc1 + calc2 - calc3;
            if (returnValue < 0)
            {
                returnValue = 0;
            }
            else if (returnValue > 1)
            {
                returnValue = 1;
            }
            return returnValue;
        }
        
        //updates the current a and b values for each cell
        public void UpdateCellsValues()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j].UpdateCellValues();
                }
            }
        }

        //================================
        //Inital setup methods for the gid
        //================================
        
        //sets up the initial grid
        public void InitialGrid()
        {
            //fill grid with initial cells
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[i, j] = new Cell(gridCanvas, new Point(gridBounds.X + (j * cellSize),
                        gridBounds.Y + (i * cellSize)), colourScheme, cellSize);
                }
            }
            //seed the grid
            for (int i = gridSize / 4; i < gridSize / 1.4; i++)
            {
                for (int j = gridSize / 4; j < gridSize / 1.4; j++)
                {
                    grid[i, j].CurrentBValue = 1;
                    grid[i, j].CurrentAValue = 0;
                }
            }
        }

        //gives each cell its neighbours using GetCellNeighbours method
        public void GiveEachCellItsNeighbours()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j].CellNeighbours = GetCellNeighbours(i, j);
                }
            }
        }

        //get neighbours starting at right of cell and going around clockwise
        public Point[] GetCellNeighbours(int x, int y)
        {
            //number neighbours each cell has
            //catch is for the edge cells when it goes out of 
            //bounds it loops round to the opposite side of grid
            Point[] cellNeigbourrs = new Point[8];

            //right
            if(x+1 <= gridSize-1) { cellNeigbourrs[0] = new Point(x + 1, y); }
            else { cellNeigbourrs[0] = new Point(0, y); }

            //diagonal down right
            if((x+1 <= gridSize-1)&&(y+1 <= gridSize-1)) { cellNeigbourrs[1] = new Point(x + 1, y + 1); }
            else { cellNeigbourrs[1] = new Point(0, 0); }
            
            //down
            if(y+1 <= gridSize-1) { cellNeigbourrs[2] = new Point(x, y + 1); }
            else { cellNeigbourrs[2] = new Point(x, 0); }
            
            //diagonal down left
            if((x-1 >= 0)&&(y+1 <= gridSize-1)) { cellNeigbourrs[3] = new Point(x - 1, y + 1); }
            else { cellNeigbourrs[3] = new Point((gridSize - 1), 0); }
            
            //left
            if(x-1 >= 0) { cellNeigbourrs[4] = new Point(x - 1, y); }
            else { cellNeigbourrs[4] = new Point((gridSize - 1), y); }
            
            //diagonal up left
            if((x-1 >= 0)&&(y-1 >= 0)) { cellNeigbourrs[5] = new Point(x - 1, y - 1); }
            else { cellNeigbourrs[5] = new Point((gridSize - 1), (gridSize - 1)); }
            
            //up
            if(y-1 >= 0) { cellNeigbourrs[6] = new Point(x, y - 1); }
            else { cellNeigbourrs[6] = new Point(x, (gridSize - 1)); }
            
            //diagonal up right
            if((x+1 <= gridSize-1)&&(y-1 >= 0)) { cellNeigbourrs[7] = new Point(x + 1, y - 1); }
            else { cellNeigbourrs[7] = new Point(0, (gridSize - 1)); }
            
            return cellNeigbourrs;
        }

        //================================
        //Getters and Setters
        //================================
        public double FeedA
        {
            get { return feedA; }
            set { feedA = value; }
        }
        public double KillB
        {
            get { return killB; }
            set { killB = value; }
        }
    }
}
