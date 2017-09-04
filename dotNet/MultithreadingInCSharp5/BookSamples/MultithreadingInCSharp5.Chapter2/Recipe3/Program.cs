using System;
using System.Threading;
namespace Recipe3
{
    class Program
    {
        private static readonly SemaphoreSlim Semaphore = new SemaphoreSlim(4);

        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                var threadName = $"thread{i}";
                var secondsToWait = 2 + 2 * i;
                var t = new Thread(()=>AccessDatabase(threadName, secondsToWait));
                t.Start();
            }

            Console.ReadKey();
        }

        static void AccessDatabase(string name, int seconds)
        {
            Console.WriteLine($"{name} waits to access a database");
            Semaphore.Wait();
            Console.WriteLine($"{name} was granted an access to a database");
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine($"{name} is completed");
            Semaphore.Release();
        }
    }
}
