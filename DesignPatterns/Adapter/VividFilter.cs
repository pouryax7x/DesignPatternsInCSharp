using System;

namespace DesignPatterns.Adapter
{
    public class VividFilter: Filter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("apply vivid filter");
        }
    }
}