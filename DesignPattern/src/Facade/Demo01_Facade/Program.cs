using System;

namespace Demo01_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             由于Facade类的存在,客户端可以根本不用知道三个子系统的存在
             */
            var facade = new Facade();

            facade.MethodA();

            facade.MethodB();

            Console.ReadKey();
        }
    }
}
