using System;
using Demo01_Observer.Customer;

namespace Demo01_Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //初始化统治者
            var receptionist = new Receptionist();

            //初始化观察者
            var tongshi1 = new StockObserver("倒霉鬼", receptionist);
            var tongshi2 = new NBAObserver("幸运儿", receptionist);

            receptionist.Attach(tongshi1);
            receptionist.Attach(tongshi2);

            receptionist.Detach(tongshi1);

            //发现请狂
            receptionist.SubjectState = "胡汉三回来了!";

            //发出通知
            receptionist.Notify();

            Console.ReadKey();
        }
    }
}
