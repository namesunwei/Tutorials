using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Observer_delegate.Base;

namespace Demo02_Observer_delegate.Customer
{
    class Receptionist : ISubject
    {
        public string SubjectState { get; set; }

        internal delegate void EventHandler();

        public event EventHandler Update;
        /// <summary>
        /// 通知方法. 通过委托的方式改变通知之后的行为(方法)
        /// </summary>
        public void Notify()
        {
            Update?.Invoke();
        }
    }
}
