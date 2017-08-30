using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Decorator.BaseClass
{
    /// <summary>
    /// 具体的对象Person类
    /// <remarks>相当于ConcreteComponent类</remarks>
    /// </summary>
    public class Person
    {
        public string Name { get; set; }

        public virtual void ShowStyle()
        {
            Console.WriteLine($"装扮的{Name}");
        }
    }
}
