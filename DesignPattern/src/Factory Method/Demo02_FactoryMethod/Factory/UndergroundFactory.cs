using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_FactoryMethod.BaseClass;
using Demo02_FactoryMethod.DerivedClass;

namespace Demo02_FactoryMethod.Factory
{
    /// <summary>
    /// 大学生工厂类
    /// </summary>
    public class UndergroundFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }
}
