using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recipe9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             对比2个返回结果，体会线程安全和线程不安全的差异
             当线程不安全时，会形成竞争条件(race condition),竞争条件时多线程环境中非常常见的导致错误的原因。
             */

            Console.WriteLine("Incrorect counter");
            var c = new Counter();
            var t1 = new Thread(() => TestCounter(c));
            var t2 = new Thread(() => TestCounter(c));
            var t3 = new Thread(() => TestCounter(c));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine($"Total count {c.Count}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Correct counter");
            var c1 = new CounterWithLock();

            t1 = new Thread(() => TestCounter(c1));
            t2 = new Thread(() => TestCounter(c1));
            t3 = new Thread(() => TestCounter(c1));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine($"Total count {c1.Count}");

            Console.ReadKey();
        }

        static void TestCounter(CounterBase c)
        {
            for (int i = 0; i < 100000; i++)
            {
                c.Increment();
                c.Decrement();
            }
        }
    }

    internal class Counter : CounterBase
    {
        public int Count { get; private set; }

        public override void Increment()
        {
            Count++;
        }

        public override void Decrement()
        {
            Count--;
        }
    }

    internal class CounterWithLock : CounterBase
    {
        private readonly object _syncRoot = new object();
        public int Count { get; private set; }

        public override void Increment()
        {
            lock (_syncRoot)
            {
                Count++;
            }
        }

        public override void Decrement()
        {
            lock (_syncRoot)
            {
                Count--;
            }
        }
    }

    internal abstract class CounterBase
    {
        public abstract void Increment();
        public abstract void Decrement();
    }
}
