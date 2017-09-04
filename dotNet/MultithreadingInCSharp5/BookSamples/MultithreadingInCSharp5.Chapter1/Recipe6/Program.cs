using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recipe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current thread priority:{Thread.CurrentThread.Priority}");
            Console.WriteLine($"Running on all cores available");
            RunThreads();
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            Console.WriteLine("Running on a single core");
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(1);
            RunThreads();

            Console.ReadKey();

        }

        private static void RunThreads()
        {
            var sample = new ThreadSample();
            var t1 = new Thread(sample.CountNumbers)
            {
                Name = "ThreadOne",
                Priority = ThreadPriority.Highest

            };

            var t2 = new Thread(sample.CountNumbers)
            {
                Name = "ThreadTwo",
                Priority = ThreadPriority.Lowest
            };

            t1.Start();
            t2.Start();

            Thread.Sleep(TimeSpan.FromMilliseconds(1000));

            sample.Stop();


        }

    }

    internal class ThreadSample
    {
        private bool _isStopped = false;

        public void Stop()
        {
            _isStopped = true;
        }

        public void CountNumbers()
        {
            var counter = 0;
            while (!_isStopped)
            {
                counter++;
            }
            Console.WriteLine($"{Thread.CurrentThread.Name} with {Thread.CurrentThread.Priority,10} priority has a count ={counter,13}NO");
        }
    }
}
