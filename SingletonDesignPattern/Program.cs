using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton.GetInstance().SayHi();
            var thread1 = new Thread(() => Singleton.GetInstance().SayHi());
            var thread2 = new Thread(() => Singleton.GetInstance().SayHi());
            thread1.Start();
            thread2.Start();
        }
    }
}
