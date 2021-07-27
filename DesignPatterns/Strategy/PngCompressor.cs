using System;

namespace DesignPatterns.Strategy
{
    public class PngCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing Using Png");
        }
    }
}
