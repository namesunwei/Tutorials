using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Recipe10
{
    class Program
    {
        static void Main(string[] args)
        {
            var lock1 = new object();
            var lock2 = new object();

            new Thread(() => LockTooMuch(lock1, lock2)).Start();

            lock (lock2)
            {
                Thread.Sleep(1000);
                Console.WriteLine(@"Monitor.TryEnter allows not to get
                  stuck,returning false a specified timeout is elapsed
                ");
                if (Monitor.TryEnter(lock1,TimeSpan.FromSeconds(5)))
                {
                    Console.WriteLine("Acquired a protected resource successfully");
                }
                else
                {
                    Console.WriteLine("Timeout acquiring a resource !");
                }
            }

            new  Thread(()=>LockTooMuch(lock1,lock2)).Start();
            Console.WriteLine("-----------------------------------------------------");
            lock (lock2)
            {
                Console.WriteLine("This will be a deadlock");
                Thread.Sleep(1000);
                lock (lock1)
                {
                    Console.WriteLine("Acquired a protected resource successfully");
                }
            }
        }

        static void LockTooMuch(object lock1, object lock2)
        {
            lock (lock1)
            {
                Thread.Sleep(1000);
                lock (lock2)
                {

                }
            }
        }
    }
}
