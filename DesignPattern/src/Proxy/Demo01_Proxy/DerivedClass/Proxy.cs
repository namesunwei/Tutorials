using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Proxy.BaseClass;

namespace Demo01_Proxy.DerivedClass
{
    /// <summary>
    /// Proxy类
    /// <remarks>保存一个引用使得代理可以访问的实体,并提供一个与Subject的接口相同的接口,这样代理就可以用来代替真实实体了.</remarks>
    /// </summary>
    public class Proxy : Subject
    {
        public RealSubject RealSubject;
        public override void Request()
        {
            if (RealSubject == null)
            {
                RealSubject = new RealSubject();
            }
            RealSubject.Request(); ;
        }
    }
}
