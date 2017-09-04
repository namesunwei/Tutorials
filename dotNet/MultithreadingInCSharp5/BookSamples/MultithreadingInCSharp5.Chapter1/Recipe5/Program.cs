using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recipe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");
            var t1 =new Thread(PrintNumbersWithStatus);
            var t2 =new Thread(DoNothing);
            Console.WriteLine(t1.ThreadState.ToString());
            t2.Start();
            t1.Start();
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(t1.ThreadState.ToString());
            }
            Thread.Sleep(TimeSpan.FromSeconds(6));
            t1.Abort();
            Console.WriteLine("A thread has been aborted.");
            Console.WriteLine(t1.ThreadState.ToString());
            Console.WriteLine(t2.ThreadState.ToString());

            Console.ReadKey();
        }

        private static void DoNothing()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        private static void PrintNumbersWithStatus()
        {
            Console.WriteLine("Starting...");
            Console.WriteLine(Thread.CurrentThread.ThreadState.ToString());
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(2000));
                Console.WriteLine(i);
            }
        }
    }
}
