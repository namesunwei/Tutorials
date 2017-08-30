using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_AbstractFactory.Models;

namespace Demo01_AbstractFactory.Base
{
    /// <summary>
    /// 提供操作Department表方法的接口
    /// </summary>
    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);

    }
}
