using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Point p1 = new Point(1, 3, '*');
             p1.Draw(1, 3, '*');

             Point p2 = new Point(4, 5, '#');
             p2.Draw(4, 5, '#');

             List<int> numList = new List<int>();
             numList.Add(0);
             numList.Add(1);
             numList.Add(2);

             int x = numList[0];
             int y = numList[1];
             int c = numList[2];

            foreach(int i in numList)
             {
                 Console.WriteLine(i);
             }

             numList.RemoveAt(0);
             Console.WriteLine("Удаление элемента");
             foreach (int i in numList)
             {
                 Console.WriteLine(i);
             }*/

            List<Point> pList = new List<Point>{ new Point(1, 3, '*'),  new Point(4, 5, '-'),
            new Point(7, 6, '&'), new Point(4, 3, '%') };

            pList.Remove(pList[0]);

            pList.Insert(2, new Point(5, 9, '$'));

            for (int i = 0; i < pList.Count; i++)
            {
                int num = i + 1;
                Console.WriteLine("Точка " + num + " имеет координаты: (x" + pList[i].x + "), y(" + pList[i].y +
                    ") и символ (" + pList[i].sym +")");
            }



            Console.ReadLine();
        }
    }
}
