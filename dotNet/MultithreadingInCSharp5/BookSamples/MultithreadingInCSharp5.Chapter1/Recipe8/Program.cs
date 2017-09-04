using System;
using System.Threading;

namespace Recipe8
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = new ThreadSample(10);

            var t1 = new Thread(sample.CountNumbers)
            {
                Name = "ThreadOne"
            };
            t1.Start();
            t1.Join();
            Console.WriteLine("-------------------------");

            var t2 = new Thread(Count)
            {
                Name = "ThreadTwo"
            };
            t2.Start(8); //Thread.Start()方法只接受object类型的单个参数。
            t2.Join();
            Console.WriteLine("-------------------------");
            /*
             使用Lambda表达式引用另一个C#对喜爱那个的方式被称为闭包。
             当在Lambda表达式中使用任何局部变量时，C#会生成一个类，并将该变量作为该类的一个属性。
             所以实际上该方式与ThreadOne线程中使用的方式一样。但是我们无须定义该类，C#编译器会自动帮我们实现。
             */
            var t3 = new Thread(() => CountNumbers(12)) 
            {
                Name = "ThreadThree"
            };
            t3.Start();
            t3.Join();
            Console.WriteLine("-------------------------");

            var i = 10;
            var t4 = new Thread(() => PrintNumbers(i));
            i = 20;
            var t5 = new Thread(() => PrintNumbers(i));

            //如果在多个Lambda表达式中使用相同的变量，他们会共享该变量的值。
            t4.Start();
            t5.Start();

            Console.ReadKey();
        }

        private static void Count(object iterations)
        {
            CountNumbers((int)iterations);
        }

        private static void CountNumbers(int iterations)
        {
            for (var i = 0; i <= iterations; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
                Console.WriteLine($"{Thread.CurrentThread.Name} prints {i}");
            }
        }

        private static void PrintNumbers(int number)
        {
            Console.WriteLine(number);
        }
    }

    internal class ThreadSample
    {
        private readonly int _iterations;

        public ThreadSample(int iterations)
        {
            _iterations = iterations;
        }

        public void CountNumbers()
        {
            for (var i = 0; i <= _iterations; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
                Console.WriteLine($"{Thread.CurrentThread.Name} prints {i}");
            }
        }
    }
}
