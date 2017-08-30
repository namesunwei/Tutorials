using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Strategy_SimpleFactory.BaseClass;
using Demo02_Strategy_SimpleFactory.DerivedClass;

namespace Demo02_Strategy_SimpleFactory.ContextClass
{
    #region 策略模式的上下文类
    /// <summary>
    /// 策略模式的上下文类
    /// </summary>
    public class CashContext
    {
        private readonly CashSuper _cs;
        public CashContext(CashSuper csuper)
        {
            _cs = csuper;
        }
        public double GetResult(double money)
        {
            return _cs.AcceptCash(money);
        }
    }
    #endregion

    #region 结合简单工厂模式的策略模式的上下文类
    /// <summary>
    /// 结合简单工厂模式的上下文类
    /// </summary>
    public class CashContext2
    {
        private readonly CashSuper _cs;
        //将简单工厂类以方法的形式封装到上下文类Context中
        public CashContext2(string type)
        {
            switch (type)
            {
                case "正常收费":
                    _cs = new CashNormal();
                    break;
                case "满300返100":
                    _cs = new CashReturn("300", "100");
                    break;
                case "打八折":
                    _cs = new CashRebate("0.8");
                    break;
            }
        }
        public double GetResult(double money)
        {
            return _cs.AcceptCash(money);
        }
    }
    #endregion
}
