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

        //score
        int score;
        
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

        #region SNAKE METHODS
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

            //draw snake
            Draw();
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

        //cheking key 
        public void HandleKey(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    //snake can't make 180 deegrees unwrap
                    if(direction == Direction.Down)
                    {
                        direction = Direction.Down;
                    }
                    else
                    {
                        direction = Direction.Up;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    //snake can't make 180 deegrees unwrap
                    if (direction == Direction.Up)
                    {
                        direction = Direction.Up;
                    }
                    else
                    {
                        direction = Direction.Down;
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    //snake can't make 180 deegrees unwrap
                    if (direction == Direction.Right)
                    {
                        direction = Direction.Right;
                    }
                    else
                    {
                        direction = Direction.Left;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    //snake can't make 180 deegrees unwrap
                    if (direction == Direction.Left)
                    {
                        direction = Direction.Left;
                    }
                    else
                    {
                        direction = Direction.Right;
                    }
                    break;
            }
        }

        //ate or no
        internal bool Eat(Point foodPoint)
        {
            Point head = GetNextPoint();

            if (foodPoint.X == head.X &&
                foodPoint.Y == head.Y)
            {
                //changing of symbol
                foodPoint.Symbol = head.Symbol;

                //adding point to the list
                points.Add(foodPoint);

                //changing score
                score++;

                return true;
            }
            else
            {
                return false;
            }
        }

        //collision between head and tail of the snake
        internal bool IsHitTail()
        {
            //get head point
            Point head = GetNextPoint();

            //collision between head and snake tail
            for (int i = 0; i < points.Count - 1; i++)
            {
                if (points[i].X == head.X && points[i].Y == head.Y)
                {
                    return true;
                }
            }
            return false;
        }


        //collicion between border and snake
        internal bool IsHit(List<Figure> figures)
        {
            Point head = GetNextPoint();
            foreach (Figure figure in figures)
            {
                foreach (Point point in figure.Points)
                {
                    if (point.X == head.X &&
                        point.Y == head.Y)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //draw snake
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Draw();
        }

        #endregion

        #region SNAKE PROPERTIES

        //read and write direction property 
        public Direction Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        //score property
        public int Score
        {
            get { return score; }
        }


        #endregion
    }
}
