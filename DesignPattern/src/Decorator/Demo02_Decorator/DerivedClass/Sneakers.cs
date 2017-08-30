using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Decorator.BaseClass;

namespace Demo02_Decorator.DerivedClass
{
    public class Sneakers : Finery
    {
        public override void ShowStyle()
        {
            Console.Write("运动鞋 ");
            base.ShowStyle();
        }
    }
}
