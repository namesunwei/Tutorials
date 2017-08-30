using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Decorator.BaseClass;

namespace Demo02_Decorator.DerivedClass
{
    /// <summary>
    /// T-Shirt 装扮
    /// </summary>
    public class TShirts : Finery
    {
        public override void ShowStyle()
        {
            Console.Write(" 白T-Shirt ");
            base.ShowStyle();
        }
    }
}
