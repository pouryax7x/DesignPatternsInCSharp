using System;

namespace DesignPatterns.Strategy
{
    public class HighContrastFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Apply High Contrast Filter");
        }
    }
}
