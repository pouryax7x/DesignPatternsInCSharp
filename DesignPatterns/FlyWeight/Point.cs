using System;

namespace DesignPatterns.FlyWeight
{
    public class Point
    {
        private int x;
        private int y;
        private PointIcon icon;

        public Point(int x, int y , PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public void draw()
        {
            Console.WriteLine($"{icon.Type} at ({x} , {y})");
        }
    }
}