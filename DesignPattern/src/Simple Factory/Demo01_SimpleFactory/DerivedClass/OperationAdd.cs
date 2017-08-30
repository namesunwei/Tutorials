using Demo01_SimpleFactory.BaseClass;

namespace Demo01_SimpleFactory.DerivedClass
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
