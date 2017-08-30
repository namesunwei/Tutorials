using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Observer_delegate.Base;

namespace Demo02_Observer_delegate.Customer
{
    class StockObserver : Observer
    {
        public StockObserver(string name, ISubject subject) : base(name, subject)
        {

        }

        public void CloseStockMarket()
        {
            Console.WriteLine($"{Sub.SubjectState},{Name}也长心了,马上关闭股票行情,继续工作!");
        }
    }
}
