namespace SingletonDesignPattern
{
    public class Singleton
    {
        // private static Singleton uniqueInstance = new Singleton();
        private int _index;
        private static readonly object lockObject = new object();
        private static volatile Singleton uniqueInstance;

        private Singleton(int index)
        {
            this._index = index;
        }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (lockObject)
                {
                    if(uniqueInstance == null)
                    {
                        var random = new Random();             
                        uniqueInstance = new Singleton(random.Next(1, 4));
                    }
                }
            }
            return uniqueInstance;
        }

        public void SayHi()
        {
            Console.WriteLine("Hello everyone, I am Number " + _index);
        }
    }
}