namespace DesignPatterns.Strategy
{
    public class ImageStorage
    {
        private Compressor _compressor;
        private Filter _filter;

        public ImageStorage(Compressor compressor, Filter filter)
        {
            _compressor = compressor;
            _filter = filter;
        }

        public void Store(string fileName)
        {
            _compressor.Compress(fileName);
            _filter.Apply(fileName);
        }
    }
}
