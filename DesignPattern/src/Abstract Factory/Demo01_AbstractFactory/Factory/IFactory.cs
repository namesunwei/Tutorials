using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_AbstractFactory.Base;

namespace Demo01_AbstractFactory.Factory
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
}
