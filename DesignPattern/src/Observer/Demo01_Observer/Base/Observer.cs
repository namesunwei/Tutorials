using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01_Observer.Base
{
    /// <summary>
    /// 观察者抽象类
    /// </summary>
    public abstract class Observer
    {
        protected string Name;
        protected ISubject Sub;

        protected Observer(string name, ISubject subject)
        {
            Name = name;
            Sub = subject;
        }

        public abstract void Update();
    }
}
