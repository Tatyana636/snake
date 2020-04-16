using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
             p1.Draw();

             Point p2 = new Point(4, 5, '#');
             p2.Draw();

            HorizontalLine Hline = new HorizontalLine(5, 10, 8, '+');
            Hline.Drow();

            VerticalLine Vline = new VerticalLine(2, 8, 2, '/');
            Vline.Drow();

            Console.ReadLine();
        }
    }
}
