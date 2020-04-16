using System;
using System.Collections.Generic;


namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            int MINCHAR = 33;
            int MAXCHAR = 42;
            int MAXPOINT = 10;
            int MINXY = 0;
            char HVLINE = '#';
            int WIGHT = 50;
            int HEIGHT = 20; 

            Console.SetWindowSize(WIGHT + 2, HEIGHT + 2);
            Console.SetBufferSize(WIGHT + 2, HEIGHT + 2);

            HorizontalLine LeftLine = new HorizontalLine(MINXY, WIGHT, MINXY, HVLINE);
            HorizontalLine RightLine = new HorizontalLine(MINXY, WIGHT, HEIGHT, HVLINE);
            VerticalLine UpLne = new VerticalLine(MINXY, MINXY, HEIGHT, HVLINE);
            VerticalLine DownLine = new VerticalLine(WIGHT, MINXY, HEIGHT, HVLINE);
            DownLine.Drow();
            UpLne.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadKey();
        }

    }
}
