using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_FactoryMethod.BaseClass;
using Demo01_FactoryMethod.Factory;

namespace Demo01_FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFactory operFactory = new AddFactory(); //这里可以实例化任何具体方法的工厂
            var oper = operFactory.CreateOperation(); 
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());
            Console.ReadKey();
        }
    }
}
