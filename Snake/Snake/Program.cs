using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            VerticalLine leftwall = new VerticalLine(0, 24, 0, '*');
            VerticalLine rightwall = new VerticalLine(0, 24, 78, '*');
            HorizontalLine upside = new HorizontalLine(0, 78, 0, '*');
            HorizontalLine downside = new HorizontalLine(0, 78, 24, '*');

            downside.Drow();
            rightwall.Drow();
            upside.Drow();
            leftwall.Drow();

            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadKey();
        }
    }
}
