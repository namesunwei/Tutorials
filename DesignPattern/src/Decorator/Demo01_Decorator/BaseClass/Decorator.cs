using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_Decorator.BaseClass
{
    /// <summary>
    /// Decorator类
    /// <remarks>装饰抽象类,继承抽象类Component,从外类来扩Component类的功能,但是对Component来说,是无需知道Decorator的存在的</remarks>
    /// </summary>
    public abstract class Decorator : Component
    {
        protected Component Component;
        /// <summary>
        /// 设置Component
        /// </summary>
        /// <param name="component"></param>
        public void SetComponent(Component component)
        {
            Component = component;
        }
        /// <summary>
        /// 重写Operation(),实际执行的是component的Operation()
        /// </summary>
        public override void Operation()
        {
            Component?.Operation();
        }
    }
}
