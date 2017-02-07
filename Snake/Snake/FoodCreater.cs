using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreater : Figure
    {
        Random rand = new Random();
        char symbol;

        int xPosition;
        int yPosition;

        //active or no
        bool active = true;

        public FoodCreater(char symbol)
        {
            //generate new food location
            xPosition = rand.Next(2, Console.BufferWidth - 2);
            yPosition = rand.Next(2, Console.BufferHeight - 2);

            this.symbol = symbol;
        }

        #region FOODCREATOR METHODS
        //create new food in random position
        public void FoodCreate()
        {
            //food point
            Point newFoodPoint = new Point(xPosition, yPosition, symbol);
            newFoodPoint.DrawPoint();
        }

        #endregion

        #region PROPERTIES

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        //x position property
        public int XPosition
        {
            get { return xPosition; }
        }

        //y position property
        public int YPosition
        {
            get { return yPosition; }
        }

        public char Symbol
        {
            get { return symbol; }
        }

        #endregion
    }
}
