using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_FactoryMethod.BaseClass
{
    /// <summary>
    /// 工厂接口
    /// <remarks></remarks>
    /// </summary>
    public interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }
}
