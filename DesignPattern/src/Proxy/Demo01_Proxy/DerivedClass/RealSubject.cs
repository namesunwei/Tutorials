using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Proxy.BaseClass;

namespace Demo01_Proxy.DerivedClass
{
    /// <summary>
    /// RealSubject类
    /// <remarks>定义Proxy所代表的的真实实体对象</remarks>
    /// </summary>
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实对象的请求");
        }
    }
}
