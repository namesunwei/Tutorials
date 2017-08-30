using Demo01_FactoryMethod.BaseClass;
using Demo01_SimpleFactory.DerivedClass;

namespace Demo01_FactoryMethod.Factory
{
    /// <summary>
    /// 减法工厂
    /// </summary>
    public class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
