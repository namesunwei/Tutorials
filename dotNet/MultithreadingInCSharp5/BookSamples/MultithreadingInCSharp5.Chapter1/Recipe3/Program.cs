using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recipe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            var thread = new Thread(PrintNumberWithDelay);
            thread.Start();
            thread.Join(); //调用 thread.Join()时，主线程会等待当前线程(thread)结束，然后继续执行主线程。
            Console.WriteLine("Thread completed");
            Console.ReadKey();
        }

        static void PrintNumberWithDelay()
        {
            Console.WriteLine("PrintNumberWithDelay() Starting...");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
                Console.WriteLine($"PrintNumberWithDelay()---{i}");
            }
        }
    }
}
