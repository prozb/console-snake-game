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
            int x1 = 1;
            int y1 = 3;

            char sym1 = '*';

            //creating point object 
            Point point1 = new Point(x1, y1, sym1);

            //point draw itself
            point1.Draw();


            int x2 = 4;
            int y2 = 5;

            char sym2 = '#';

            //creating point object 
            Point point2 = new Point(x2, y2, sym2);

            //point draw itself
            point2.Draw();

            Console.ReadKey();
        }
    }
}
