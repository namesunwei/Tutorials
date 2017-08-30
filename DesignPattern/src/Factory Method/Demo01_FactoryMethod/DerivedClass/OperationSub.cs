using Demo01_FactoryMethod.BaseClass;

namespace Demo01_SimpleFactory.DerivedClass
{
    /// <summary>
    /// 减法运算类
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberA;
        }
    }
}
