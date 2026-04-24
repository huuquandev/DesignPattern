using System;
using System.Collections.Generic;

namespace ObserverDesignPattern.Base
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();
        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }
        public void DetachObserver(Observer observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers(Subject subject, object arg)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(subject, arg);
            }
        }

    }
}