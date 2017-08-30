using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo01_Observer.Base;

namespace Demo01_Observer.Customer
{
    public class NBAObserver : Observer
    {
        public NBAObserver(string name, ISubject subject) : base(name, subject)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{Sub.SubjectState},{Name}关闭NBA直播 , 继续工作!");
        }
    }
}
