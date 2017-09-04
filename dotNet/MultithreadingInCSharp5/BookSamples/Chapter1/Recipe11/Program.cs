using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recipe11
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(FaultyThread);
            t1.Start();
            t1.Join();

            try
            {
                var t2 = new Thread(BadFaultyThread);
                t2.Start();
            }
            catch (Exception )
            {
                /*
                 * 这里并不能捕获到t2线程的异常。
                 * 一般来说，不要在线程中抛出异常，而是在线程代码中使用try/catch代码块。
                 */
                Console.WriteLine($"We won't get here!");
                
            }

            Console.ReadKey();
        }

        private static void BadFaultyThread()
        {
            Console.WriteLine("Starting a faulty thread ...");
            Thread.Sleep(TimeSpan.FromMilliseconds(2000));
            throw new Exception("Boom!");
        }

        private static void FaultyThread()
        {
            try
            {
                Console.WriteLine("Starting a faulty thread ...");
                Thread.Sleep(TimeSpan.FromMilliseconds(2000));
                throw new Exception("Boom!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception handled :{ex.Message}");
            }
        }
    }
}
