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
            const int HORTZONT_BORDER = 10;

            //start point
            int startX = 3;
            int startY = 4;

            char symbol = '#';


            for (int i = 0; i < HORTZONT_BORDER; i++)
            {
                //creating new point objects
                points.Add(new Point(startX, startY, symbol));

                //shifting x location
                startX += 1;
            }

            //new line object
            HorizontalLine horizontalLine = new HorizontalLine(points);

            horizontalLine.DrawHorizontalLine();

            Console.ReadKey();
        }
    }
}
