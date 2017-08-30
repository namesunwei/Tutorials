using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Builder.BaseClass;

namespace Demo01_Builder.DerivedClass
{
    /// <summary>
    /// ConcreteBuilder2 类
    /// <remarks>具体的建造者类</remarks>
    /// </summary>
    internal class ConcreteBuilder2 : Builder
    {
        private readonly Product _product = new Product();
        internal override void BuildPartA()
        {
            _product.Add("部件X");
        }

        internal override void BuildPartB()
        {
            _product.Add("部件Y");
        }

        internal override Product GetResult()
        {
            return _product;
        }
    }
}
