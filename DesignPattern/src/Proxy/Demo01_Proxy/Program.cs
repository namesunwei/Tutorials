using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Proxy.DerivedClass;

namespace Demo01_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }
}
