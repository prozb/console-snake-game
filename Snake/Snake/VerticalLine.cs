using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        int VERTICAL_BORDER;

        public VerticalLine(int VERTICAL_BORDER, int startX, int startY, char symbol)
        {
            this.VERTICAL_BORDER = VERTICAL_BORDER;

            for (int i = 0; i < VERTICAL_BORDER - 3; i++)
            {
                //creating new point objects
                points.Add(new Point(startX, startY + 1, symbol));

                //shifting y location
                startY += 1;
            }
        }

        //Draw top line
        public void DrawLeftVerticalLine()
        {
            Console.SetCursorPosition(points[0].X, points[0].Y);

            foreach (Point point in points)
            {
                Console.WriteLine(point.Symbol);
            }
        }

        //Draw bottom line
        public void DrawRightVerticalLine(int BUFFER_WIDTH)
        {
            Console.SetCursorPosition(BUFFER_WIDTH - 1, points[0].Y - 1);

            for (int i = 0; i < points.Count; i++)
            {
                Console.Write(points[i].Symbol);

                Console.SetCursorPosition(BUFFER_WIDTH - 1, points[0].Y + i);
            }
        }
    }
}
