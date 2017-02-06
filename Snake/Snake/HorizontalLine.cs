using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        int HORIZONT_BORDER;

        public HorizontalLine(int HORIZONT_BORDER, int startX, int startY, char symbol)
        {
            this.HORIZONT_BORDER = HORIZONT_BORDER;

            for (int i = 0; i < HORIZONT_BORDER; i++)
            {
                //creating new point objects
                points.Add(new Point(startX, startY, symbol));

                //shifting x location
                startX += 1;
            }
        }

        //Draw top line
        public void DrawTopHorizontalLine()
        {
            Console.SetCursorPosition(points[0].X, points[0].Y);

            foreach (Point point in points)
            {
                Console.Write(point.Symbol);
            }
        }

        //Draw bottom line
        public void DrawBottomHorizontalLine(int BUFFER_HEIGHT)
        {
            Console.SetCursorPosition(points[0].X, BUFFER_HEIGHT - 2);

            foreach (Point point in points)
            {
                Console.Write(point.Symbol);
            }
        }
    }
}
