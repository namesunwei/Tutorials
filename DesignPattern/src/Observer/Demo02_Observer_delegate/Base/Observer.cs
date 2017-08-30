using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Observer_delegate.Base
{
    class Observer
    {
        protected string Name;
        protected ISubject Sub;

        protected Observer(string name, ISubject subject)
        {
            Name = name;
            Sub = subject;
        }
    }
}
