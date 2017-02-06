using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        List<Point> snakePoints = new List<Point>();

        public Snake(Point beginPoint, int snakeLenght, Direction direction)
        {

            for (int i = 0; i < snakeLenght; i++)
            {
                Point movedPoint = new Point(beginPoint.X, beginPoint.Y, beginPoint.Symbol);
                //changing location of the point
                movedPoint.ShiftedPoint(i, direction);

                //adding new point to the list
                snakePoints.Add(movedPoint);
            }
            


        }


        //drawing method
        public void DrawSnake()
        {
            foreach (Point snakePoint in snakePoints)
            {
                Console.Write(snakePoint.Symbol);
            }
        }
    }
}
