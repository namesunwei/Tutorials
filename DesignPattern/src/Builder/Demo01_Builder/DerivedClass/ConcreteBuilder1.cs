using Demo01_Builder.BaseClass;

namespace Demo01_Builder.DerivedClass
{
    /// <summary>
    /// ConcreteBuilder 类
    /// <remarks>具体的建造者类</remarks>
    /// </summary>
    internal class ConcreteBuilder1 : Builder
    {
        private readonly Product _product = new Product();
        internal override void BuildPartA()
        {
            _product.Add("部件A");
        }

        internal override void BuildPartB()
        {
            _product.Add("部件B");
        }

        internal override Product GetResult()
        {
            return _product;
        }
    }
}
