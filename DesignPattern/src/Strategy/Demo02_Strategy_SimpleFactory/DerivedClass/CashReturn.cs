using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Strategy_SimpleFactory.BaseClass;

namespace Demo02_Strategy_SimpleFactory.DerivedClass
{
    /// <summary>
    /// 返利收费子类
    /// </summary>
    public class CashReturn : CashSuper
    {
        //返利条件
        private readonly double _moneyCondition;
        //返利值
        private readonly double _moneyReturn;

        /// <summary>
        /// 初始化返利条件和返利值
        /// </summary>
        /// <param name="moneyCondition">返利条件</param>
        /// <param name="moneyReturn">返利值</param>
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            _moneyCondition = double.Parse(moneyCondition);
            _moneyReturn = double.Parse(moneyReturn);
        }

        /// <summary>
        /// 根据返利条件和返利值,返回返利后的价格
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            var result = money;
            if (money >= _moneyCondition)
            {
                return money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            }
            return result;
        }
    }
}
