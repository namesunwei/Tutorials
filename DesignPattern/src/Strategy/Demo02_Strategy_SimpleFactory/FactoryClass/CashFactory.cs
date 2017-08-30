using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Strategy_SimpleFactory.BaseClass;
using Demo02_Strategy_SimpleFactory.DerivedClass;

namespace Demo02_Strategy_SimpleFactory.FactoryClass
{
    /// <summary>
    /// 算法工厂类
    /// </summary>
    public class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打八折":
                    cs = new CashRebate("0.8");
                    break;
            }
            return cs;
        }
    }
}
