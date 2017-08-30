using System;
using Demo02_AbstractFactory_SimpleFactory.Base;
using Demo02_AbstractFactory_SimpleFactory.Models;

namespace Demo02_AbstractFactory_SimpleFactory.Customer
{
    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access中根据Id得到Department表的一条记录.");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在Access中给Department表增加一条记录.");
        }
    }
}
