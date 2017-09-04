using System;
using System.Threading;

namespace Recipe2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mutexName ="CSharpThreadingCookbook";

            using (var m = new Mutex(false,mutexName))
            {
                if (!m.WaitOne(TimeSpan.FromSeconds(5),false))
                {
                    Console.WriteLine("Second instance is running!");
                }
                else
                {
                    Console.WriteLine("Running!");
                    Console.ReadLine();
                    m.ReleaseMutex();
                }
            }
        }
    }
}
