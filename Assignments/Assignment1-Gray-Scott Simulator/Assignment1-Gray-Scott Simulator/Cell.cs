using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Gray_Scott_Simulator
{
    //Class has all the information and methods a cell needs
    public class Cell
    {
        //class properties
        private Graphics canvas;
        private Point position;
        private Color colour;
        private Point[] cellNeighbours;
        private IColourPicker colourScheme;
        private double currentAValue;
        private double currentBValue;
        private double nextAValue;
        private double nextBValue;

        private int cellSize;

        //constructor with passed in variables
        public Cell(Graphics canvas, Point position, IColourPicker colourScheme, int cellSize)
        {
            this.canvas = canvas;
            this.position = position;
            this.cellSize = cellSize;
            this.colourScheme = colourScheme;
            currentAValue = 1;
            currentBValue = 0;
        }

        //draws a cell to the screen
        public void DrawCell()
        {
            GetColour();
            Brush brush = new SolidBrush(colour);
            canvas.FillRectangle(brush, position.X, position.Y, cellSize, cellSize);
        }

        //Updates the values of a and b
        public void UpdateCellValues()
        {
            currentAValue = nextAValue;
            currentBValue = nextBValue;
        }

        //gets the cell colour to draw
        public void GetColour()
        {
            colour = colourScheme.MakeCellColour(currentBValue);
        }

        //================================
        //Getters and Setters
        //================================
        public Color Colour
        {
            set { colour = value; }
        }
        public Point[] CellNeighbours
        {
            get { return cellNeighbours; }
            set { cellNeighbours = value; }
        }
        public double CurrentAValue
        {
            get { return currentAValue; }
            set { currentAValue = value; }
        }
        public double CurrentBValue
        {
            get { return currentBValue; }
            set { currentBValue = value; }
        }
        public double NextAValue
        {
            get { return nextAValue; }
            set { nextAValue = value; }
        }
        public double NextBValue
        {
            get { return nextBValue; }
            set { nextBValue = value; }
        }
    }
}
