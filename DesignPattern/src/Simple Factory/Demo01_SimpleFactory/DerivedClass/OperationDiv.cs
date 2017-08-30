using System;
using Demo01_SimpleFactory.BaseClass;

namespace Demo01_SimpleFactory.DerivedClass
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
