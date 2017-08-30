using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_Observer_delegate.Customer;

namespace Demo02_Observer_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var receptionist = new Receptionist();

            var tongshi1 = new StockObserver("倒霉鬼", receptionist);
            var tongshi2 = new NBAObserver("幸运儿", receptionist);

            receptionist.Update += tongshi1.CloseStockMarket;
            receptionist.Update += tongshi2.CloseNBADirectSeeding;

            receptionist.SubjectState = "胡汉三回来了!";

            receptionist.Notify();

            Console.ReadKey();
        }
    }
}
