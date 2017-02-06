using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of the points for border lines
            List<Point> points = new List<Point>();

            //Intitialization of game constats
            const int HORIZONT_BORDER = 70;
            const int VERTICAL_BORDER = 70;

            const int BUFFER_WIDTH = 70;
            const int BUFFER_HEIGHT = 70;

            //set buffer size
            Console.SetBufferSize(BUFFER_WIDTH, BUFFER_HEIGHT);


            //start point
            int startX = 0;
            int startY = 0;

            char symbol = '#';

            HorizontalLine horizontalLine = new HorizontalLine(HORIZONT_BORDER, startX, startY, symbol);
            horizontalLine.DrawHorizontalLine();

            Console.ReadKey();
        }
    }
}
