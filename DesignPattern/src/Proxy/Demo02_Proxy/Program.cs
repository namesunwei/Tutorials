using System;
using Demo02_Proxy.DerivedClass;

namespace Demo02_Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mm = new SchoolGirl() { Name = "豆豆" };
            var daili = new Proxy(mm);

            daili.GiveChocolate();
            daili.GiveDolls();
            daili.GiveFlowers();

            Console.ReadKey();

        }
    }
}
