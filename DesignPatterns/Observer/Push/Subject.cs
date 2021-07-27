using System.Collections.Generic;

namespace DesignPatterns.Observer.Push
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver<T>(T value)
        {
            foreach (var observer in observers)
            {
                observer.Update(value);
            }
        }
    }
}
