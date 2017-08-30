using Demo01_FactoryMethod.BaseClass;
using Demo01_FactoryMethod.DerivedClass;

namespace Demo01_FactoryMethod.Factory
{
    /// <summary>
    /// 乘法工厂
    /// </summary>
    public class MulFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
