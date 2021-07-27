using System;

namespace DesignPatterns.Observer.Push
{
    public class SpreardSheet : Observer
    {
        public void Update<T>(T value)
        {
            Console.WriteLine("Spreard Sheet Updated" + value);
        }
    }
}