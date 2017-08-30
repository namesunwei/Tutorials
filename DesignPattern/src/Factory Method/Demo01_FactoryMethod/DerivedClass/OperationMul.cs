using Demo01_FactoryMethod.BaseClass;

namespace Demo01_FactoryMethod.DerivedClass
{
    /// <summary>
    /// 乘法运算类
    /// </summary>
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
}
