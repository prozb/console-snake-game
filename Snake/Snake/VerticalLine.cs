using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {

        public VerticalLine(int startX, int startY, char symbol)
        {
            //new list of points for the vertical lines
            points = new List<Point>();

            for (int i = 0; i < Console.WindowHeight - 2; i++)
            {
                //creating new point objects
                points.Add(new Point(startX, startY + 1, symbol));

                //shifting y location
                startY += 1;
            }
        }
    }
}
