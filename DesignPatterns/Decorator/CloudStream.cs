using System;

namespace DesignPatterns.Decorator
{
    public class CloudStream : Stream
    {
        public void Write(string data)
        {
            Console.WriteLine("storing "+ data);
        }

    }
}