using System;
using System.Threading;

namespace Recipe1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             设置断点，逐语句调试，体会多线程
             */
            var thread = new Thread(PrintNumbers);  //创建另外一个线程
            thread.Start(); //启动当前线程

            PrintNumbers();

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
    }
}
