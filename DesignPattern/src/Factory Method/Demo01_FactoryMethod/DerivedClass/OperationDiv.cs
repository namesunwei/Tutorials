using System;
using Demo01_FactoryMethod.BaseClass;

namespace Demo01_FactoryMethod.DerivedClass
{
    /// <summary>
    /// 除法运算类
    /// </summary>
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0.");
            }
            return NumberA / NumberB;
        }
    }
}
