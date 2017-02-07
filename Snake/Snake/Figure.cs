using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        //using list of the points
        protected List<Point> points;

        public void Draw()
        {
            foreach (Point point in points)
            {
                Console.SetCursorPosition(point.X, point.Y);
                Console.Write(point.Symbol);
            }
        }

    }
}
