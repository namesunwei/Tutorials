using Demo01_FactoryMethod.BaseClass;
using Demo01_FactoryMethod.DerivedClass;

namespace Demo01_FactoryMethod.Factory
{
    /// <summary>
    /// 加法工厂
    /// </summary>
    public class AddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
