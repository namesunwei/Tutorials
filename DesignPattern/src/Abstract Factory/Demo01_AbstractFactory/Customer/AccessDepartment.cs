using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_AbstractFactory.Base;
using Demo01_AbstractFactory.Models;

namespace Demo01_AbstractFactory.Customer
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
