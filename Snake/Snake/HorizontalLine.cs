using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int startX, int startY, char symbol)
        {
            //new list of points for the horizontal lines
            points = new List<Point>();

            for (int i = 0; i < Console.WindowWidth - 1; i++)
            {
                //creating new point objects
                points.Add(new Point(startX, startY, symbol));

                //shifting x location
                startX += 1;
            }
        }
    }
}
