using System;
using System.Collections.Generic;
using System.Text;

namespace SquirrelTard
{
    class Squirrel
    {
        public float squirrelHeatlh;

        public Grid grid;

        public int squirrelPosX;
        public int squirrelPosY;

        public Squirrel(Grid _grid, int X, int Y)
        {
            squirrelHeatlh = 1.0f;
            grid = _grid;
            squirrelPosX = X;
            squirrelPosY = Y;
        }

        public void SquirrelMove(int xMove, int yMove)
        {
            squirrelPosX = squirrelPosX + xMove;
            squirrelPosY = squirrelPosY + yMove;
            
            foreach (Food food in grid.foodInGrid)
            {
                if (food.xPosFood == squirrelPosX && food.yPosFood == squirrelPosY) 
                {

                    squirrelHeatlh = squirrelHeatlh + food.foodHealthiness;
                    if (squirrelHeatlh > 1.0f)
                    {
                        squirrelHeatlh = 1.0f;
                    }
                }
            }
            
        }
        
    }
}
