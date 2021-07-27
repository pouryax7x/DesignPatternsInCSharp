namespace DesignPatterns.Strategy
{
    public interface Compressor
    {
        //byte[] Compress(byte[])
        void Compress(string fileName);
    }
}
