namespace DesignPatterns.Decorator
{
    public class ComressedCloudStream: Stream
    {
        private Stream stream;

        public ComressedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }

        public void Write(string data)
        {
            var compressed = Compress(data);
            stream.Write(compressed);
        }
    }
}