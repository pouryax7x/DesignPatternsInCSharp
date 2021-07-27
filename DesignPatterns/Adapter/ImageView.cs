namespace DesignPatterns.Adapter
{
    public class ImageView
    {
        private Image _image;

        public ImageView(Image image)
        {
            this._image = image;
        }

        public void Apply(Filter filter)
        {
            filter.Apply(_image);
        }
    }
}