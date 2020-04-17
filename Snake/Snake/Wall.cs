using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    internal class Wall
    {
        const int MINXY = 0;
        const char SYM = '*';

        List<Figure> wallList;

        public Wall(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine UpLine = new HorizontalLine(MINXY, mapWidth, MINXY, SYM);
            HorizontalLine DownLine = new HorizontalLine(MINXY, mapWidth, mapHeight, SYM);
            VerticalLine LeftLine = new VerticalLine(MINXY, MINXY, mapHeight, SYM);
            VerticalLine RightLine = new VerticalLine(mapWidth, MINXY, mapHeight, SYM);

            wallList.Add(UpLine);
            wallList.Add(DownLine);
            wallList.Add(LeftLine);
            wallList.Add(RightLine);
        }


        public void Drow()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
