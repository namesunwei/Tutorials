using System;
using Demo01_Decorator.DerivedClass;

namespace Demo01_Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cc = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            /*
             * 装饰的方法是:首先用ConcreteComponent实例化对象cc,
             * 然后用ConcreteDecoratorA的实例化对象d1来包装cc,
             * 再用ConcreteDecoratorB的实例化对象d2来包装d1,            
             */
            d1.SetComponent(cc);
            d2.SetComponent(d1);
          
            /*
            * 最终执行d2的Operation()方法
            * 执行d2的Operation()的流程是:
            * d2.Operation()->base.Operation()->
            * [d1的Operation()]->base.Operation()->
            * ["cc的Operation()"]->
            * d1.Operation()的剩余方法->
            * d2.Operation()的剩余方法.
            */

            d2.Operation();

            Console.ReadKey();
        }
    }
}
