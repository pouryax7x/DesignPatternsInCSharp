using System.Collections.Generic;

namespace DesignPatterns.Mediator.Observer
{
    public class UIControl
    {
          private List<Observer> observers = new List<Observer>();

          public void Attach(Observer observer)
          {
              observers.Add(observer);
          }

          protected void NotifyObservers()
          {
              foreach (var observer in observers)
              {
                  observer.Update();
              }
          }
    }
}