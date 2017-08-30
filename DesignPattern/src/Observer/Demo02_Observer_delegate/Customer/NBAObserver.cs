using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Observer_delegate.Base;

namespace Demo02_Observer_delegate.Customer
{
    class NBAObserver : Observer
    {
        public NBAObserver(string name, ISubject subject) : base(name, subject)
        {
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine($"{Sub.SubjectState},{Name}关闭NBA直播 , 继续工作!");
        }
    }
}
