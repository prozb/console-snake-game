using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        //using list of the points
        List<Point> points = new List<Point>();

        public HorizontalLine(int HORIZONT_BORDER, int startX, int startY, char symbol)
        { 
            for (int i = 0; i < HORIZONT_BORDER; i++)
            {
                //creating new point objects
                points.Add(new Point(startX, startY, symbol));

                //shifting x location
                startX += 1;
            }
        }

        //Draw method
        public void DrawHorizontalLine()
        {
            Console.SetCursorPosition(points[0].X, points[0].Y);

            foreach (Point point in points)
            {
                Console.Write(point.Symbol);
            }
        }
    }
}
