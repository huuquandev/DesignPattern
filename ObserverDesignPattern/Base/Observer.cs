namespace ObserverDesignPattern.Base
{
    public abstract class Observer
    {
        protected Subject _subject;
        public abstract void Notify(Subject subject, object arg);
    }
}