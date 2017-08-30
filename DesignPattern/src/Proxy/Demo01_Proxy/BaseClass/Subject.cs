using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_Proxy.BaseClass
{
    /// <summary>
    /// Subject类
    /// <remarks>定义了RealSubject和Proxy的共同接口</remarks>
    /// </summary>
    public abstract class Subject
    {
        public abstract void Request();
    }
}
