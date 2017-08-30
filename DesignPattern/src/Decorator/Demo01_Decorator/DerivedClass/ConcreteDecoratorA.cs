using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Decorator.BaseClass;

namespace Demo01_Decorator.DerivedClass
{
    /// <summary>
    /// ConcreteDecoratorA 类
    /// <remarks>实现具体职责(功能)的对象</remarks>
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        public string AddedState;

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("具体装饰对象A的操作");
            AddedState = "New State";
            Console.WriteLine($"ConcreteDecoratorA独有功能:{AddedState}");
        }
    }
}
