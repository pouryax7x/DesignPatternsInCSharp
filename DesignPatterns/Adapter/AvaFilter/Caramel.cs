using System;

namespace DesignPatterns.Adapter.AvaFilter
{
    public class Caramel
    {
        public void init()
        {

        }

        public void Render(Image image)
        {
            Console.WriteLine("appling caramel filter");
        }
    }
}