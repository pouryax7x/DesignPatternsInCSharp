using System;

namespace DesignPatterns.Strategy
{
    public class JpgCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Commpress using jpg");
        }
    }
}
