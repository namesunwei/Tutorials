using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recipe2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            设置断点，逐语句调试，体会多线程
            */
            var thread = new Thread(PrintNumberWithDelay);
            thread.Start();
            PrintNumbers();

            Console.ReadKey();
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("PrintNumbers() Starting...");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"PrintNumbers()--->{i}");
            }
        }

        private static void PrintNumberWithDelay()
        {
            Console.WriteLine("PrintNumberWithDelay() Starting...");
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(500)); //当前线程暂停500毫秒
                Console.WriteLine($"PrintNumberWithDelay()--->{i}");
            }
        }
    }
}
