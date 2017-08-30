using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Strategy_SimpleFactory.BaseClass
{
    /// <summary>
    /// 现金收费的抽象类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 现金收费的抽象方法,收取现金,参数为原价,返回当前价格
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public abstract double AcceptCash(double money);
    }
}
