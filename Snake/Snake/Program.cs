using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            const int BUFFER_WIDTH = 70;
            const int BUFFER_HEIGHT = 30;

            //set window size
            Console.SetWindowSize(BUFFER_WIDTH, BUFFER_HEIGHT);
            Console.SetBufferSize(BUFFER_WIDTH, BUFFER_HEIGHT);

            #region DRAWING BORDER
            //start point
            int startX = 0;
            int startY = 0;

            char symbol = '#';


            //all about border
            HorizontalLine horizontalLineTop = new HorizontalLine(startX, startY, symbol);
            HorizontalLine horizontalLineBottom = new HorizontalLine(startX, Console.WindowHeight - 1, symbol);

            VerticalLine verticalLineLeft = new VerticalLine(startX, startY, symbol);
            VerticalLine verticalLineRigth = new VerticalLine(BUFFER_WIDTH - 2, startY, symbol);

            //draw top and bottom borders
            horizontalLineTop.Draw();
            horizontalLineBottom.Draw();

            //draw left and right border
            verticalLineLeft.Draw();
            verticalLineRigth.Draw();

            //set cursor in the center
            Console.SetCursorPosition(BUFFER_WIDTH / 2, BUFFER_HEIGHT  / 2);

            #endregion

            #region DRAWING SNAKE
            //location of the end of the snake
            int xEndSnake = 10;
            int yEndSnake = 10;

            //snake lenght
            int snakeLenght = 4;

            //snakes body
            char snakeBody = '*';

            //creating beginning point of the snake
            Point beginPoint = new Point(xEndSnake, yEndSnake, snakeBody);

            //creating of the new snake
            Snake snake = new Snake(beginPoint, snakeLenght, Direction.Right);


            //food symbol
            char foodSymbol = '$';

            //food creater object
            FoodCreater newFood = new FoodCreater(foodSymbol);
            Point foodPoint = new Point(newFood.XPosition, newFood.YPosition, newFood.Symbol);

            //drawng point
            foodPoint.DrawPoint();


            //draw snake
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    //cheking key
                    snake.HandleKey(keyInfo);
                }

                //delay
                Thread.Sleep(100);

                if (snake.Eat(foodPoint))
                {
                    //creating new food
                    newFood = new FoodCreater(foodSymbol);
                    foodPoint = new Point(newFood.XPosition, newFood.YPosition, newFood.Symbol);

                    //draw next point
                    foodPoint.DrawPoint();

                }
                else
                {
                    snake.Move();
                }

               
            }

            #endregion
        }
    }
}
