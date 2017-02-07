using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        //create direction
        Direction direction;

        public Snake(Point beginPoint, int snakeLenght, Direction direction)
        {
            points = new List<Point>();

            this.direction = direction;

            for (int i = 0; i < snakeLenght; i++)
            {
                Point movedPoint = new Point(beginPoint.X, beginPoint.Y, beginPoint.Symbol);
                //changing location of the point
                movedPoint.ShiftedPoint(i, direction);

                //adding new point to the list
                points.Add(movedPoint);
            }
        }

        internal void Move()
        {
            Point endOfSnake = new Point(points[0].X, points[0].Y, points[0].Symbol);

            //clear old symbol *
            endOfSnake.Clear();

            //remove end of the snake
            points.RemoveAt(0);

            //create copy of the head
            Point newHeadOfSnake = GetNextPoint();

            //add new head to the list
            points.Add(newHeadOfSnake);
        }

        //new head method
        public Point GetNextPoint()
        {
            Point head = points.Last();

            //copy of the head
            Point newHeadOfStake = new Point(head.X, head.Y, head.Symbol);

            //new point ahead
            newHeadOfStake.ShiftedPoint(1, direction);
            return newHeadOfStake;
        }
    }
}
