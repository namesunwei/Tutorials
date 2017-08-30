using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_Decorator.BaseClass
{
    /// <summary>
    /// Component类 
    /// <remarks>是定义一个对象接口,可以给这些对象动态添加职责(功能)</remarks>
    /// </summary>
    public abstract class Component
    {
        public abstract void Operation();
    }
}
