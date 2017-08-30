using Demo02_Strategy_SimpleFactory.BaseClass;

namespace Demo02_Strategy_SimpleFactory.DerivedClass
{

    /// <summary>
    /// //正常收费的子类
    /// </summary>
    public class CashNormal : CashSuper
    {
        //正常收费,返回原价.
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
