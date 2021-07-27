using System;

namespace DesignPatterns.Strategy
{
    public class BWFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Apply BW Filter");
        }
    }
}
