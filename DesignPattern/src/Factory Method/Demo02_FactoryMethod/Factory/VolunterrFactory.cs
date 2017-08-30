using Demo02_FactoryMethod.BaseClass;
using Demo02_FactoryMethod.DerivedClass;

namespace Demo02_FactoryMethod.Factory
{
    public class VolunterrFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
