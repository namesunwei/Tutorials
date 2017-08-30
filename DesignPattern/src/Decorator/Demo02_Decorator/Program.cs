using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Decorator.BaseClass;
using Demo02_Decorator.DerivedClass;

namespace Demo02_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name = "小菜" };

            var dtx = new TShirts();
            var kk = new BigTrouser();
            var pqx = new Sneakers();

            Console.WriteLine("第一种装扮:");

            //装扮过程:
            dtx.Decorate(p);
            kk.Decorate(dtx);
            pqx.Decorate(kk);
            pqx.ShowStyle();

            Console.ReadKey();
        }
    }
}
