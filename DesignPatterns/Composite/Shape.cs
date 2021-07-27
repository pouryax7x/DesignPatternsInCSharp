using System;

namespace DesignPatterns.Composite
{
    public class Shape: Component
    {
        public void Render()
        {
            Console.WriteLine("Render Shape");
        }

        public void Move()
        {
            Console.WriteLine("Move Shape");
        }
    }
}