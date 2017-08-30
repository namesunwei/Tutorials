using System;
using Demo03_AbstractFactory_Reflection.Base;
using Demo03_AbstractFactory_Reflection.Models;

namespace Demo03_AbstractFactory_Reflection.Customer
{
    class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SqlServer中根据Id得到Department表的一条记录.");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在SqlServer中给Department表增加一条记录.");
        }
    }
}
