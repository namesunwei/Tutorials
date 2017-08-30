using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Decorator.BaseClass;

namespace Demo01_Decorator.DerivedClass
{
    /// <summary>
    /// ConcreteComponent类
    /// <remarks>定义一个具体的对象,也可以给这个对象添加一些职责</remarks>
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}
