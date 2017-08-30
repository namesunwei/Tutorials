using Demo01_SimpleFactory.BaseClass;

namespace Demo01_SimpleFactory.DerivedClass
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
