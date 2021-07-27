using System;

namespace DesignPatterns.Observer.Push
{
    public class Chart : Observer
    {
        public void Update<T>(T value)
        {
            Console.WriteLine("Chart Updated" + value);
        }

    }
}