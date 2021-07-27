using DesignPatterns.Adapter.AvaFilter;

namespace DesignPatterns.Adapter
{
    public class CaramelFilter:Filter
    {
        private Caramel _caramel;

        public CaramelFilter(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(Image image)
        {
            _caramel.init();
            _caramel.Render(image);
        }
    }
}