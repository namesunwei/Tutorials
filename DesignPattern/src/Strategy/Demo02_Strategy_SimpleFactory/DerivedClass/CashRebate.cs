using Demo02_Strategy_SimpleFactory.BaseClass;

namespace Demo02_Strategy_SimpleFactory.DerivedClass
{
    /// <summary>
    /// 打折收费的子类
    /// </summary>
    public class CashRebate : CashSuper
    {
        private readonly double _moneyRebate;
        /// <summary>
        /// 初始化折扣率
        /// </summary>
        /// <param name="moneyRebate">折扣率</param>
        public CashRebate(string moneyRebate)
        {
            _moneyRebate = double.Parse(moneyRebate);
        }
        /// <summary>
        /// 根据折扣率,返回打折后的价格.
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money * _moneyRebate;
        }
    }
}
