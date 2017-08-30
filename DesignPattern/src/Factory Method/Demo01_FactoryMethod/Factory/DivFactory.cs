using Demo01_FactoryMethod.BaseClass;
using Demo01_FactoryMethod.DerivedClass;

namespace Demo01_FactoryMethod.Factory
{
    /// <summary>
    /// 除法工厂
    /// </summary>
    public class DivFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
