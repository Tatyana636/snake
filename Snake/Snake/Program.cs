using System;
using System.Collections.Generic;
using System.Threading;


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
            VerticalLine DownLine = new VerticalLine(MINXY, WIGHT, HEIGHT, HVLINE);


            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);


            UpLne.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(WIGHT, HEIGHT, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            List<Figure> figures = new List<Figure>();
            figures.Add(snake);
            figures.Add(v1);
            figures.Add(DownLine);
            figures.Add(LeftLine);
            figures.Add(RightLine);

            foreach (var f in figures)
            {
                f.Drow();
            }

        static void Draw(Figure figure)
        {
            figure.Drow();
        }
    }
}
}
