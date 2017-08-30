using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Strategy.BaseClass;

namespace Demo01_Strategy.DerivedClass
{
    /// <summary>
    /// 算法A的类
    /// </summary>
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A的实现");
        }
    }
}
