using System;
using System.Collections.Generic;
using System.Text;

namespace SquirrelTard
{
    class Grid
    {
        public int gridWidth;
        public int gridHeight;

        public List<Food> foodInGrid;

        public Grid(int GridWidth, int GridHeight)
        {
            gridWidth = GridWidth;
            gridHeight = GridHeight;

            foodInGrid = new List<Food>();
        }
    }
}
