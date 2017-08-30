using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo01_Observer.Base;

namespace Demo01_Observer.Customer
{
    public class Receptionist : ISubject
    {

        private readonly IList<Observer> _observers = new List<Observer>();

        public string SubjectState { get; set; }

        //增加观察者
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        /// <summary>
        /// 减少观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// 通知观察者
        /// </summary>
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
