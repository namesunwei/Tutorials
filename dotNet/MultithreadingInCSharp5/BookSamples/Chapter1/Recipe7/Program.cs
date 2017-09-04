using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recipe7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             当第一个（前台）线程完成后，程序结束并且后台线程被终结。这是前台线程与后台线程的主要区别。
             进程会等待所有的前台线程完成工作后再结束工作，但是如果只剩下后台线程，则会直接结束工作。
             如果定义了一个不会完成的前台线程，主程序并不会正常结束。
             */
            var sampleForeground = new ThreadSample(10);
            var sampleBackground = new ThreadSample(20);

            var t1 = new Thread(sampleForeground.CountNumbers)
            {
                Name = "ForegroundThread"
            };
            var t2 = new Thread(sampleBackground.CountNumbers)
            {
                Name = "BackgroundThread",
                IsBackground = true
            };

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }

    }

    class ThreadSample
    {
        private readonly int _iterations;

        public ThreadSample(int iterations)
        {
            _iterations = iterations;
        }

        public void CountNumbers()
        {
            for (int i = 0; i < _iterations; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
                Console.WriteLine($"{Thread.CurrentThread.Name} prints {i}");
            }
        }
    }
}
