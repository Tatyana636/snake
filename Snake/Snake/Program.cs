using System;
using System.Collections.Generic;
using System.Threading;


namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            int WIGHT = 50;
            int HEIGHT = 20;

            Console.SetWindowSize(WIGHT + 2, HEIGHT + 2);
            Console.SetBufferSize(WIGHT + 2, HEIGHT + 2);

            Wall walls = new Wall(WIGHT, HEIGHT);
            walls.Drow();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(WIGHT, HEIGHT, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
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
        }


        static void Draw(Figure figure)
        {
            figure.Drow();
        }
    }
}
