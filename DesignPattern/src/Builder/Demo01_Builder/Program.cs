using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Builder.DerivedClass;

namespace Demo01_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var b1 = new ConcreteBuilder1();
            var b2 = new ConcreteBuilder2();

            director.Construct(b1);
            var product1 = b1.GetResult();
            product1.Show();

            director.Construct(b2);
            var product2 = b2.GetResult();
            product2.Show();

            Console.ReadKey();
        }
    }
}
