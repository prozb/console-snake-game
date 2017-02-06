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
        List<Point> points;

        public HorizontalLine(List<Point> points)
        {
            this.points = points;
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
