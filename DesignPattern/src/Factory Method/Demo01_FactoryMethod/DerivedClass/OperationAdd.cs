using Demo01_FactoryMethod.BaseClass;

namespace Demo01_FactoryMethod.DerivedClass
{
    /// <summary>
    /// 加法运算类
    /// </summary>
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
