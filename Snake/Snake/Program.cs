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
            //Intitialization of game constats
            const int HORIZONT_BORDER = 70;
            const int VERTICAL_BORDER = 30;

            const int BUFFER_WIDTH = 70;
            const int BUFFER_HEIGHT = 30;

            //set window size
            Console.SetWindowSize(BUFFER_WIDTH, BUFFER_HEIGHT);
            Console.SetBufferSize(BUFFER_WIDTH, BUFFER_HEIGHT);

            #region DRAWING BORDER
            //start point
            int startX = 0;
            int startY = 1;

            char symbol = '#';

            HorizontalLine horizontalLine = new HorizontalLine(HORIZONT_BORDER, startX, startY, symbol);
            VerticalLine verticalLine = new VerticalLine(VERTICAL_BORDER, startX, startY, symbol);

            //draw top and bottom borders
            horizontalLine.DrawTopHorizontalLine();
            horizontalLine.DrawBottomHorizontalLine(BUFFER_HEIGHT);

            //draw left and right border
            verticalLine.DrawLeftVerticalLine();
            verticalLine.DrawRightVerticalLine(BUFFER_WIDTH);

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

            //draw snake
            snake.DrawSnake();

            #endregion

            Console.ReadKey();
        }
    }
}
