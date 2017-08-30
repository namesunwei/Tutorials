using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Decorator.BaseClass;

namespace Demo01_Decorator.DerivedClass
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("具体装饰对象B的操作");
            AddedBehavior();
           
        }

        private static void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB独有的方法,以区别ConcreteDecoratorA");
        }
    }
}
