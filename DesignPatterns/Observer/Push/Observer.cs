namespace DesignPatterns.Observer.Push
{
    public interface Observer
    {
        void Update<T>(T value);
    }
}