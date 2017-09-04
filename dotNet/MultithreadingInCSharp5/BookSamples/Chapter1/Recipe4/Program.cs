using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recipe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");
            var t1 = new Thread(PrintNumbersWithDelay);
            t1.Start();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            t1.Abort(); //终止当前线程t1
            Console.WriteLine("t1 Thread has been aborted.");
            var t2 = new Thread(PrintNumbers);
            t2.Start();
            PrintNumbers(); ;

            Console.ReadKey();
        }
        private static void PrintNumbers()
        {
            Console.WriteLine("Starting...");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void PrintNumbersWithDelay()
        {
            Console.WriteLine("Starting...");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
                Console.WriteLine(i);
            }
        }
    }
}
